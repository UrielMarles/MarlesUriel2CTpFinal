using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BACK
{
    public class ExcepcionConstruyendoEntidad: Exception
    {
        public ExcepcionConstruyendoEntidad():this("No se pudo construir la entidad") { }
        public ExcepcionConstruyendoEntidad(string message) : base(message) { }
        public ExcepcionConstruyendoEntidad(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ExcepcionFilaNoEncontrada : Exception
    {
        public ExcepcionFilaNoEncontrada():this("No se encontro la columna especificada") { }
        public ExcepcionFilaNoEncontrada(string message) : base(message) { }
        public ExcepcionFilaNoEncontrada(string message, Exception innerException) : base(message, innerException) { }
    }
    public class ExcepcionQueryFallida : Exception
    {
        public ExcepcionQueryFallida() : this("No se pudo realizar la query") { }
        public ExcepcionQueryFallida(string message) : base(message) { }
        public ExcepcionQueryFallida(string message ,Exception innerException) : base(message, innerException) { }
    }

    public class ExcecpcionEjecutandoComandoSql : Exception
    {
        public ExcecpcionEjecutandoComandoSql():this("no se pudo ejecutar el comando sql"){ }
        public ExcecpcionEjecutandoComandoSql(string message) : base(message) { }
        public ExcecpcionEjecutandoComandoSql(string message,Exception innerException) : base(message, innerException) { }
    }

    public class ErrorAccediendoUsuario : Exception
    {
        public ErrorAccediendoUsuario() : this("Nombre de usuario incorrecto") { }
        public ErrorAccediendoUsuario(string message) : base(message) { }
        public ErrorAccediendoUsuario(string message, Exception innerException) : base(message, innerException) { }
    }

    public class ExcepcionNoManejada: Exception
    {
        public ExcepcionNoManejada() : base("Error forzado", new Exception("error forzado hijo")) { }
    }
}
