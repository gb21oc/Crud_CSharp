using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud.Properties
{
    public class ConexaoDb
    {
        public SqlConnection cn { get; set; }

        public ConexaoDb() //Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CrudCsharp;Data Source=*\\*
        {
            cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=WKT-0065D\\SQLEXPRESS");
            cn.Open();
        }

        public void FecharConexao()
        {
            cn.Close();
            cn.Dispose();
        }

        public DataTable DataTable_ConsultarDados(string sql)
        {
            cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=WKT-0065D\\SQLEXPRESS");
            cn.Open();
            DataTable td = new DataTable();
            //Executa a consulta no db
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql, cn);
                command.CommandTimeout = 50000;
                dataAdapter.SelectCommand = command;

                //preenche o dataTable
                dataAdapter.Fill(td);
            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Ocorreu um erro");
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
            return td;
        }

        public SqlDataReader Reader_ConsultarDados(string sql)
        {
                //Executa a query
                SqlCommand command = new SqlCommand(sql, cn);
                command.CommandTimeout = 50000;
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                return dataReader;
        }

        public void ExecutaQuery(string sql)
        {
            try
            {
                //cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CrudCsharp;Data Source=LAPTOP-BQIMSF2O\\SQLEXPRESS");
                //cn.Open();
                //Comando para a execução
                SqlCommand command = new SqlCommand(sql, cn);
                command.CommandTimeout = 50000;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                FecharConexao();
            }
        }

        public bool verificaUsuario(string sql)
        {
            try
            {
                //cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CrudCsharp;Data Source=LAPTOP-BQIMSF2O\\SQLEXPRESS");
                //cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandTimeout = 50000;
                return Convert.ToBoolean(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                FecharConexao();
            }
        }

        public string verificaPermissao(string sql)
        {
            string permissao;
            string result = "";
            try
            {
                SqlCommand command = new SqlCommand(sql, cn);
                command.CommandTimeout = 10000;
                permissao = Convert.ToString(command.ExecuteScalar());
                switch (permissao) { 
                    case "Comum":
                        result = "Comum";
                        break;
                    case "Funcionario":
                        result = "Funcionario";
                        break;
                    case "Administrador":
                        result = "Administrador";
                        break;
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()).ToString();
                result = ex.ToString();
                return result;
            }
            finally
            {
                FecharConexao();
            }
            return result;
        }

    }
}
