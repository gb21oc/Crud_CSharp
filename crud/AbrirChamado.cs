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
    public partial class AbrirChamado : Form
    {
        string NomeUser;
        string EmailUser;
        string[] NomeFuncionario;
        int id;
        public AbrirChamado(string nome, string email, int idUser, object funcionario)
        {
            InitializeComponent();
            NomeUser = nome;
            EmailUser = email;
            NomeFuncionario = funcionario.ToString().Replace("[", "").Replace("]", "").Split(',');
            id = idUser;
            txtNomeUser.Text = NomeUser;
            txtEmailUser.Text = EmailUser;
        }

        public void LimparDados()
        {
            txtTituloMsg.Text = "";
            txtCorpoMensagem.Text = "";
        }

        public void AbrirChamadoParam()
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
                sql = "INSERT INTO MensagemSuporte(id_chamado, id_user, email_user, nome_user, " +
                    "cargo_recebe_msg, nome_recebe_msg, titulo_msg, mensagem, respondida) VALUES(" +
                    "(SELECT ISNULL(MAX(ID_CHAMADO), 0) + 1 FROM MensagemSuporte), " +
                    "'" + id + "', " +
                    "'" + EmailUser + "', " +
                    "'" + NomeUser + "', " +
                    "'Funcionario', " +
                    "'" + NomeFuncionario[1] + "', " +
                    "'" + txtTituloMsg.Text + "', " +
                    "'" + txtCorpoMensagem.Text + "', " +
                    "'0'" + ")";
                conexaoDb.ExecutaQuery(sql);
                chamadoIsTrue = true;
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
                MessageBox.Show("Chamado criado com sucesso");
            }

        }

        private void btnAbrirChamado_Click(object sender, EventArgs e)
        {
            AbrirChamadoParam();
        }
    }
}
