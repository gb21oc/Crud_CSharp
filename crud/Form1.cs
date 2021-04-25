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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if(input.Contains("select") || input.Contains("SELECT"))
            {
                MessageBox.Show("Esta sendo utilizado caracteres perigosos, seu ip foi salvo e irá para analise");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            ConexaoDb conexaoDb = new ConexaoDb();
            HashPwd hashPwd = new HashPwd();
            try
            {
                string sql = "";
                if (confereCaracteresPerigosos(txtLogin.Text))
                {
                    string hashSenha = hashPwd.HashValue(txtSenha.Text);
                    sql = "SELECT * FROM Crud_User WHERE " +
                        "email = '" + txtLogin.Text + "' and " +
                        "senha = '" + hashSenha + "'";
                    if (conexaoDb.verificaUsuario(sql))
                    {
                        MessageBox.Show("Login bem sucedido");
                    }
                    else
                    {
                        MessageBox.Show("Email ou senha errados");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conexaoDb.FecharConexao();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro_Usuario cadastro = new Cadastro_Usuario();
            cadastro.Show();
            Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
        }
    }
}
