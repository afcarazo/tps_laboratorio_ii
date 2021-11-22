using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public class Seguro
    {
        #region Atributos
        private EPlanDePago planDePago;
        private double montoTotal;
        private ETipoSeguro tipoDeSeguro;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor Seguro inicializa tipo de seguro en responsabilidad civil y plan de pago por debito
        /// </summary>
        public Seguro()
        {
            this.tipoDeSeguro = ETipoSeguro.ResponsabilidadCivil;
            this.planDePago = EPlanDePago.Debito;
            this.montoTotal = 0;
        }
        /// <summary>
        /// Constructor Seguro parametrizado
        /// </summary>
        /// <param name="planDePago">plan de pago que se asignara en seguro</param>
        /// <param name="tipoSeguro">tipo de seguro que se asignara en seguro</param>
        public Seguro(EPlanDePago planDePago, ETipoSeguro tipoSeguro)
        {
            this.TipoDeSeguro = tipoSeguro;
            this.PlanDePago = planDePago;
        }
        /// <summary>
        /// Constructor Seguro parametrizado
        /// </summary>
        /// <param name="planDePago">plan de pago que se asignara en seguro</param>
        /// <param name="tipoSeguro">tipo de seguro que se asignara en seguro</param>
        /// <param name="monto">monto que se asignara en seguro</param>
        public Seguro(EPlanDePago planDePago, ETipoSeguro tipoSeguro, double monto):this(planDePago,tipoSeguro)
        {
            this.MontoTotal = monto;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Plan de Pago asigna y retorna atributo plan de pago
        /// </summary>
        public EPlanDePago PlanDePago
        {
            get
            {
                return this.planDePago;
            }
            set
            {
                this.planDePago = value;
            }
        }     
        /// <summary>
        /// Propiedad Tipo de Seguro asigna y retorna atributo tipo de seguro
        /// </summary>
        public ETipoSeguro TipoDeSeguro
        {
            get
            {
                return this.tipoDeSeguro;
            }
            set
            {
                this.tipoDeSeguro = value;
            }
        }

        /// <summary>
        /// Propiedad Monto Total asigna y retorna atributo monto total
        /// </summary>
        public double MontoTotal
        {

            get 
            {
                return this.montoTotal;
            }
            set 
            {
                if (value>0)
                {
                    this.montoTotal = value;
                }
            }

        }
        #endregion

        #region Métodos
        /// <summary>
        /// Muestra todos los datos del seguro
        /// </summary>
        /// <returns>retorna string con los datos del seguro</returns>
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Plan de pago {this.PlanDePago}");
            sb.AppendLine($"Tipo de seguro: {this.TipoDeSeguro}");
            sb.AppendLine($"Monto total: {this.MontoTotal}");
            return sb.ToString();
        }
        /// <summary>
        /// Muestra todos los datos del seguro
        /// </summary>
        /// <returns>retorna string con todos los datos del seguro</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        /// <summary>
        /// Genera cotizaciones random para el tipo de seguro responsabilidad civil 
        /// </summary>
        /// <param name="asegurado">asegurado del cual se obtendra el vehiculo para establecer rango de valores</param>
        /// <returns>retorna double random generado</returns>
        public double GenerarSeguroResponsabilidadCivil(Asegurado asegurado)
        {
            Random random = new Random();
            double retorno = 0;
            ETipoVehiculo tipo = asegurado.Vehiculo.TipoVehiculo;
            switch (tipo)
            {
                case ETipoVehiculo.Auto:
                    retorno += random.Next(2000, 4000);
                    break;
                case ETipoVehiculo.Moto:
                    retorno += random.Next(1500, 3000);
                    break;
                case ETipoVehiculo.Camioneta:
                    retorno += random.Next(5000, 10000);
                    break;
            }
            return retorno;
        }
        /// <summary>
        /// Genera cotizaciones random para el tipo de seguro terceros completo
        /// </summary>
        /// <param name="asegurado">asegurado del cual se obtendra el vehiculo para establecer rango de valores</param>
        /// <returns>retorna double random generado</returns>
        public double GenerarSeguroTercerosCompleto(Asegurado asegurado)
        {
            Random random = new Random();
            double retorno = 0;
            ETipoVehiculo tipo = asegurado.Vehiculo.TipoVehiculo;
            switch (tipo)
            {
                case ETipoVehiculo.Auto:
                    retorno += random.Next(8000, 9000);
                    break;
                case ETipoVehiculo.Moto:
                    retorno += random.Next(5000, 10000);
                    break;
                case ETipoVehiculo.Camioneta:
                    retorno += random.Next(12000, 14000);
                    break;
            }
            return retorno;
        }
        #endregion
    }
    
}
