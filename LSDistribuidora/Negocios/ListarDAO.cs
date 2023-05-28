using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSDistribuidora.Negocios
{
    public class EstadosDAO
    {
        string textoConexao = "Server=(local)\\SQLEXPRESS;Database=LS;Trusted_Connection=True;";

        // Função para Listar todos os produtos
        public DataTable Listar()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(textoConexao))
            {
                string sql = "SELECT * FROM Produtos order by Nome";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
