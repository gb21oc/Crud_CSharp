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

        public ConexaoDb()
        {
            cn = new SqlConnection(ConfigurationManager.ConnectionStrings[@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=master;Data Source=WKT-0065D\SQLEXPRESS"].ToString());
            cn.Open();
        }

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
                MessageBox.Show(ex.ToString());
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
            SqlTransaction sqlTransaction = cn.BeginTransaction();
            try
            {
                //Comando para a execução
                SqlCommand command = new SqlCommand();
                command.CommandTimeout = 50000;
                command.Transaction = sqlTransaction;
                command.ExecuteNonQuery();
                sqlTransaction.Commit();
            }
            catch (SqlException ex)
            {
                sqlTransaction.Rollback();
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
