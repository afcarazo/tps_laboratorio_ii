using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; 
using Entidades;
using System.Net.Mail;

namespace AseguradoraForm
{
    public partial class FrmAsegurado : Form
    {
        #region Atributos
        Asegurado asegurado;
        ELocalidad localidad;
        EGenero genero;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de form asegurado
        /// </summary>
        public FrmAsegurado()
        {
            InitializeComponent();
            this.asegurado = new Asegurado();
        }
        /// <summary>
        /// Constructor de form asegurado parametrizado
        /// </summary>
        /// <param name="asegurado">asegurado que se asignara en el form principal</param>
        public FrmAsegurado(Asegurado asegurado) : this()
        {
            this.asegurado = asegurado;
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad Asegurado retorna asegurado
        /// </summary>
        public Asegurado Asegurado
        {
            get
            {
                return this.asegurado;
            } 
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Cancela operación
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
        /// Carga los comboBox con las localidades y generos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.CmbLocalidad.DataSource = Enum.GetValues(typeof(ELocalidad));
            this.CmbGenero.DataSource = Enum.GetValues(typeof(EGenero));
        }
        /// <summary>
        /// Permite cerrar el form para continuar la siguiente operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnContinuar_Click_1(object sender, EventArgs e)
        {
            if (Enum.TryParse<ELocalidad>(this.CmbLocalidad.SelectedValue.ToString(), out this.localidad) && Enum.TryParse<EGenero>(this.CmbGenero.SelectedValue.ToString(), out this.genero))
            {

                if (this.ValidarCampos())
                {
                    if (int.TryParse(this.TxtDni.Text, out int dni))
                    {

                        this.asegurado = new Asegurado(this.TxtNombre.Text, this.TxtApellido.Text, localidad, this.TxtEmail.Text, dni, genero);
                    }

                    if (this.asegurado is not null)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Asegurado agregado exitosamente");
                    }
                }
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        ///Permite validar todos los campos de ingreso de valores 
        /// </summary>
        /// <returns>retorn true si los campos son válidos, de lo contrario retorna false</returns>
        private bool ValidarCampos()
        {
            int dni;
            bool retorno = true;
            if (!int.TryParse(this.TxtDni.Text, out dni) || this.TxtDni.Text == "")
            {
                this.errorProviderValidacion.SetError(this.TxtDni, "ingrese un dni valido: ");
                retorno = false;
            }
            else if (!(dni > 10000000 && dni < 90000000))
            {
                this.errorProviderValidacion.SetError(this.TxtDni, "ingrese un dni valido (10000000-90000000): ");
                retorno = false;
            }
            else
            {
                this.errorProviderValidacion.SetError(this.TxtDni, "");
            }

            if (this.TxtNombre.Text == "" || this.TxtNombre.Text.Length > 21 || !this.EsCadenaValida(this.TxtNombre.Text))
            {
                errorProviderValidacion.SetError(this.TxtNombre, "Ingrese nombre válido");
                retorno = false;
            }
            else
            {
                this.errorProviderValidacion.SetError(this.TxtNombre, "");
            }  
            if (this.TxtApellido.Text == "" || !this.EsCadenaValida(this.TxtApellido.Text) || this.TxtApellido.Text.Length>21)
            {
                errorProviderValidacion.SetError(this.TxtApellido, "Ingrese apellido valido");
                retorno = false;
            }
            else
            {
                this.errorProviderValidacion.SetError(this.TxtApellido, "");
            }
            if (this.TxtEmail.Text == "" || !MailAddress.TryCreate(this.TxtEmail.Text,out MailAddress mailAddress))
            {
                errorProviderValidacion.SetError(this.TxtEmail, "Ingrese email valido");
                retorno = false;
            }
            else
            {
                this.errorProviderValidacion.SetError(this.TxtEmail, "");
            }

            return retorno;
        }
        /// <summary>
        /// Evalua si es una cadena compuesta por letras y la pasa a minuscula
        /// </summary>
        /// <param name="cadena">cadena a evaluar</param>
        /// <returns>retorna true si es una cadena de letras, de lo contario false</returns>
        private bool EsCadenaValida(string cadena)
        {
            bool retorno = true;

            foreach (char item in cadena)
            {
                if (char.IsDigit(item))
                {
                    retorno = false;
                    break;
                }
            }
            if (retorno)
            {
               cadena.ToLower();
            }
            return retorno;
        }
        #endregion
    }
}
