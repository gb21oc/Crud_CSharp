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
            btnEnviarMsg.Enabled = false;
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
            if (permissao == "Comum")
            {
                lblUser.Text = "Suas informações(de dois cliques para editar ou para abrir um chamado)";
            }
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
                ConexaoDb cb = new ConexaoDb();
                sql = "SELECT id as ID, nome as NOME, email as 'E-MAIL', permissao as PERMISSAO FROM Crud_User WHERE email = " + "'" + emailLogin + "'";
                string sqlCombo = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Funcionario'";
                cb.PreencherComboBox_KeyValue(cbFuncionario, sqlCombo);
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
                ConexaoDb cb = new ConexaoDb();
                sql = "SELECT id as ID, nome as NOME, email as 'E-MAIL', permissao as PERMISSAO FROM Crud_User WHERE PERMISSAO = 'Funcionario' OR PERMISSAO = 'Comum'";
                string sqlComboAdm = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Administrador'";
                string sqlComboFunc = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Funcionario'";
                string sqlComboComum = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Comum'";
                cb.PreencherComboBox_KeyValue(cbAdm, sqlComboAdm);
                cb.PreencherComboBox_KeyValue(cbFuncionario, sqlComboFunc);
                cb.PreencherComboBox_KeyValue(cbCliente, sqlComboComum);
                sqlPreencheDataGrid(sql);
                this.gridUser.Columns["ID"].Visible = false;
                this.gridUser.Columns["NOME"].Width = 130;
                this.gridUser.Columns["E-MAIL"].Width = 130;
                this.gridUser.Columns["PERMISSAO"].Width = 130;
                gridUser.Width = 434;
            }
            if (permissao == "Administrador")
            {
                ConexaoDb cb = new ConexaoDb();
                sql = "SELECT id as ID, nome as NOME, email as 'E-MAIL', permissao as PERMISSAO FROM Crud_User";
                string sqlComboAdm = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Administrador'";
                string sqlComboFunc = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Funcionario'";
                string sqlComboComum = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Comum'";
                cb.PreencherComboBox_KeyValue(cbAdm, sqlComboAdm);
                cb.PreencherComboBox_KeyValue(cbFuncionario, sqlComboFunc);
                cb.PreencherComboBox_KeyValue(cbCliente, sqlComboComum);
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
                        cbAdm.Enabled = false;
                        cbCliente.Enabled = false;
                        btnCadastroDespesas.Enabled = true;
                        permissao = "Comum";
                        preencheDataGrid("Comum");
                        break;
                    case "Funcionario":
                        cbPermissao.Items.Remove("Administrador");
                        permissao = "Funcionario";
                        btnCadastroDespesas.Visible = false;
                        btnCadastroDespesas.Enabled = false;
                        preencheDataGrid("Funcionario");
                        break;
                    case "Administrador":
                        btnCadastroDespesas.Visible = false;
                        btnCadastroDespesas.Enabled = false;
                        preencheDataGrid("Administrador");
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
                btnEnviarMsg.Enabled = true;
            }
            else
            {
                btnDeletar.Enabled = false;
                btnEnviarMsg.Enabled = true;
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
                Util util = new Util();
                string sql;
                if (String.IsNullOrEmpty(txtNome_User.Text) || String.IsNullOrEmpty(txtEmail_User.Text))  
                {
                    MessageBox.Show("Email ou Nome estão vazios e por isso não será possivel salvar!!!");
                    return;
                }
                if (!util.verificaEmail(txtEmail_User.Text)) {
                    MessageBox.Show("Email Inválido!");
                    return;
                }
                else if (permissao == "Funcionario" || permissao == "Administrador")
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

        private void btnEnviarMsg_Click(object sender, EventArgs e)
        {
            string nameFuncionario;
            nameFuncionario = cbFuncionario.SelectedItem.ToString().Replace("[", "").Replace("]", "").Replace(",", "");
            string[] nameFuncionarioSplit = nameFuncionario.Split(' ');
            System.Console.WriteLine(nameFuncionarioSplit[1]);
            System.Console.WriteLine(nameFuncionario[1]);
            try
            {
                ConexaoDb conexao = new ConexaoDb();
                Util util = new Util();
                string sql;
                if (String.IsNullOrEmpty(txtNome_User.Text) || String.IsNullOrEmpty(txtEmail_User.Text))
                {
                    MessageBox.Show("Email ou Nome estão vazios e por isso não será possivel salvar!!!");
                    return;
                }
                if (!util.verificaEmail(txtEmail_User.Text))
                {
                    MessageBox.Show("Email Inválido!");
                    return;
                }
                if (nameFuncionarioSplit[1] == " ")
                {
                    MessageBox.Show("Por favor selecione o funcionario!");
                    return;
                }
                if (String.IsNullOrEmpty(txtNameMsg.Text) || String.IsNullOrEmpty(txtMsgSuporte.Text))
                {
                    MessageBox.Show("Titulo da mensagem ou o corpo não pode ficar vazio");
                    return;
                }
                else
                {
                    sql = "INSERT INTO MensagemSuporte(id, email_user, nome_user, cargo_recebe_msg, nome_recebe_msg, titulo_msg, mensagem) VALUES(" +
                    "'" + idAtual + "', " +
                    "'" + txtEmail_User.Text + "', " +
                    "'" + txtNome_User.Text + "', " +
                    "'Funcionario', " +
                    "'" + nameFuncionarioSplit[1] + "', " +
                    "'" + txtNameMsg .Text + "', " +
                    "'" + txtMsgSuporte.Text + "'" + ")";
                    conexao.ExecutaQuery(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            MessageBox.Show($"Mensagem enviada com sucesso para: {nameFuncionarioSplit[1]}");
        }
    }
}
