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

            // Usando IsNullOrEmpty Validamos si hay campos vacios de ésta manera:
            if (string.IsNullOrEmpty(usuario.Usu1) || string.IsNullOrEmpty(usuario.Contras1) || string.IsNullOrEmpty(usuario.ConfirmContras)
               || string.IsNullOrEmpty(usuario.Tel) || string.IsNullOrEmpty(usuario.TipoU)) //el símbolo || significa: "ó".
            {
                respuesta = "Debe rellenar todos los campos!"; // en caso de encontrar campos vacios.
            }
            else
            {
                //en caso de estar todo bien, se procede a verificar si las contraseñas coinciden con usuarios existentes:
                if (usuario.Contras1 == usuario.ConfirmContras)
                {
                    if (datosusuario.existeUsuario(usuario.Usu1)) //verifica si el usuario ya existe.
                    {
                        respuesta = "El usuario ya existe."; //en caso de existir no va a dejar crearlo otra vez.
                    }
                    else
                    {
                        usuario.Contras1 = cifradoSHA256(usuario.Contras1); //realiza encriptado de la contraseña.
                        datosusuario.Registro(usuario); //se comparan las contraseñas encriptadas.
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden."; // mensaje en caso de no coincidir dichas contraseñas.
                }
            }
            return respuesta;// se vuelve a la parte de validación de los campos.       
        }

        public string cntrlLogin(string Usuario, string Contraseña)
        {
            Ingreso_de_Datos login = new Ingreso_de_Datos();
            string respuesta = "";
            Auxiliares infousuario = null;

            // Validación para q los campos de Inicio de Sesión no estén vacíos:
            if (string.IsNullOrEmpty(Usuario) || string.IsNullOrEmpty(Contraseña)) //si uno u otro estan vacíos.
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
        //CREAMOS UN MÉTODO PARA CIFRAR LAS CONTRASEÑAS.
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

