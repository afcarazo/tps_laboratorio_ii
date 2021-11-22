using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto: Vehiculo
    {
        
        #region Constructores
        /// <summary>
        /// Constructor Auto
        /// </summary>
        public Auto()
        {
            this.anio = 2021;
        }
        /// <summary>
        /// Constructor parametrizado Auto
        /// </summary>
        /// <param name="marca">marca que se asignara en auto</param>
        /// <param name="anio">año que se asignara en auto</param>
        /// <param name="patente">patente que se asignara en auto</param>
        /// <param name="modelo">modelo que se asignara en auto</param>
        public Auto(EMarca marca, int anio, string patente,string modelo) : base(marca, anio, patente,modelo,ETipoVehiculo.Auto)
        {
        }

        /// <summary>
        /// Contructor parametrizado Auto
        /// </summary>
        /// <param name="marca">marca que se asignara en auto</param>
        /// <param name="anio">anio que se asignara en auto</param>
        /// <param name="modelo">modelo que se asignara en auto</param>
        public Auto(EMarca marca, int anio, string modelo) : this(marca,anio,"", modelo)
        {
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Dos autos son iguales si comparten misma patente
        /// </summary>
        /// <param name="auto">primer auto a comparar</param>
        /// <param name="autoDos">segundon auto a comprar</param>
        /// <returns>retorna true si los autos son iguales, caso contrario false</returns>
        public static bool operator ==(Auto auto, Auto autoDos)
        {
            bool retorno = false;
            if ((Vehiculo)auto == autoDos)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos autos son distintos si poseen distinta patente
        /// </summary>
        /// <param name="auto">primer auto a comparar</param>
        /// <param name="autoDos">segundo auto a comparar</param>
        /// <returns>retorna true si dos autos son distintos, caso contrario false</returns>
        public static bool operator !=(Auto auto, Auto autoDos)
        {
            return !(auto == autoDos);
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra todos los datos del auto
        /// </summary>
        /// <returns>retorna string con los datos del auto</returns>
        public override string ToString()
        {
            return string.Format($"Marca:{this.Marca}\n{base.ToString()}");
        }
   

        /// <summary>
        /// Dos autos son iguales si comparten la misma patente
        /// </summary>
        /// <param name="obj">objeto que se comparara con la instancia auto</param>
        /// <returns>retorna true si los autos son iguales, caso contrario false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Auto)
            {
                retorno = (Auto)obj == this;
            }
            return retorno;
        }
        #endregion
    }

}
