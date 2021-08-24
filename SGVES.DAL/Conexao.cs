

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SGVE.DAL
{
    public class Conexao
    {
        public static string _ConnectionString = ConfigurationManager.ConnectionStrings["ConnectSQLSERVER"].ConnectionString;        
        public static SqlConnection _sqlConnection = new SqlConnection(_ConnectionString);

        public static void Connect()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }

        }
        public static void Disconnect()
        {
            if (_sqlConnection.State == ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
        }
    }
}
