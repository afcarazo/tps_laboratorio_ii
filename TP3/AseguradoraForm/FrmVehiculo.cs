using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Text.RegularExpressions;
namespace AseguradoraForm
{
    public partial class FrmVehiculo : Form
    {
        #region Atributos
        private Vehiculo vehiculo;
        private Asegurado asegurado;
        private EMarca marca;
        private ETipoVehiculo tipoVehiculo;
        private EMarcaMoto marcaMoto;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de form vehiculo
        /// </summary>
        public FrmVehiculo()
        {
            InitializeComponent();
            this.asegurado = new Asegurado();
        }     
        /// <summary>
        /// Constructor parametrizado de asegurado
        /// </summary>
        /// <param name="asegurado">asegurado que se asignara al form vehiculo</param>
        public FrmVehiculo(Asegurado asegurado):this()
        {
            this.asegurado = asegurado;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Vehiculo retorna atributo vehiculo
        /// </summary>
        public Vehiculo Vehiculo
        {
            get 
            {
                return this.vehiculo;
            }
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Permite cancelar la operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea cancelar la operación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Carga los comboBox con las marcas y tipos de vehiculo, ademas desabilita el textBox cilindrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCotizar_Load(object sender, EventArgs e)
        {
            this.CmbMarca.DataSource = Enum.GetValues(typeof(EMarca));
            this.cmbVehiculo.DataSource = Enum.GetValues(typeof(ETipoVehiculo));
            this.TxtCilindrada.Enabled = false;
        }
        /// <summary>
        /// Permite continuar con el flujo del programa cerrando el form 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<ETipoVehiculo>(this.cmbVehiculo.SelectedValue.ToString(), out this.tipoVehiculo))
            {
                Enum.TryParse<EMarca>(this.CmbMarca.SelectedValue.ToString(), out this.marca);
                if (this.ValidarCampos())
                {
                    this.BorrarMensajesError();
                    switch (this.tipoVehiculo)
                    {

                        case ETipoVehiculo.Auto:
                            this.vehiculo = new Auto(this.marca, int.Parse(this.TxtAnio.Text), this.TxtPatente.Text, this.TxtModelo.Text);
                            break;
                        case ETipoVehiculo.Camioneta:
                            this.vehiculo = new Camioneta(this.marca, int.Parse(this.TxtAnio.Text), this.TxtPatente.Text, this.TxtModelo.Text);
                            break;
                        case ETipoVehiculo.Moto:
                            this.vehiculo = new Moto(this.marcaMoto, int.Parse(this.TxtAnio.Text), this.TxtPatente.Text, int.Parse(this.TxtCilindrada.Text), this.TxtModelo.Text);
                            break;
                    }
                    if (this.vehiculo != null)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Vehiculo agregado correctamente");
                    }
                }
            }


        }
        /// <summary>
        /// Segun el indice al que se cambia el comboBox vehiculo se estableceran los valores de comboBox marca moto 
        /// y se activara el textBox cilindrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmbVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            if (this.cmbVehiculo.SelectedIndex == 1)
            {
                this.CmbMarca.DataSource = null;
                this.CmbMarca.DataSource = Enum.GetValues(typeof(EMarcaMoto));
                Enum.TryParse<EMarcaMoto>(this.CmbMarca.SelectedValue.ToString(), out this.marcaMoto);
                this.TxtCilindrada.Enabled = true;
            }
            else 
            {
                this.TxtCilindrada.Enabled = false;
            }
        }
      

        #endregion

        #region Métodos
        /// <summary>
        /// Valida que el ingreso de datos sea correcto
        /// </summary>
        /// <returns>retorna true si los campos son válidos, caso contario retorna false</returns>
        private bool ValidarCampos()
        {
            bool retorno = true;
            int numero;
            int cilindrada;
            if (!int.TryParse(this.TxtAnio.Text, out numero) || this.TxtAnio.Text == "")
            {
                this.errorProviderValidacion.SetError(this.TxtAnio, "ingrese un año valido: ");
                retorno = false;
            }
            else if (!(numero > 1990 && numero < 2022))
            {
                this.errorProviderValidacion.SetError(this.TxtAnio, "ingrese un año valido (1990-2021): ");
                retorno = false;
            }
            else
            { 
                    this.errorProviderValidacion.SetError(this.TxtAnio, "");
            }

            if (this.TxtModelo.Text == "" && this.TxtModelo.Text.Length>45)
            {
                this.errorProviderValidacion.SetError(this.TxtModelo, "Ingrese modelo");
                retorno = false;

            }
            
            if (this.TxtPatente.Text == "" || !Regex.IsMatch(this.TxtPatente.Text, "^[A-Z]{4}[0-9]{2}$"))
            {
                errorProviderValidacion.SetError(this.TxtPatente, "Ingrese patente con cuatro letras (mayuscula) y dos numeros");
                retorno = false;
            }
            else
            {
                this.errorProviderValidacion.SetError(this.TxtPatente, "");
            }

            if (this.cmbVehiculo.SelectedIndex==1)
            {
                if (!int.TryParse(this.TxtCilindrada.Text, out cilindrada) || this.TxtCilindrada.Text == "" )
                {
                    this.errorProviderValidacion.SetError(this.TxtCilindrada, "Ingrese cilindrada");
                    retorno = false;
                }
                else if (!(cilindrada > 140 && cilindrada < 1000))
                {
                    this.errorProviderValidacion.SetError(this.TxtCilindrada, "ingrese una cilindrda valida (150-1000): ");
                    retorno = false;
                }
                else
                {
                    this.errorProviderValidacion.SetError(this.TxtCilindrada, "");
                }
            }

            return retorno;
        }
        /// <summary>
        /// Borrar los mensajes de error del errorProvider
        /// </summary>
        private void BorrarMensajesError()
        {
            errorProviderValidacion.SetError(this.TxtAnio,"");
            errorProviderValidacion.SetError(this.TxtModelo, "");
            errorProviderValidacion.SetError(this.TxtPatente, "");
            errorProviderValidacion.SetError(this.TxtCilindrada, "");
        }
        #endregion

     
    }


}
