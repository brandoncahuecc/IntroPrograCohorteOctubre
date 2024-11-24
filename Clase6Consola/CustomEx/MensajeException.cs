using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6Consola.CustomEx
{
    public class MensajeException : Exception
    {
        public int CodigoError { get; set; }
        public string MensajeUsuario { get; set; }

        public MensajeException(int codigoError, string mensajeUsuario) : base()
        {
            MensajeUsuario = mensajeUsuario;
            CodigoError = codigoError;
        }

        public MensajeException(int codigoError, string mensajeUsuario, string mensaje) : base(mensaje)
        {
            MensajeUsuario = mensajeUsuario;
            CodigoError = codigoError;
        }

        public MensajeException(int codigoError, string mensajeUsuario, string mensaje, Exception ex) : base(mensaje, ex)
        {
            MensajeUsuario = mensajeUsuario;
            CodigoError = codigoError;
        }
    }
}
