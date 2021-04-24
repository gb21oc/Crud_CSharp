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

        public void FecharConexao()
        {
            cn.Close();
            cn.Dispose();
        }

        public DataTable DataTable_ConsultarDados(string sql)
        {
            DataTable td = new DataTable();
            //Executa a consulta no db
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand();
                command.CommandTimeout = 50000;
                dataAdapter.SelectCommand = command;

                //preenche o dataTable
                dataAdapter.Fill(td);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro");
                //MessageBox.Show(ex.ToString());
            }
            return td;
        }

        public SqlDataReader Reader_ConsultarDados()
        {
                //Executa a query
                SqlCommand command = new SqlCommand();
                command.CommandTimeout = 50000;
                SqlDataReader dataReader;
                dataReader = command.ExecuteReader();
                return dataReader;
        }

        public void ExecutaQuery(string sql)
        {
            try
            {
                cn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=CrudCsharp;Data Source=LAPTOP-BQIMSF2O\\SQLEXPRESS");
                cn.Open();
                //Comando para a execução
                SqlCommand command = new SqlCommand(sql, cn);
                command.CommandTimeout = 50000;
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
