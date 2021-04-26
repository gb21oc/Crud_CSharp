using crud.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class ModificaUser : Form
    {
        bool verificaDoubleClick = false;
        int idAtual;
        string permissao;
        string emailLogin;
        public ModificaUser()
        {
            InitializeComponent();
            btnSalvar.Enabled = true;
            if (permissao == "Comum")
            {
                btnSalvar.Enabled = false;
            }
        }

        public void LimparDados()
        {
            txtNome_User.Text           = "";
            txtEmail_User.Text          = "";
            txtMsgSuporte.Text          = "";
            txtNameMsg.Text             = "";
            cbPermissao.SelectedItem    = null;
            btnDeletar.Enabled          = false;
            if (permissao == "Comum") {
                btnSalvar.Enabled = false;
            }
        }

        public void sqlPreencheDataGrid(string sql)
        {
            ConexaoDb conexao = new ConexaoDb();
            DataTable tb = conexao.DataTable_ConsultarDados(sql);
            gridUser.DataSource = tb;

            int n = 1;
            while (n < gridUser.Columns.Count)
            {
                gridUser.Columns[n].ReadOnly = true;
                n++;
            }
        }

        public void preencheDataGrid(string permissao)
        {
            this.Cursor = Cursors.WaitCursor;
            gridUser.DataSource = null;
            string sql;
            ModificaUser modificaUser = new ModificaUser();
            
            gridUser.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            if (permissao == "Comum")
            {
                sql = "SELECT id as ID, nome as NOME, email as 'E-MAIL', permissao as PERMISSAO FROM Crud_User WHERE email = " + "'" + emailLogin + "'";
                sqlPreencheDataGrid(sql);
                this.gridUser.Columns["ID"].Visible = false;
                this.gridUser.Columns["PERMISSAO"].Visible = false;
                this.gridUser.Columns["NOME"].Width = 138;
                this.gridUser.Columns["E-MAIL"].Width = 138;
                gridUser.Width = 320;
                gridUser.Height = 60;

                
            }
            if (permissao == "Funcionario")
            {
                sql = "SELECT id as ID, nome as NOME, email as 'E-MAIL', permissao as PERMISSAO FROM Crud_User WHERE PERMISSAO = 'Funcionario' OR PERMISSAO = 'Comum'";
                sqlPreencheDataGrid(sql);
                this.gridUser.Columns["ID"].Visible = false;
                this.gridUser.Columns["NOME"].Width = 130;
                this.gridUser.Columns["E-MAIL"].Width = 130;
                this.gridUser.Columns["PERMISSAO"].Width = 130;
                gridUser.Width = 434;
            }
            if (permissao == "Administrador")
            {
                sql = "SELECT id as ID, nome as NOME, email as 'E-MAIL', permissao as PERMISSAO FROM Crud_User";
                sqlPreencheDataGrid(sql);
                this.gridUser.Columns["ID"].Visible = false;
                this.gridUser.Columns["NOME"].Width = 130;
                this.gridUser.Columns["E-MAIL"].Width = 130;
                this.gridUser.Columns["PERMISSAO"].Width = 130;
                gridUser.Width = 434;
            }

            this.Cursor = Cursors.Default;
        }

        public void verificaPermissaoUser(string email, string senha)
        {
            ConexaoDb conexao = new ConexaoDb();
            emailLogin = email;
            try
            {
                string sql = "SELECT PERMISSAO FROM Crud_User WHERE EMAIL = " + "'" + email + "'" + " AND SENHA = " + "'" + senha + "'";
                switch (conexao.verificaPermissao(sql))
                {
                    case "Comum":
                        btnDeletar.Enabled = false;
                        cbPermissao.Enabled = false;
                        permissao = "Comum";
                        preencheDataGrid("Comum");
                        //Datagrid só pode aparecer o seu perfil
                        break;
                    case "Funcionario":
                        cbPermissao.Items.Remove("Administrador");
                        permissao = "Funcionario";
                        preencheDataGrid("Funcionario");
                        //Só pode ver funcionarios
                        break;
                    case "Administrador":
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        private void gridUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idAtual = Convert.ToInt32(gridUser.Rows[e.RowIndex].Cells["ID"].Value.ToString());
            txtNome_User.Text = gridUser.Rows[e.RowIndex].Cells["NOME"].Value.ToString();
            txtEmail_User.Text = gridUser.Rows[e.RowIndex].Cells["E-MAIL"].Value.ToString();
            cbPermissao.SelectedItem = gridUser.Rows[e.RowIndex].Cells["PERMISSAO"].Value.ToString();
            verificaDoubleClick = true;
            if (permissao == "Funcionario" || permissao == "Administrador" && verificaDoubleClick)
            {
                btnDeletar.Enabled = true;
                btnSalvar.Enabled = true;
            }
            else
            {
                btnDeletar.Enabled = false;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrEmpty(txtNome_User.Text) || String.IsNullOrEmpty(txtEmail_User.Text))
                {
                    MessageBox.Show("Email ou Nome estão vazios e por isso não será possivel excluir!!!");
                    return;
                }
                else
                {
                    ConexaoDb conexao = new ConexaoDb();
                    string sql;
                    sql = "DELETE FROM Crud_User WHERE ID =" + "'" + idAtual + "'"
                        + "AND NOME = " + "'" + txtNome_User.Text + "'"
                        + "AND E-MAIL = " + "'" + txtEmail_User.Text + "'";
                    conexao.ExecutaQuery(sql);
                    preencheDataGrid(permissao);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                LimparDados();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoDb conexao = new ConexaoDb();
                string sql;
                if (String.IsNullOrEmpty(txtNome_User.Text) || String.IsNullOrEmpty(txtEmail_User.Text))  
                {
                    MessageBox.Show("Email ou Nome estão vazios e por isso não será possivel salvar!!!");
                    return;
                }
                else if(permissao == "Funcionario" || permissao == "Administrador")
                {
                    sql = "UPDATE Crud_User SET NOME = " + "'" + txtNome_User.Text + "'"
                    + ", EMAIL = " + "'" + txtEmail_User.Text + "'"
                    + ", PERMISSAO = " + "'" + cbPermissao.SelectedItem + "'"
                    + " WHERE ID = " + "'" + idAtual + "'";
                    conexao.ExecutaQuery(sql);
                    preencheDataGrid(permissao);                        
                }
                else
                {
                    sql = "UPDATE Crud_User SET NOME = " + "'" + txtNome_User.Text + "'"
                           + ", EMAIL = " + "'" + txtEmail_User.Text + "'"
                           + " WHERE ID = " + "'" + idAtual + "'";
                    conexao.ExecutaQuery(sql);
                    preencheDataGrid(permissao);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar");
            }
            finally
            {
                LimparDados();
            }
        }
    }
}
