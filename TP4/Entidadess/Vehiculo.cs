using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json.Serialization;

namespace Entidades

{

    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Camioneta))]
    [XmlInclude(typeof(Moto))]
    public class Vehiculo
    {
        #region Atributos
        protected EMarca marca;
        protected int anio;
        protected string patente;
        protected string modelo;
        protected ETipoVehiculo tipoVehiculo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor Vehiculo
        /// </summary>
        public Vehiculo()
        {
            this.Marca = EMarca.Chevrolet;
            this.Anio = 2002;
            this.TipoVehiculo = ETipoVehiculo.Auto;
        }

        /// <summary>
        /// Constructor Vehiculo parametrizado
        /// </summary>
        /// <param name="marca">marca que se asignara en el vehiculo</param>
        /// <param name="anio">año que se asignara en el vehiculo</param>
        /// <param name="patente">patente que se asignara en el vehiculo</param>
        /// <param name="modelo">modelo que se asignara en el vehiculo</param>
        /// <param name="tipo">tipo que se asignara en el vehiculo</param>
        public Vehiculo(EMarca marca, int anio, string patente, string modelo, ETipoVehiculo tipoVehiculo) : this(anio, patente, modelo, tipoVehiculo)
        {
            this.Marca = marca;
        }

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="anio">anio que se asignara en el vehiculo</param>
        /// <param name="patente">patente que se asignara en el vehiculo</param>
        /// <param name="modelo">modelo que se asignara en el vehiculo</param>
        /// <param name="tipo">tipo que se asignara en el vehiculo</param>
        public Vehiculo(int anio, string patente, string modelo, ETipoVehiculo tipoVehiculo)
        {
            this.Anio = anio;
            this.Modelo = modelo;
            this.TipoVehiculo = tipoVehiculo;
            this.Patente = patente;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Tipo Vehiculo asigna y retorna atributo tipo vehiculo
        /// </summary>
        public ETipoVehiculo TipoVehiculo
        {
            get 
            {
                return this.tipoVehiculo;
            }
            set 
            {
                this.tipoVehiculo = value;
            }
        }
        /// <summary>
        /// Propiedad Anio asigna y retorna atributo año
        /// </summary>
        public int Anio
        {
            get
            {
                return this.anio;
            }
            set
            {
                if (value > 1990 && value <= 2021)
                {
                    this.anio = value;
                }
            }
        }
        /// <summary>
        ///  Propiedad Patente asigna y retorna atributo patente
        /// </summary>
        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                value= value.Replace(" ", String.Empty);
                if (!string.IsNullOrWhiteSpace(value) && value.Length > 0 && value.Length < 7)
                {
                    this.patente = value;
                }
            }
        }
        /// <summary>
        /// Propiedad Marca asigna y retorna atributo marca
        /// </summary>
        public EMarca Marca
        {
            get
            {
                return this.marca;
            }
            set
            {
                this.marca = value;
            }
        }   
        /// <summary>
        /// Propiedad Modelo asigna y retorna atributo modelo
        /// </summary>
        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length<45)
                {
                    this.modelo = value;
                }
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        ///Muestra todos los datos del vehiculo 
        /// </summary>
        /// <returns>retorna string conlos datos del vehiculo</returns>
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo vehiculo: {this.TipoVehiculo}");
            sb.AppendLine($"Año: {this.Anio}");
            sb.AppendLine($"Patente {this.Patente}");
            sb.AppendLine($"Modelo {this.Modelo}");
            return sb.ToString();
        }
        /// <summary>
        /// Muestra todos los datos del vehiculo
        /// </summary>
        /// <returns>retorna string con todos los datos del vehiculo</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Sobrecarga de operadores
        /// <summary>
        /// Dos vehiculos son iguales si comparten misma patente
        /// </summary>
        /// <param name="vehiculo">primer vehiculo a evaluar</param>
        /// <param name="vehiculoDos">segundo vehiculo a evaluar</param>
        /// <returns>retorna true si los vehiculos son iguales, caso contrario false</returns>
        public static bool operator ==(Vehiculo vehiculo, Vehiculo vehiculoDos)
        {
            bool retorno = false;
            if (vehiculo is not null && vehiculoDos is not null && vehiculo.patente == vehiculoDos.patente)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        /// Dos vehiculos son distintos si poseen distintas patentes
        /// </summary>
        /// <param name="vehiculo">primer vehiculo a evaluar</param>
        /// <param name="vehiculoDos">segundo vehiculo a evaluar</param>
        /// <returns>retorna true si los vehiculos son distintos, caso contrario false</returns>
        public static bool operator !=(Vehiculo vehiculo, Vehiculo vehiculoDos)
        {
            return !(vehiculo == vehiculoDos);
        }
        /// <summary>
        /// Convierte vehiculo en tipo de vehiculo
        /// </summary>
        /// <param name="vehiculo"></param>
        public static implicit operator ETipoVehiculo(Vehiculo vehiculo)
        {
            return vehiculo.TipoVehiculo;
        }
        #endregion


    }
}