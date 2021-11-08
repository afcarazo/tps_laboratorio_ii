using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivosException : Exception
    {
        #region Excepciones
        /// <summary>
        /// Crea una excepcion con un mensaje especifico de error.
        /// </summary>
        /// <param name="message">mensaje de error</param>
        public ArchivosException(string message):base(message,null)
        { 
        }
        /// <summary>
        /// Recibe la excepcion interna y llama al constructor que recibe el mensaje de error
        /// </summary>
        /// <param name="innerException">excepcion interna</param>
        public ArchivosException(Exception innerException)
            :this("Ocurrio un error en la escritura/lectura del archivo: " + innerException.Message)
        { 
        }
        #endregion
    }
}
