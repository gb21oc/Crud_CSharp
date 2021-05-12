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
        public string idGastosMensais;
        string permissao;
        string emailLogin;
        public ModificaUser()
        {
            InitializeComponent();
            btnSalvar.Enabled = false;
            lblSalarioUpdate.Visible = false;
            txtSalarioUpdate.Visible = false;
        }

        public void preencheSalario(string emailLogin)
        {
            string sql;
            ConexaoDb conexao = new ConexaoDb();
            try 
            {
                sql = "SELECT SALARIO FROM Crud_User where email = " + "'"+ emailLogin  + "'";
                string result = conexao.resultLabel(sql);
                lblSalario.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro quando foi preencher o salario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void LimparDados()
        {
            txtNome_User.Text           = "";
            txtEmail_User.Text          = "";
            cbPermissao.SelectedItem    = null;
            btnDeletar.Enabled          = false;
            btnSalvar.Enabled           = false;
            lblSalarioUpdate.Visible    = false;
            txtSalarioUpdate.Visible    = false;
            btnCadastroDespesas.Enabled = false;
            btnAbrirChamado.Enabled     = false;
        }

        public void sqlPreencheDataGrid(string sql)
        {
            if (permissao == "Comum")
            {
                lblUser.Text = "Suas informações(de dois cliques para editar ou para cadastrar as despesas!)";
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
                sql = "SELECT id as ID, nome as NOME, email as 'E-MAIL', permissao as PERMISSAO, salario as SALARIO FROM Crud_User WHERE email = " + "'" + emailLogin + "'";
                preencheSalario(emailLogin);
                string sqlCombo = "SELECT id as ID, nome as NOME, email as 'E-MAIL' FROM Crud_User WHERE PERMISSAO = 'Funcionario'";
                cb.PreencherComboBox_KeyValue(cbFuncionario, sqlCombo);
                sqlPreencheDataGrid(sql);
                this.gridUser.Columns["ID"].Visible = false;
                this.gridUser.Columns["PERMISSAO"].Visible = false;
                this.gridUser.Columns["NOME"].Width = 138;
                this.gridUser.Columns["E-MAIL"].Width = 138;
                this.gridUser.Columns["SALARIO"].Visible = false;
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

        public void verificaPermissaoUser(string email, string senha, string id)
        {
            idGastosMensais = id;
            ConexaoDb conexao = new ConexaoDb();
            GastosMensais(id);
            emailLogin = email;
            try
            {
                string sql = "SELECT PERMISSAO FROM Crud_User WHERE EMAIL = " + "'" + email + "'" + " AND SENHA = " + "'" + senha + "'";
                switch (conexao.verificaPermissao(sql))
                {
                    case "Comum":
                        lblCliente.Visible          = false;
                        lblAdm.Visible              = false;
                        cbPermissao.Visible         = false;
                        lblPermissao.Visible        = false;
                        cbAdm.Visible               = false;
                        cbCliente.Visible           = false;
                        lblChamados.Visible         = false;
                        lblQtdChamados.Visible      = false;
                        btnDeletar.Enabled          = false;
                        cbPermissao.Enabled         = false;
                        cbAdm.Enabled               = false;
                        cbFuncionario.Enabled       = false;
                        cbCliente.Enabled           = false;
                        btnCadastroDespesas.Enabled = false;
                        btnAbrirChamado.Enabled     = false;
                        btnChamados.Enabled         = false;
                        btnChamados.Location        = new Point(709, 66);
                        permissao = "Comum";
                        preencheDataGrid("Comum");
                        break;
                    case "Funcionario":
                        cbPermissao.Items.Remove("Administrador");
                        permissao = "Funcionario";
                        btnCadastroDespesas.Visible     = false;
                        btnChamados.Visible             = true;
                        btnAbrirChamado.Visible         = false;
                        lblCadastrarDespesas.Visible    = false;
                        gbGastosMensais.Visible         = false;
                        lblSeuSalario.Visible           = false;
                        btnCadastroDespesas.Enabled     = false;
                        btnDeletar.Enabled              = false;

                        preencheDataGrid("Funcionario");
                        break;
                    case "Administrador":
                        lblCadastrarDespesas.Visible    = false;
                        btnAbrirChamado.Visible         = false;
                        btnCadastroDespesas.Visible     = false;
                        gbGastosMensais.Visible         = false;
                        lblSeuSalario.Visible           = false;
                        btnDeletar.Enabled              = false;
                        btnCadastroDespesas.Enabled     = false;
                        
                        preencheDataGrid("Administrador");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro na validação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                btnCadastroDespesas.Enabled = true;
                txtSalarioUpdate.Text = gridUser.Rows[e.RowIndex].Cells["SALARIO"].Value.ToString();
                txtSalarioUpdate.Visible = true;
                lblSalarioUpdate.Visible = true;
                btnDeletar.Enabled = false;
                btnSalvar.Enabled = true;
                btnAbrirChamado.Enabled = true;
                cbFuncionario.Enabled = true;
                btnChamados.Enabled = true;
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
                    MessageBox.Show(this, "Email ou Nome estão vazios e por isso não será possivel excluir!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show(this, "Ocorreu um erro na hora de deletar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show(this, "Email ou Nome estão vazios e por isso não será possivel salvar!!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!util.verificaEmail(txtEmail_User.Text)) {
                    MessageBox.Show("Email Inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (permissao == "Funcionario" || permissao == "Administrador")
                {
                    sql = "UPDATE Crud_User SET NOME = " + "'" + txtNome_User.Text + "'"
                    + ", EMAIL = " + "'" + txtEmail_User.Text + "'"
                    + ", PERMISSAO = " + "'" + cbPermissao.SelectedItem + "'"
                    + ", SALARIO = " + "'" + txtSalarioUpdate.Text + "'"
                    + " WHERE ID = " + "'" + idAtual + "'";
                    conexao.ExecutaQuery(sql);
                    preencheDataGrid(permissao);
                }
                else
                {
                    sql = "UPDATE Crud_User SET NOME = " + "'" + txtNome_User.Text + "'"
                           + ", SALARIO = " + "'" + txtSalarioUpdate.Text + "'"
                           + ", EMAIL = " + "'" + txtEmail_User.Text + "'"
                           + " WHERE ID = " + "'" + idAtual + "'";
                    conexao.ExecutaQuery(sql);
                    preencheDataGrid(permissao);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                LimparDados();
            }
        }

        private void btnCadastroDespesas_Click(object sender, EventArgs e)
        {
            //idUser = 
            Despesas despesas = new Despesas();
            despesas.idUser = idAtual;
            despesas.ShowDialog();
            GastosMensais(idGastosMensais);
        }

        private void btnChamados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Chat inativo no momento", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        public void GastosMensais(string id)
        {
            try
            {
                ConexaoDb conexao = new ConexaoDb();
                string sql;
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Janeiro' AND ID_USER = " + "'" + id + "'";
                lblValorJan.Text =  conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Fevereiro' AND ID_USER = " + "'" + id + "'";
                lblValorFev.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Março' AND ID_USER = " + "'" + id + "'";
                lblValorMarco.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Abril' AND ID_USER = " + "'" + id + "'";
                lblValorAbril.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Maio' AND ID_USER = " + "'" + id + "'";
                lblValorMaio.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Junho' AND ID_USER = " + "'" + id + "'";
                lblValorJunho.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Julho' AND ID_USER = " + "'" + id + "'";
                lblValorJulho.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Agosto' AND ID_USER = " + "'" + id + "'";
                lblValorAgosto.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Setembro' AND ID_USER = " + "'" + id + "'";
                lblValorSetembro.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Outubro' AND ID_USER = " + "'" + id + "'";
                lblValorOutubro.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Novembro' AND ID_USER = " + "'" + id + "'";
                lblValorNovembro.Text = conexao.resultLabel(sql);
                sql = "SELECT SUM(VALOR) FROM GASTOS WHERE MES = 'Dezembro' AND ID_USER = " + "'" + id + "'";
                lblValorDezembro.Text = conexao.resultLabel(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro no calculo de gastos mensais", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Deseja realmente sair?", "sair", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Closed += (s, args) => this.Close();
                form1.Show();
                Hide();
            }
            else
            {
                return;
            }
        }

        private void btnChamados_Click_1(object sender, EventArgs e)
        {
            VerificarChamados chamados = new VerificarChamados(emailLogin, permissao);
            chamados.ShowDialog();
        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbFuncionario.SelectedItem == null)
                {
                    MessageBox.Show(this, "Funcionario inexistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string funcionario = cbFuncionario.SelectedItem.ToString();
                int id = Convert.ToInt32(idGastosMensais);
                System.Console.WriteLine(funcionario);
                if (funcionario == null)
                {
                    MessageBox.Show(this, "Funcionario inexistente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (funcionario == "[, ]")
                {
                    MessageBox.Show(this, "Não é possivel abrir um chamado sem informar o nome do funcionario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                AbrirChamado abrirChamado = new AbrirChamado(txtNome_User.Text, txtEmail_User.Text, id, cbFuncionario.SelectedItem);
                abrirChamado.ShowDialog();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show(this, "Nomede funcionario não existe", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
