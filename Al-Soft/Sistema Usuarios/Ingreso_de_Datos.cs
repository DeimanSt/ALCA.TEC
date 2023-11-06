using MySql.Data.MySqlClient;

namespace Al_Soft.Sistema_Usuarios
{
    class Ingreso_de_Datos
    {
        public int Registro(Auxiliares usuario)
        {
            MySqlConnection conex = Conexión.GetConnection(); //llamamos la clase conexión.
            conex.Open();  //abrimos la conexión con mysql.

            //creamos una variable de tipo string para realizar el ingreso de datos a mysql:
            string ingresodatos = "INSERT INTO Modista(Usuario,Contraseña, Teléfono, Tipo_usuario)" +
              "VALUES(@Usu, @Contras, @Tel, @TipoUsu)"; // le ingresamos alias para la consulta.
            MySqlCommand codigo = new MySqlCommand(ingresodatos, conex);
            codigo.Parameters.AddWithValue("@Usu", usuario.Usu1);
            codigo.Parameters.AddWithValue("@Contras", usuario.Contras1);
            codigo.Parameters.AddWithValue("@Tel", usuario.Tel);
            codigo.Parameters.AddWithValue("@TipoUsu", usuario.TipoU);

            // una vez hecha la consulta guardamos el resultado en una variable entera y retornamos el resultado de la misma:
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
            string ingresodatos = "SELECT IDUsuario FROM Modista WHERE Usuario LIKE @Usu"; // ingresamos la consulta q queremos hacer.
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
        #endregion comprobar existencia de Usuario

        #region comprobar validación x cada Usuario
        public Auxiliares VerificaXUsuario(string NomUsuario)
        {
            MySqlDataReader lectura; //comando para traer la lectura de la consulta.
            MySqlConnection conex = Conexión.GetConnection();
            conex.Open();

            //creamos una variable de tipo string para realizar el ingreso de datos a mysql:
            string ingresodatos = "SELECT IDUsuario, Contraseña, Teléfono, Tipo_usuario FROM Modista WHERE Usuario LIKE @Usu"; // ingresamos la consulta q queremos hacer.
            MySqlCommand codigo = new MySqlCommand(ingresodatos, conex); //mandamos la conexion.
            codigo.Parameters.AddWithValue("@Usu", NomUsuario);
            lectura = codigo.ExecuteReader();  // se realiza lectura de la consulta.

            Auxiliares usr = null;  // Creamos una variable usr nulo dentro de la clase Auxiliares para q nos devuelva un dato.
            while (lectura.Read()) //Se Recorre todos los campos para validar a cada usuario que inicia sesión.
            {
                usr = new Auxiliares();
                usr.IdU = int.Parse(lectura["IDUsuario"].ToString());
                usr.Contras1 = lectura["Contraseña"].ToString();
                usr.Tel = lectura["Teléfono"].ToString();
                usr.TipoU = lectura["Tipo_usuario"].ToString();
            }
            return usr; // Devolvemos el resultado a la consulta.
        }
        #endregion comprobar validación x cada Usuario
    }
}
