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
    public partial class ResponderChamado : Form
    {
        int id_chamado;
        int id_user;
        string email;
        string nome;
        string nomeRecebe;
        string permissao;
        public ResponderChamado(int _id_chamado, int _id_user, string _email, string _nome, string _nomeRecebe, string _titulo, string _permissao)
        {
            InitializeComponent();
            id_chamado = _id_chamado;
            id_user = _id_user;
            email = _email;
            nome = _nome;
            nomeRecebe = _nomeRecebe;
            txtNomeUser.Text = _nome;
            txtEmailUser.Text = _email;
            txtTituloMsg.Text = _titulo;
            permissao = _permissao;
        }

        public void LimparDados()
        {
            txtNomeUser.Text = "";
            txtEmailUser.Text = "";
            txtTituloMsg.Text = "";
            txtCorpoMensagem.Text = "";
        }

        private void btnResponderChamado_Click(object sender, EventArgs e)
        {
            bool chamadoIsTrue = false;
            try
            {
                ConexaoDb conexaoDb = new ConexaoDb();
                string sql;
                if (String.IsNullOrEmpty(txtTituloMsg.Text))
                {
                    MessageBox.Show("Não é possivel abrir um chamado com o Titulo vazio");
                    return;
                }
                if (String.IsNullOrEmpty(txtCorpoMensagem.Text))
                {
                    MessageBox.Show("Não é possivel abrir um chamado com a mensagem vazia");
                    return;
                }
                if (permissao == "Funcionario")
                {
                    sql = "INSERT INTO MensagemSuporte(id_chamado, id_user, email_user, nome_user, " +
                    "cargo_recebe_msg, nome_recebe_msg, titulo_msg, mensagem, respondida) VALUES(" +
                    "'" + id_chamado + "', " +
                    "'" + id_user + "', " +
                    "'" + email + "', " +
                    "'" + nome + "', " +
                    "'Comum', " +
                    "'" + nomeRecebe + "', " +
                    "'" + txtTituloMsg.Text + "', " +
                    "'" + txtCorpoMensagem.Text + "', " +
                    "'1'" + ")";
                    conexaoDb.ExecutaQuery(sql);
                    chamadoIsTrue = true;
                }
                else if (permissao == "Comum")
                {
                    sql = "INSERT INTO MensagemSuporte(id_chamado, id_user, email_user, nome_user, " +
                    "cargo_recebe_msg, nome_recebe_msg, titulo_msg, mensagem, respondida) VALUES(" +
                    "'" + id_chamado + "', " +
                    "'" + id_user + "', " +
                    "'" + email + "', " +
                    "'" + nome + "', " +
                    "'Funcionario', " +
                    "'" + nomeRecebe + "', " +
                    "'" + txtTituloMsg.Text + "', " +
                    "'" + txtCorpoMensagem.Text + "', " +
                    "'0'" + ")";
                    conexaoDb.ExecutaQuery(sql);
                    chamadoIsTrue = true;
                }
                
            }
            catch (Exception ex)
            {
                chamadoIsTrue = false;
                MessageBox.Show("Ocorreu um erro");
                return;
            }
            finally
            {
                LimparDados();
            }
            if (chamadoIsTrue)
            {
                MessageBox.Show("Chamado respondido com sucesso");
            }
        }
    }
}
