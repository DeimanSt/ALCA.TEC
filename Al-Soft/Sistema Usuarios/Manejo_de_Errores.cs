using System.Security.Cryptography;
using System.Text;

namespace Al_Soft.Sistema_Usuarios
{
    class Manejo_de_Errores
    {

        public string ctrlRegistro(Auxiliares usuario)
        {
            Ingreso_de_Datos datosusuario = new Ingreso_de_Datos();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usu1) || string.IsNullOrEmpty(usuario.Contras1) || string.IsNullOrEmpty(usuario.ConfirmContras)
               || string.IsNullOrEmpty(usuario.TipoU) || string.IsNullOrEmpty(usuario.Tel))
            {
                respuesta = "Debe rellenar todos los campos!"; 
            }
            else
            {
                if (usuario.Contras1 == usuario.ConfirmContras)
                {
                    if (datosusuario.existeUsuario(usuario.Usu1)) 
                    {
                        respuesta = "El usuario ya existe."; 
                    }
                    else
                    {
                        usuario.Contras1 = cifradoSHA256(usuario.Contras1); 
                        datosusuario.Registro(usuario); 
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden.";
                }
            }
            return respuesta;       
        }

        public string cntrlLogin(string Usuario, string Contraseña)
        {
            Ingreso_de_Datos login = new Ingreso_de_Datos();
            string respuesta = "";
            Auxiliares infousuario = null;

            if (string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Contraseña))
            {
                respuesta = "Debe rellenar todos los campos!";
            }
            else
            {
                infousuario = login.VerificaXUsuario(Usuario);
                if (infousuario == null)
                {
                    respuesta = "El Usuario no existe.";
                }
                else
                {
                    if (infousuario.Contras1 != cifradoSHA256(Contraseña))
                    {
                        respuesta = "El Usuario y/o Contraseña no coinciden!";
                    }
                }
            }
            return respuesta;
        }

        #region Método de cifradoSHA256
        private string cifradoSHA256(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            result = sha256.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }
            return sb.ToString();
        }
        #endregion Método de cifradoSHA256
    }
}

