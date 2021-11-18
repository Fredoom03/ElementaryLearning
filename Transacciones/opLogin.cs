using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Transacciones
{
    public class datosLogin
    {
        public String Usuario = "";
        public String Contrasema = "";
    }
    public class opLogin
    {
        private SqlConnection connection = new SqlConnection("Server=tcp:hpomen15.database.windows.net,1433;Initial Catalog=ElementaryLearning;Persist Security Info=False;User ID=nog;Password=Onepiece1099!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public int Login(string Usuario, String Contrasena)
        {
            try
            {
                connection.Open();

                SqlCommand sqlCommand = new SqlCommand("spLogin", connection);
                sqlCommand.CommandType = CommandType.StoredProcedure;

                sqlCommand.Parameters.AddWithValue("@Usuario", Usuario);
                sqlCommand.Parameters.AddWithValue("@Contrasena", Contrasena);

                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.Read())
                {
                    return sqlDataReader.GetInt32(0);
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }
    }
}
