using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerializarException:Exception
    {
        #region Atributos
        private string clase;
        private string metodo;
        #endregion

        #region Excepciones
        /// <summary>
        /// Excepcion de falla de serialización 
        /// </summary>
        /// <param name="message">string mesaje error</param>
        /// <param name="clase">string clase donde ocurrio el error</param>
        /// <param name="metodo">metodo en donde se ocasiono el error</param>
        public SerializarException(string message,string clase,string metodo):this(message,clase,metodo,null)
        { 
        }
        /// <summary>
        /// Excepcion de falla de serialización 
        /// </summary>
        /// <param name="message">string mesaje error</param>
        /// <param name="clase">string clase donde ocurrio el error</param>
        /// <param name="metodo">metodo en donde se ocasiono el error</param>
        /// <param name="innerException">excepcion interna</param>
        public SerializarException(string message,string clase,string metodo, Exception innerException):base(message,innerException)
        {
            this.clase = clase;
            this.metodo = metodo;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Clase asigna y retorna atributo clase
        /// </summary>
        public string Clase
        {
            get { return this.clase; }
        }
        /// <summary>
        /// Propiedad Metodo asigna y retorna atributo metodo
        /// </summary>
        public string Metodo
        {
            get { return this.metodo; }
        }
        #endregion

    }
}
