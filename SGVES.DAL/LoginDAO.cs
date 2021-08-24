using SGVS.Entities.Classes;


using System;
using System.Data.SqlClient;

namespace SGVE.DAL
{
    // D.A.O = Data Adm Owner
    public class LoginDAO
    {
        public TB001_LOGIN ObterUsuario(string userName, string password)
        {
            try
            {
                var command = new SqlCommand();
                command.Connection = Conexao._sqlConnection;          
                command.CommandText = "SELECT * FROM TB001_LOGIN " +
                                               "WHERE TB001_S_USUARIO = @USUARIO " +
                                               "AND TB001_S_PASSWORD = @SENHA";

                command.Parameters.AddWithValue("@USUARIO", userName);
                command.Parameters.AddWithValue("@SENHA", password);

                Conexao.Connect();
                var reader = command.ExecuteReader();

                TB001_LOGIN LOGIN = null;

                while (reader.Read())
                {
                    LOGIN = new TB001_LOGIN();
                    LOGIN.Codigo = Convert.ToInt32(reader["TB001_I_COD"]);
                    LOGIN.TB001_S_USUARIO = reader["TB001_S_USUARIO"].ToString();
                    LOGIN.TB001_S_PASSWORD = reader["TB001_S_PASSWORD"].ToString();
                    LOGIN.TB001_S_PROFILE = reader["TB001_S_PROFILE"].ToString();
                }
                return LOGIN;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Conexao.Disconnect();
            }
        }
    }
}
