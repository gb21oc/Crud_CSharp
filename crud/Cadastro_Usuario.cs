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
using System.Text.RegularExpressions;

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
            txtEmail.Text       = "";
            txtName.Text        = "";
            txtSenha.Text       = "";
            txtSalario.Text     = "";
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
            HashPwd hashPwd = new HashPwd();
            Util util = new Util();
            string verificaNumero = "^[0-9]";
            try
            {
                string sql = "";
                string recebeSalario = txtSalario.Text;
                recebeSalario = recebeSalario.Replace(",", ".");
                char charac = recebeSalario.ToCharArray()[0];
                int verificaSequencia = charac * 11;
                if (verificaSequencia.ToString() == txtSalario.Text)
                {
                    MessageBox.Show("Essa sequencia do campo de salário não é permitida");
                }
                if (String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtName.Text) || String.IsNullOrEmpty(txtSenha.Text))
                {
                    MessageBox.Show("Algum campo ficou vazio, não sera possivel efetuar o cadastro!");
                    return;
                }
                if (!util.verificaEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email Inválido!");
                    return;
                }
                if (!Regex.IsMatch(txtSalario.Text, verificaNumero))
                {
                    MessageBox.Show("Só é permitido numeros no campo de salário");
                    return;
                }
                if (confereCaracteresPerigosos(txtEmail.Text))
                {
                    if (confereCaracteresPerigosos(txtName.Text))
                    {
                       string hashSenha = hashPwd.HashValue(txtSenha.Text);
                        sql = "INSERT INTO Crud_User(nome, email, senha, salario) VALUES ( " +
                            "'" + txtName.Text + "', " +
                            "'" + txtEmail.Text + "', " +
                            "'" + hashSenha + "', " +
                            "" + recebeSalario + "" +
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
                MessageBox.Show("Cadastro efetuado com sucesso!");
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

        private void lblLogar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true; //ler sobre
            }
        }
    }
}
