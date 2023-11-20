using MySql.Data.MySqlClient;

namespace Al_Soft.Sistema_Usuarios
{
    class Ingreso_de_Datos
    {
        public int Registro(Auxiliares usuario)
        {
            MySqlConnection conex = Conexión.GetConnection(); 
            conex.Open();  
            string ingresodatos = "INSERT INTO Usuarios(Usuario,Contraseña,Tipo_Usuario,Teléfono)" +
              "VALUES(@Usu, @Contras, @TipoUsu, @Tel)"; 
            MySqlCommand codigo = new MySqlCommand(ingresodatos, conex);
            codigo.Parameters.AddWithValue("@Usu", usuario.Usu1);
            codigo.Parameters.AddWithValue("@Contras", usuario.Contras1);
            codigo.Parameters.AddWithValue("@TipoUsu", usuario.TipoU);
            codigo.Parameters.AddWithValue("@Tel", usuario.Tel);

            int resultado = codigo.ExecuteNonQuery();
            return resultado;
        }

        #region comprobar existencia de Usuario
        public bool existeUsuario(string NomUsuario)
        {
            MySqlDataReader lectura; //comando para traer la lectura de la consulta.
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            //creamos una variable de tipo string para realizar el ingreso de datos a mysql:
            string ingresodatos = "SELECT IDUsuario FROM Usuarios WHERE Usuario LIKE @Usu"; // ingresamos la consulta q queremos hacer.
            MySqlCommand codigo = new MySqlCommand(ingresodatos, conex); //mandamos la conexion.
            codigo.Parameters.AddWithValue("@Usu", NomUsuario);

            lectura = codigo.ExecuteReader();  // se realiza lectura de la consulta.
            if (lectura.HasRows) // se verifica si la consulta tiene filas, es decir si el usuario ya existe en el registro.
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion 

        #region comprobar validación x cada Usuario
        public Auxiliares VerificaXUsuario(string NomUsuario)
        {
            MySqlDataReader lectura; //comando para traer la lectura de la consulta.
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            //creamos una variable de tipo string para realizar el ingreso de datos a mysql:
            string ingresodatos = "SELECT IDUsuario, Contraseña, Tipo_Usuario,Teléfono FROM Usuarios WHERE Usuario LIKE @Usu"; // ingresamos la consulta q queremos hacer.
            MySqlCommand codigo = new MySqlCommand(ingresodatos, conex); //mandamos la conexion.
            codigo.Parameters.AddWithValue("@Usu", NomUsuario);
            lectura = codigo.ExecuteReader();  // se realiza lectura de la consulta.

            Auxiliares usr = null;  // Creamos una variable usr nulo dentro de la clase Auxiliares para q nos devuelva un dato.
            while (lectura.Read()) //Se Recorre todos los campos para validar a cada usuario que inicia sesión.
            {
                usr = new Auxiliares();
                usr.IdU = int.Parse(lectura["IDUsuario"].ToString());
                usr.Contras1 = lectura["Contraseña"].ToString();
                usr.TipoU = lectura["Tipo_Usuario"].ToString();
                usr.Tel = lectura["Teléfono"].ToString();
            }
            return usr; // Devolvemos el resultado a la consulta.
        }
        #endregion 
    }
}
