using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta:Vehiculo
    {
        #region Constructores
        /// <summary>
        /// Constructor Camioneta
        /// </summary>
        public Camioneta()
        {
            this.anio = 2021;
        }
        /// <summary>
        /// Constructor parametrizado Camioneta
        /// </summary>
        /// <param name="marca">marca que se asignara en camioneta</param>
        /// <param name="anio">anio que se asignara en camioneta</param>
        /// <param name="patente">patente que se asignara en camioneta</param>
        /// <param name="modelo">modelo que se asignara en camioneta</param>
        public Camioneta(EMarca marca, int anio, string patente, string modelo) : base(marca, anio, patente, modelo, ETipoVehiculo.Camioneta)
        {
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Dos camionetas son iguales si comparten la misma patente
        /// </summary>
        /// <param name="camioneta">primer camioneta a evaluar</param>
        /// <param name="camionetaDos">segunda camioneta a evaluar</param>
        /// <returns></returns>
        public static bool operator ==(Camioneta camioneta, Camioneta camionetaDos)
        {
            bool retorno = false;
            if ((Vehiculo)camioneta == camionetaDos)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos camionetas son distintas si tienen distinta patente
        /// </summary>
        /// <param name="camioneta">primer camioneta a evaluar</param>
        /// <param name="camionetaDos">segunda camioneta a evaluar</param>
        /// <returns>retorna true si las camionetas son distintas, caso contrario false</returns>
        public static bool operator !=(Camioneta camioneta, Camioneta camionetaDos)
        {
            return !(camioneta == camionetaDos);
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Dos camionetas son iguales si comparten la misma patente
        /// </summary>
        /// <param name="obj">objeto que se comparara con la instancia Camioneta</param>
        /// <returns>retorna true si las camionetas son iguales, caso contrario false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Camioneta)
            {
                retorno = (Camioneta)obj == this;
            }
            return retorno;
        }
        /// <summary>
        /// Muestra todos los datos de la camioneta
        /// </summary>
        /// <returns>retorna string con todos los datos de la camioneta</returns>
        public override string ToString()
        {
            return string.Format($"Marca:{this.Marca}\n{base.ToString()}");
        }
        #endregion
    }
}
