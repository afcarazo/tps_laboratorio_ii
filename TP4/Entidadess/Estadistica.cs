using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        #region Atributos
        List<Asegurado> asegurados;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de Asegurados
        /// </summary>
        /// <param name="asegurados"></param>
        public Estadistica(List<Asegurado>asegurados)
        {
            this.asegurados = asegurados;
        }
        #endregion

        #region Métodos
       /// <summary>
       /// Propiedad retorna cantidad de asegurados
       /// </summary>
        public int CantidadAsegurados
        {
            get 
            {
                return this.asegurados.Count;
            }

        }
        /// <summary>
        /// Propiedad retorna porcetaje de camionetas aseguradas
        /// </summary>
        public float PorcentajeDeCamionetas
        {
            get
            {
                return this.CalcularPorcentajePorTipoVehiculo(ETipoVehiculo.Camioneta);
            }
        }
           /// <summary>
        /// Propiedad retorna porcetaje de autos asegurados
        /// </summary>
        public float PorcentajeDeAutos
        {
            get
            {
                
                return this.CalcularPorcentajePorTipoVehiculo(ETipoVehiculo.Auto);
            }
        }
           /// <summary>
        /// Propiedad retorna porcetaje de motos aseguradas
        /// </summary>
        public float PorcentajeDeMotos
        {
            get
            {
                return this.CalcularPorcentajePorTipoVehiculo(ETipoVehiculo.Moto);
            }
        }

        /// <summary>
        /// calcula porcentaje de tipo de vehiculo
        /// </summary>
        /// <param name="tipoVehiculo"></param>
        /// <returns>porcentaje de tipos de vehiculo</returns>
        private float CalcularPorcentajePorTipoVehiculo(ETipoVehiculo tipoVehiculo)
        {
            int total = this.CantidadAsegurados;
            int cantidadAutos = 0;
            foreach (Asegurado item in this.asegurados)
            {
                if(item.Vehiculo == tipoVehiculo)
                {
                    cantidadAutos++;
                }
            }
            return (float)cantidadAutos * 100 / total;
        }

        /// <summary>
        /// Propiedad retorna porcetaje de mujeres aseguradas
        /// </summary>
        public float PorcentajeDeMujeres
        {
            get
            {
                return this.CalcularPorcentajePorGenero(EGenero.Femenino);
            }
        }
        /// <summary>
        /// Propiedad retorna porcetaje de hombres asegurados
        /// </summary>
        public float PorcentajeDeHombres
        {
            get
            {
                return this.CalcularPorcentajePorGenero(EGenero.Masculino);
            }
        }
        /// <summary>
        /// Propiedad retorna porcetaje de no binarios aseguradas
        /// </summary>
        public float PorcentajeDeNoBinarios
        {
            get
            {
                return this.CalcularPorcentajePorGenero(EGenero.NoBinario);
            }
        }
        /// <summary>
        /// calcula el porcentaje de generos
        /// </summary>
        /// <param name="tipoGenero"></param>
        /// <returns>porcentaje</returns>
        private float CalcularPorcentajePorGenero(EGenero tipoGenero)
        {
            int total = this.asegurados.Count;
            int cantidadGenero = 0;
            foreach (Asegurado item in this.asegurados)
            {
                if(item.Genero == tipoGenero)
                {
                    cantidadGenero++;
                }
            }
            return (float)cantidadGenero * 100 / total;
        }

        /// <summary>
        /// Retorna string de la cantidad de vehiculos con los seguros mas elevados que se encuentran en un rango de 10000-15000 pesos 
        /// </summary>
        /// <returns>cantidad vehiculos</returns>
        public string SeguroMasElevados()
        {
            int contador = 0;
            StringBuilder sb = new StringBuilder();
            foreach (Asegurado item in this.asegurados)
            {
                if (item.Seguro.MontoTotal> 10000 && item.Seguro.MontoTotal < 15000)
                {
                    contador++;
                   
                }
            }
            sb.Append($"Seguros más caros (valorados en un rango de 10000-15000) TOTALES: {contador}");
            return sb.ToString();
        }
        /// <summary>
        /// Retorna el genero que mas asegura
        /// </summary>
        /// <returns>genero</returns>
        public string GeneroQueMasAseguraVehiculo()
        {
            int contadorMasculino = 0;
            int contadorFemenino = 0;
            int contadorNoBinario = 0;
            EGenero genero;
            foreach (Asegurado item in this.asegurados)
            {
                switch (item.Genero)
                {
                    case EGenero.Masculino:
                        contadorMasculino++;
                        break;
                    case EGenero.Femenino:
                        contadorFemenino++;
                        break;
                    case EGenero.NoBinario:
                        contadorNoBinario++;
                        break;
                    default:
                        break;
                }
            }
            if (contadorMasculino > contadorFemenino && contadorMasculino > contadorNoBinario)
            {
                genero = EGenero.Masculino;
            }
            else if (contadorFemenino > contadorNoBinario)
            {
                genero = EGenero.Femenino;
            }
            else
            {
                genero = EGenero.NoBinario;
            }

            return genero.ToString();
        }
        /// <summary>
        /// retorna el tipo de vehiculo mas asegurado 
        /// </summary>
        /// <returns> vehiculo mas asegurado</returns>
        public string VehiculoMasAsegurado()
        {
            int contadorAutos = 0;
            int contadorMotos = 0;
            int contadorCamioneta = 0;
            ETipoVehiculo vehiculoMasAsegurado;

            foreach (Asegurado item in this.asegurados)
            {
                switch (item.Vehiculo.TipoVehiculo)
                {
                    case ETipoVehiculo.Camioneta:
                        contadorCamioneta++;
                        break;
                    case ETipoVehiculo.Auto:
                        contadorAutos++;
                        break;
                    case ETipoVehiculo.Moto:
                        contadorMotos++;
                        break;
                    default:
                        break;
                }
            }
            if (contadorMotos > contadorAutos && contadorMotos > contadorCamioneta)
            {
                vehiculoMasAsegurado = ETipoVehiculo.Moto;
            }
            else if (contadorAutos > contadorCamioneta)
            {
                vehiculoMasAsegurado = ETipoVehiculo.Auto;
            }
            else
            {
                vehiculoMasAsegurado = ETipoVehiculo.Camioneta;
            }
            return "El vehiculo más asegurado es: " + vehiculoMasAsegurado.ToString();
        }

        /// <summary>
        /// Propiedad que retorna cantidad asegurados en Berazategui
        /// </summary>
        public int Berazategui
        {
            get 
            {
                int contadorBerazategui = 0;
                foreach (Asegurado item in this.asegurados)
                {
                    if (item.Localidad == ELocalidad.Berazategui)
                    {
                       contadorBerazategui++;
                    }
                }
                    return contadorBerazategui;
                }
        }

        /// <summary>
        /// Propiedad que retorna cantidad asegurados en Quilmes
        /// </summary>
        public int Quilmes
        {
            get
            {
                int contadorQuilmes = 0;
                foreach (Asegurado item in this.asegurados)
                {
                    if (item.Localidad == ELocalidad.Quilmes)
                    {
                        contadorQuilmes++;
                    }
                }
                return contadorQuilmes;
            }
        }  
        /// <summary>
        /// Propiedad que retorna cantidad asegurados en lomas de zamora
        /// </summary>
        public int LomasDeZamora
        {
            get
            {
                int contadorLomasDeZamora = 0;
                foreach (Asegurado item in this.asegurados)
                {
                    if (item.Localidad == ELocalidad.LomasDeZamora)
                    {
                        contadorLomasDeZamora++;
                    }
                }
                return contadorLomasDeZamora;
            }
        }   
        /// <summary>
        /// Propiedad que retorna cantidad asegurados en Glew
        /// </summary>
        public int Glew
        {
            get
            {
                int contadorGlew = 0;
                foreach (Asegurado item in this.asegurados)
                {
                    if (item.Localidad == ELocalidad.Glew)
                    {
                        contadorGlew++;
                    }
                }
                return contadorGlew;
            }
        }
        /// <summary>
        /// Propiedad que retorna cantidad asegurados en Avellaneda
        /// </summary>
        public int Avellaneda
        {
            get
            {
                int contadorAvellaneda = 0;
                foreach (Asegurado item in this.asegurados)
                {
                    if (item.Localidad == ELocalidad.Avellaneda)
                    {
                        contadorAvellaneda++;
                    }
                }
                return contadorAvellaneda;
            }
        }  
        /// <summary>
        /// Propiedad que retorna cantidad asegurados en Lanus
        /// </summary>
        public int Lanus
        {
            get
            {
                int contadorLanus = 0;
                foreach (Asegurado item in this.asegurados)
                {
                    if (item.Localidad == ELocalidad.Lanus)
                    {
                        contadorLanus++;
                    }
                }
                return contadorLanus;
            }
        }
          /// <summary>
        /// Propiedad que retorna cantidad asegurados en Wilde
        /// </summary>
        public int Wilde
        {
            get
            {
                int contadorWilde = 0;
                foreach (Asegurado item in this.asegurados)
                {
                    if (item.Localidad == ELocalidad.Wilde)
                    {
                        contadorWilde++;
                    }
                }
                return contadorWilde;
            }
        }


        /// <summary>
        /// retorna la localidad que mas asegura
        /// </summary>
        /// <returns>localidad</returns>
        public string LocalidadQueMasAsegura()
        {
            ELocalidad localidad;

            if (this.Berazategui > this.Quilmes && this.Berazategui > this.LomasDeZamora && this.Berazategui > this.Glew &&
                this.Berazategui > this.Avellaneda && this.Berazategui > this.Lanus && this.Berazategui > this.Wilde)
            {
                localidad = ELocalidad.Berazategui;
            }
            else if (this.Quilmes > this.LomasDeZamora && this.Quilmes > this.Glew && this.Quilmes > this.Avellaneda &&
                     this.Quilmes > this.Lanus && this.Quilmes > this.Wilde)
            {
                localidad = ELocalidad.Quilmes;
            }
            else if (this.LomasDeZamora > this.Glew && this.LomasDeZamora > this.Avellaneda &&
                     this.LomasDeZamora > this.Lanus && this.LomasDeZamora > this.Wilde)
            {
                localidad = ELocalidad.LomasDeZamora;
            }
            else if (this.Glew > this.Avellaneda && this.Glew > this.Lanus && this.Glew > this.Wilde)
            {
                localidad = ELocalidad.Glew;
            }
            else if (this.Avellaneda > this.Lanus && this.Avellaneda > this.Wilde)
            {
                localidad = ELocalidad.Avellaneda;
            }
            else if (this.Lanus > this.Wilde)
            {
                localidad = ELocalidad.Lanus;
            }
            else 
            {
                localidad = ELocalidad.Wilde;
            }

            return localidad.ToString();

        }
        /// <summary>
        /// Muestra las estadisticas
        /// </summary>
        /// <returns> string con todas las estadistica</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\nTotal de asegurados: {this.CantidadAsegurados}");
            sb.AppendLine($"Porcentaje de autos asegurados: %{this.PorcentajeDeAutos}");
            sb.AppendLine($"Porcentaje de camionetas aseguradas: %{this.PorcentajeDeCamionetas}");
            sb.AppendLine($"Porcentaje de motos aseguradas: %{this.PorcentajeDeMotos}");
            sb.AppendLine($"{this.SeguroMasElevados()}");
            sb.AppendLine($"{this.VehiculoMasAsegurado()}");
            sb.AppendLine("División por sexos");
            sb.AppendLine($"Porcentaje de mujeres aseguradas: %{this.PorcentajeDeMujeres}");
            sb.AppendLine($"Porcentaje de hombres asegurados: %{this.PorcentajeDeHombres}");
            sb.AppendLine($"Porcentaje de no binarios asegurados: %{this.PorcentajeDeNoBinarios}");
            sb.AppendLine($"Genero que mas asegura: {this.GeneroQueMasAseguraVehiculo()}");
            sb.AppendLine("Ditribución por localidades");
            sb.AppendLine($"Cantidad de asegurados en Berazategui: {this.Berazategui}");
            sb.AppendLine($"Cantidad de asegurados en Quilmes: {this.Quilmes}");
            sb.AppendLine($"Cantidad de asegurados en Lomas de Zamora: {this.LomasDeZamora}");
            sb.AppendLine($"Cantidad de asegurados en Glew: {this.Glew}");
            sb.AppendLine($"Cantidad de asegurados en Avellaneda: {this.Avellaneda}");
            sb.AppendLine($"Cantidad de asegurados en Lanus: {this.Lanus}");
            sb.AppendLine($"Cantidad de asegurados en Wilde: {this.Wilde}");
            sb.AppendLine($"Localidad que mas asegura: {this.LocalidadQueMasAsegura()}");
            return sb.ToString();
        }

        #endregion
    }
}
