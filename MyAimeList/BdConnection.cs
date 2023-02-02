using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAnimeList
{
    public class BdConnection
    {
        public IDbConnection AbrirConexao()
        {
            var connection = new SqlConnection($@"Data Source=DESKTOP-JSGVMU8;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            return connection;
        }
    }
}
