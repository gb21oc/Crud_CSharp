using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace crud.Properties
{
    public class ConexaoDb
    {
        public SqlConnection cn { get; set; }

        public ConexaoDb()
        {
            cn = new SqlConnection();A
        }

    }
}
