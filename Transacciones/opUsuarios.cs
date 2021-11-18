using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Transacciones
{

    public class datosUsuarios
    {
        public int IdAlumno;
        public String Nombre;
        public String Edad;
        public String Usuario;
        public String Contrasena;
    }

    public class opUsuarios
    {
        public void RegistrarUsuario(datosUsuarios datosUsuarios)
        {
            //Insertar en tabla Alumno
            SqlConnection connection = new SqlConnection("Server=tcp:hpomen15.database.windows.net,1433;Initial Catalog=ElementaryLearning;Persist Security Info=False;User ID=nog;Password=Onepiece1099!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            String Query = "INSERT INTO Alumnos(Nombre, Edad)" +
                           "VALUES(@Nombre, @Edad)";
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, connection);
            sqlCommand.Parameters.AddWithValue("@Nombre", datosUsuarios.Nombre);
            sqlCommand.Parameters.AddWithValue("@Edad", datosUsuarios.Edad);
            sqlCommand.ExecuteNonQuery();

            String QueryLastID = "SELECT TOP 1 IdAlumno FROM Alumnos " +
                                 "ORDER BY IdAlumno DESC";
            SqlCommand sqlCommand1 = new SqlCommand(QueryLastID, connection);
            int lastIdUsuario = Convert.ToInt32(sqlCommand1.ExecuteScalar());

            //Insertar en la tabla Usuario
            String Query2 = "INSERT INTO Usuarios(Usuario, Contrasena, IdAlumno)" +
                            "VALUES(@Usuario, @Contrasena, @IdAlumno)";
            SqlCommand sqlCommand2 = new SqlCommand(Query2, connection);
            sqlCommand2.Parameters.AddWithValue("@Usuario", datosUsuarios.Usuario);
            sqlCommand2.Parameters.AddWithValue("@Contrasena", datosUsuarios.Contrasena);
            sqlCommand2.Parameters.AddWithValue("@IdAlumno", lastIdUsuario);
            sqlCommand2.ExecuteNonQuery();

        }
    }
}
