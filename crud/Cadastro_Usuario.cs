using crud.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Cadastro_Usuario : Form
    {
        public Cadastro_Usuario()
        {
            InitializeComponent();
        }

        public void LimparDados()
        {
            txtEmail.Text = "";
            txtName.Text = "";
            txtSenha.Text = "";
        }

        public bool confereCaracteresPerigosos(string input)
        {
            if (input.Contains("'"))
            {
                MessageBox.Show("Esta sendo utilizado caracteres perigosos, seu ip foi salvo e irá para analise");
                return false;
            }
            if (input.Contains("\""))
            {
                MessageBox.Show("Esta sendo utilizado caracteres perigosos, seu ip foi salvo e irá para analise");
                return false;
            }
            if (input.Contains("Shcema"))
            {
                MessageBox.Show("Esta sendo utilizado caracteres perigosos, seu ip foi salvo e irá para analise");
                return false;
            }
            if (input.Contains("'1 = 1"))
            {
                MessageBox.Show("Esta sendo utilizado caracteres perigosos, seu ip foi salvo e irá para analise");
                return false;
            }
            if (input.Contains("select") || input.Contains("SELECT"))
            {
                MessageBox.Show("Esta sendo utilizado caracteres perigosos, seu ip foi salvo e irá para analise");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparDados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ConexaoDb conexaodb = new ConexaoDb();
            try
            {
                string sql = "";
                if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Algum campo ficou vazio, não sera possivel efetuar o cadastro!");
                    return;
                }
                if (confereCaracteresPerigosos(txtEmail.Text))
                {
                    if (confereCaracteresPerigosos(txtName.Text))
                    {
                        sql = "INSERT INTO Crud_User(nome, email, senha) VALUES ( " +
                            "'" + txtName.Text + "', " +
                            "'" + txtEmail.Text + "', " +
                            "'" + txtSenha.Text + "'" +
                            ")";

                        conexaodb.ExecutaQuery(sql);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    return;
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
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }
    }
}
