using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_BD_Multas;

namespace Persist
{
    public class PRepository
    {
        string strConn = @"Data Source=127.0.0.1; Initial Catalog=BDMultas; User Id=SA; Password=SqlServer2019!;TrustServerCertificate=True";
        SqlConnection conn;

        public PRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

    }
}
