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
        /// Genera informe con la cantidad de autos y una lista de los mismos con todos los detalles.
        /// </summary>
        public void CantidadDeAutos()
        {
            int contador = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Autos Asegurados: \n");
            foreach (Asegurado item in this.asegurados)
            {
                if (item.Vehiculo.TipoVehiculo== ETipoVehiculo.Auto)
                {
                    contador++;
                    sb.AppendLine(item.ToString());
                }
            }
            sb.Append($"Cantidad total: {contador}");
            Archivos archivo = new Archivos();
            archivo.GuardarArchivo("AutosAsegurados.txt", sb.ToString());
        }
        /// <summary>
        /// Genera informe con la cantidad de camionetas y una lista de las mismas con todos los detalles.
        /// </summary>
        public void CantidadDeCamionetas()
        {
            int contador = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Camionetas Aseguradas: \n");
            foreach (Asegurado item in this.asegurados)
            {
                if (item.Vehiculo.TipoVehiculo== ETipoVehiculo.Camioneta)
                {
                    contador++;
                    sb.AppendLine(item.ToString());
                }
            }
            sb.Append($"Cantidad total: {contador}");
            Archivos archivo = new Archivos();
            archivo.GuardarArchivo("CamionetasAseguradas.txt", sb.ToString());
        }
        /// <summary>
        /// Genera informe con la cantidad de motos y una lista de las mismas con todos los detalles.
        /// </summary>
        public void CantidadDeMotos()
        {
            int contador = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Motos Aseguradas: \n");
            foreach (Asegurado item in this.asegurados)
            {
                if (item.Vehiculo.TipoVehiculo== ETipoVehiculo.Moto)
                {
                    contador++;
                    sb.AppendLine(item.ToString());
                }
            }
            sb.Append($"Cantidad total: {contador}");
            Archivos archivo = new Archivos();
            archivo.GuardarArchivo("MotosAseguradas.txt", sb.ToString());
        }
        /// <summary>
        /// Genera informe de los vehiculos con los seguros mas elevados que se encuentran en un rango de 10000-15000 pesos con su respectiva información
        /// </summary>
        public void SeguroMasElevados()
        {
            int contador = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los seguros mas caros pertenecen a los asegurados: \n");
            foreach (Asegurado item in this.asegurados)
            {
                if (item.Seguro.MontoTotal> 10000 && item.Seguro.MontoTotal < 15000)
                {
                    contador++;
                    sb.AppendLine(item.ToString());
                }
            }
            sb.Append($"Cantidad total: {contador}");
            Archivos archivo = new Archivos();
            archivo.GuardarArchivo("SegurosMasElevados.txt", sb.ToString());
        }
        /// <summary>
        /// Genera informe de los generos que mas aseguran con su respectiva información
        /// </summary>
        public void GeneroQueMasAseguraVehiculo()
        {
            int contadorMasculino = 0;
            int contadorFemenino = 0;
            int contadorNoBinario = 0;
            EGenero genero;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El que más asegura es el  ");
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
            sb.Append($"{genero}\n");
            sb.AppendLine("Lista de asegurados: \n");
            foreach (Asegurado item in this.asegurados)
            {
                if (genero == item.Genero)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            Archivos archivo = new Archivos();
            archivo.GuardarArchivo("GeneroQueMasAsegura.txt", sb.ToString());
        }
        /// <summary>
        /// Muestra los vehiculos que mas se aseguran (moto, camioneta o auto)  con su respectiva información
        /// </summary>
        /// <returns>retorna los vehiculos mas asegurados</returns>
        public void VehiculoMasAsegurado()
        {
            int contadorAutos = 0;
            int contadorMotos = 0;
            int contadorCamioneta = 0;
            ETipoVehiculo vehiculoMasAsegurado;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El vehiculo más asegurado es  ");
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

            sb.Append($"{vehiculoMasAsegurado}\n");
            sb.AppendLine("Lista de vehiculos: \n");
            foreach (Asegurado item in this.asegurados)
            {
                if (vehiculoMasAsegurado== item.Vehiculo.TipoVehiculo)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            Archivos archivo = new Archivos();
            archivo.GuardarArchivo("VehiculoMasAsegurado.txt", sb.ToString());
        }
        /// <summary>
        /// genera informe de la localidad que mas asegura con el detalle de cada asegurado
        /// </summary>
        public void LocalidadQueMasAsegura()
        {
            int contadorBerazategui = 0;
            int contadorQuilmes = 0;
            int contadorLomasDeZamora = 0;
            int contadorGlew = 0;
            int contadorAvellaneda = 0;
            int contadorLanus = 0;
            int contadorWilde = 0;
            ELocalidad localidad;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("La localidad que más asegura es:  ");
            foreach (Asegurado item in this.asegurados)
            {
                switch (item.Localidad)
                {
                    case ELocalidad.Berazategui:
                        contadorBerazategui++;
                        break;
                    case ELocalidad.Quilmes:
                        contadorQuilmes++;
                        break;
                    case ELocalidad.LomasDeZamora:
                        contadorLomasDeZamora++;
                        break;  
                    case ELocalidad.Glew:
                        contadorGlew++;
                        break;
                    case ELocalidad.Avellaneda:
                        contadorAvellaneda++;
                        break;
                    case ELocalidad.Lanus:
                        contadorLanus++;
                        break;
                    case ELocalidad.Wilde:
                        contadorWilde++;
                        break;
                    default:
                        break;
                }
            }
            if (contadorBerazategui > contadorQuilmes && contadorBerazategui > contadorLomasDeZamora && contadorBerazategui > contadorGlew &&
                contadorBerazategui > contadorAvellaneda && contadorBerazategui > contadorLanus && contadorBerazategui > contadorWilde)
            {
                localidad = ELocalidad.Berazategui;
            }
            else if (contadorQuilmes > contadorLomasDeZamora && contadorQuilmes > contadorGlew && contadorQuilmes > contadorAvellaneda &&
                     contadorQuilmes > contadorLanus && contadorQuilmes > contadorWilde)
            {
                localidad = ELocalidad.Quilmes;
            }
            else if (contadorLomasDeZamora > contadorGlew && contadorLomasDeZamora > contadorAvellaneda &&
                     contadorLomasDeZamora > contadorLanus && contadorLomasDeZamora > contadorWilde)
            {
                localidad = ELocalidad.LomasDeZamora;
            }
            else if (contadorGlew > contadorAvellaneda && contadorGlew > contadorLanus && contadorGlew > contadorWilde)
            {
                localidad = ELocalidad.Glew;
            }
            else if (contadorAvellaneda > contadorLanus && contadorAvellaneda > contadorWilde)
            {
                localidad = ELocalidad.Avellaneda;
            }
            else if (contadorLanus > contadorWilde)
            {
                localidad = ELocalidad.Lanus;
            }
            else 
            {
                localidad = ELocalidad.Wilde;
            }
            sb.Append($"{localidad}\n");
            sb.AppendLine("Lista de asegurados en la localidad: \n");
            foreach (Asegurado item in this.asegurados)
            {
                if (localidad == item.Localidad)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            Archivos archivo = new Archivos();
            archivo.GuardarArchivo("LocalidadQueMasAsegura.txt", sb.ToString());
        }

     
        #endregion
    }
}
