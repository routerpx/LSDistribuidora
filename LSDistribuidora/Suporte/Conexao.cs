using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace LSDistribuidora.Suporte
{
    public class Conexao
    {
        public SqlConnection conexao = new SqlConnection();

        public Conexao()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["banco"].ConnectionString);
        }
    }
}
