using MySql.Data.MySqlClient;

namespace Al_Soft.Sistema_Usuarios
{
    class Conexión
    {
        public static MySqlConnection GetConnection()
        {
            string servidor = "localhost";
            string puerto = "3306";
            string usuario = "root";
            string BDD = "Modista";

            string cadenaconex = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; database=" + BDD;

            MySqlConnection conexion = new MySqlConnection(cadenaconex);
            return conexion;
        }
    }

    class Auxiliares
    {
        int idU;
        string Usu, Contras, confirmContras, tel, tipoU;

        public string Usu1 { get => Usu; set => Usu = value; }
        public string Contras1 { get => Contras; set => Contras = value; }
        public string ConfirmContras { get => confirmContras; set => confirmContras = value; }
        public string Tel { get => tel; set => tel = value; }
        public string TipoU { get => tipoU; set => tipoU = value; }
        public int IdU { get => idU; set => idU = value; }
    }
}
