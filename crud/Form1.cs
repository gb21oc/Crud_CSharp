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
            try
            {
                string sql;
                string login = txtLogin.Text;
                string senha = txtSenha.Text;
                if (confereCaracteresPerigosos(login))
                {
                    sql = "INSERT INTO Crud_User VALUES (" +
                        "'" + login + "', " +
                        "'" + senha + "', " +
                        ")";
                    conexaoDb.ExecutaQuery(sql);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexaoDb.FecharConexao();
            }
        }
    }
}
