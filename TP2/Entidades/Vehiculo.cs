using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        /// <summary>
        /// Constructor publico que inicializara los atributos chasis,marca,color del vehiculo.
        /// </summary>
        /// <param name="chasis">chasis que se asignara en el vehiculo</param>
        /// <param name="marca">marca que se asignara en el vehiculo</param>
        /// <param name="color">color que se asignara en el vehiculo</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.marca = marca;
            this.chasis = chasis;
            this.color = color;
        }
        /// <summary>
        /// Enumerado de marcas de vehiculos
        /// </summary>
        public enum EMarca
        {
            Chevrolet, Ford, Renault, Toyota, BMW, Honda, HarleyDavidson
        }
        /// <summary>
        /// Enumerado de tamaños de vehiculo.
        /// </summary>
        public enum ETamanio
        {
            Chico, Mediano, Grande
        }

        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio{ get;}

        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>devuelve string con los datos del vehiculo</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// muestra informacion de vehiculo
        /// </summary>
        /// <param name="p">retorna string con la información del vehiculo</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"CHASIS: {p.chasis}\r\n");
            sb.Append($"MARCA : {p.marca}\r\n");
            sb.Append($"COLOR : {p.color}\r\n");
            sb.AppendLine("---------------------\n");
            sb.Append($"TAMAÑO : {p.Tamanio}");
            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1">primer vehiculo a comprar</param>
        /// <param name="v2">segundo vehiculo a comprar</param>
        /// <returns>Retorna true si los chasis de los vehiculos son iguales </returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            return (v1.chasis == v2.chasis);
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">primer vehiculo a compra</param>
        /// <param name="v2">segundo vehiculo a comprar</param>
        /// <returns>retorna true si los vehiculos tienen distinto chasis</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
