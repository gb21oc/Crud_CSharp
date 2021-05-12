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
    public partial class VerificarChamados : Form
    {
        public int idChamado;
        public int idUser;
        string emailFunc;
        string permissao;
        public VerificarChamados(string emailFuncionario, string _permisssao)
        {
            InitializeComponent();
            permissao = _permisssao;            
            btnResponderChamado.Enabled = true;
            emailFunc = emailFuncionario;
            InitializeGridChamados();
        }

        public void InitializeGridChamados()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ID_CHAMADO", typeof(int)));
            dt.Columns.Add(new DataColumn("ID_USER", typeof(int)));
            dt.Columns.Add(new DataColumn("EMAIL_USER", typeof(string)));
            dt.Columns.Add(new DataColumn("NOME_USER", typeof(string)));
            dt.Columns.Add(new DataColumn("CARGO_RECEBE_USER", typeof(string)));
            dt.Columns.Add(new DataColumn("NOME_RECEBE_MSG", typeof(string)));
            dt.Columns.Add(new DataColumn("TITULO_MSG", typeof(string)));
            dt.Columns.Add(new DataColumn("MENSAGEM", typeof(string)));
            dt.Columns.Add(new DataColumn("RESPONDIDA", typeof(string)));
            PreencherDataGrid(dt);
        }

        public void sqlPreencheDataGrid(string sql)
        {
            ConexaoDb conexao = new ConexaoDb();
            DataTable tb = conexao.DataTable_ConsultarDados(sql);
            gridChamados.DataSource = tb;

            int n = 1;
            while (n < gridChamados.Columns.Count)
            {
                gridChamados.Columns[n].ReadOnly = true;
                n++;
            }
        }

        public  void PreencherDataGrid(DataTable dt)
        {
            this.Cursor = Cursors.WaitCursor;
            gridChamados.DataSource = null;
            string sql;
            try 
            {
                gridChamados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                if (permissao == "Funcionario")
                {
                    ConexaoDb cb = new ConexaoDb();
                    sql = "SELECT DISTINCT id_chamado as ID_CHAMADO, id_user AS ID_USER, email_user AS EMAIL_USER, " +
                        "nome_user AS NOME_USER, cargo_recebe_msg AS CARGO_RECEBE_MSG, titulo_msg AS TITULO_MSG, " +
                        "mensagem AS MENSAGEM, respondida AS RESPONDIDA FROM  MensagemSuporte";
                    sqlPreencheDataGrid(sql);
                    this.gridChamados.Columns["ID_CHAMADO"].Visible = false;
                    this.gridChamados.Columns["ID_USER"].Visible = false;
                    this.gridChamados.Columns["EMAIL_USER"].Width = 108;
                    this.gridChamados.Columns["NOME_USER"].Width = 108;
                    this.gridChamados.Columns["CARGO_RECEBE_MSG"].Width = 108;
                    this.gridChamados.Columns["TITULO_MSG"].Width = 108;
                    this.gridChamados.Columns["MENSAGEM"].Width = 250;
                    this.gridChamados.Columns["RESPONDIDA"].Visible = false;
                }
                else if (permissao == "Comum")
                {
                    ConexaoDb cb = new ConexaoDb();
                    sql = "SELECT DISTINCT id_chamado as ID_CHAMADO, id_user AS ID_USER, email_user AS EMAIL_USER, " +
                        "nome_user AS NOME_USER, cargo_recebe_msg AS CARGO_RECEBE_MSG, titulo_msg AS TITULO_MSG, " +
                        "mensagem AS MENSAGEM, respondida AS RESPONDIDA FROM  MensagemSuporte WHERE RESPONDIDA = '1'";
                    sqlPreencheDataGrid(sql);
                    this.gridChamados.Columns["ID_CHAMADO"].Visible = false;
                    this.gridChamados.Columns["ID_USER"].Visible = false;
                    this.gridChamados.Columns["EMAIL_USER"].Width = 108;
                    this.gridChamados.Columns["NOME_USER"].Width = 108;
                    this.gridChamados.Columns["CARGO_RECEBE_MSG"].Width = 108;
                    this.gridChamados.Columns["TITULO_MSG"].Width = 108;
                    this.gridChamados.Columns["MENSAGEM"].Width = 250;
                    this.gridChamados.Columns["RESPONDIDA"].Visible = false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Cursor = Cursors.Default;
        }

        private void gridChamados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idChamado = Convert.ToInt32(gridChamados.Rows[e.RowIndex].Cells["ID_CHAMADO"].Value.ToString());
            idUser = Convert.ToInt32(gridChamados.Rows[e.RowIndex].Cells["ID_USER"].Value.ToString());
            txtNome.Text = gridChamados.Rows[e.RowIndex].Cells["NOME_USER"].Value.ToString();
            txtEmail.Text = gridChamados.Rows[e.RowIndex].Cells["EMAIL_USER"].Value.ToString();
            txtTitulo.Text = gridChamados.Rows[e.RowIndex].Cells["TITULO_MSG"].Value.ToString();
            txtMensagem.Text = gridChamados.Rows[e.RowIndex].Cells["MENSAGEM"].Value.ToString();
            btnResponderChamado.Enabled = true;
        }

        private void btnResponderChamado_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                ConexaoDb conexaoDb = new ConexaoDb();
                conexaoDb.ConexaoDbOpen();
                string sql = "SELECT NOME FROM Crud_User WHERE EMAIL = " + "'" + emailFunc + "'";
                name = conexaoDb.resultLabel(sql);
                ResponderChamado responderChamado = new ResponderChamado(idChamado, idUser, emailFunc, name, txtNome.Text, txtTitulo.Text, permissao);
                responderChamado.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //MessageBox.Show(this, "Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        }
    }
}
