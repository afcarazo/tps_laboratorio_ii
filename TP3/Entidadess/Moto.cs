using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributos
        protected int cilindrada;
        protected EMarcaMoto marcaMoto;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor parametrizado de Moto
        /// </summary>
        /// <param name="marca">marca que se asignara en la moto</param>
        /// <param name="anio">año que se asignara en la moto</param>
        /// <param name="patente">patente que se asignara en la moto</param>
        /// <param name="cilindrada">cilindrada que se asignara en la moto</param>
        /// <param name="modelo">modelo que se asignara en la moto</param>
        public Moto(EMarcaMoto marca, int anio, string patente, int cilindrada, string modelo) : base(anio, patente, modelo, ETipoVehiculo.Moto)
        {
            this.cilindrada = cilindrada;
            this.MarcaMoto = marca;
        }
        /// <summary>
        /// Constructor de Moto que asigna año en 2021
        /// </summary>
        public Moto()
        {
            this.Anio = 2021;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Marca de Moto que asigna y retorna el atributo marca
        /// </summary>
        public EMarcaMoto MarcaMoto
        {
            get 
            {
                return this.marcaMoto;
            }
            set 
            {
                this.marcaMoto = value;
            }
        }
        /// <summary>
        /// Propiedad Cilindrada asigna y retorna el atributo cilindrada
        /// </summary>
        public int Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                if (value > 150 && value < 1000)
                {
                    this.cilindrada = value;
                }
            }
        }
        #endregion

        #region Métodos

        /// <summary>
        /// Muestra todos los datos de la moto
        /// </summary>
        /// <returns>retorna string con los datos de la moto</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.AppendLine($"Marca: {this.MarcaMoto}");
            sb.AppendLine($"Cilindrada: {this.Cilindrada}");
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Dos motos son iguales si comparten misma patente y cilindrada
        /// </summary>
        /// <param name="moto">primer moto a comparar</param>
        /// <param name="motoDos">segunda moto a comparar</param>
        /// <returns>retorna true si las motos son iguales, caso contrario false</returns>
        public static bool operator ==(Moto moto, Moto motoDos)
        {
            bool retorno = false;
            if ((Vehiculo)moto == motoDos && moto.Cilindrada == motoDos.Cilindrada)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos motos son disntintas si poseen distinta patente y cilindrada
        /// </summary>
        /// <param name="moto">primer moto a comparar</param>
        /// <param name="motoDos">segunda moto a comparar</param>
        /// <returns>retorna false si las motos son iguales, caso contrario true</returns>
        public static bool operator !=(Moto moto, Moto motoDos)
        {
            return !(moto == motoDos);
        }
        /// <summary>
        /// Dos motos son iguales si comparten misma patente y cilindrada
        /// </summary>
        /// <param name="obj">objeto que se comparara con la instancia moto</param>
        /// <returns>retorna true si las motos son iguales, caso contrario retorna false</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Moto)
            {
                retorno = (Moto)obj == this;
            }
            return retorno;
        }
        #endregion
    }
}