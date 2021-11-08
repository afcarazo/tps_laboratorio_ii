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

namespace AseguradoraForm
{
    public partial class FrmPlanDePago : Form
    {
        #region Atributos
        Asegurado asegurado;
        Seguro seguro;
        EPlanDePago planDePago;
        ETipoSeguro tipoSeguro;
        double montoRespCivil;
        double montoTercerosCompleto;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de form plan de pago
        /// </summary>
        public FrmPlanDePago()
        {
            InitializeComponent();
            this.seguro = new Seguro();
        }   
        /// <summary>
        /// Constructor parametrizado de form plan de pago
        /// </summary>
        /// <param name="asegurado">asegurado que se asignara al form plan de pago</param>
        public FrmPlanDePago(Asegurado asegurado):this()
        {
            this.asegurado = asegurado;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Permite asegurar un usuario establece los datos del seguro a realizar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsegurar_Click(object sender, EventArgs e)
        {
            if (Enum.TryParse<ETipoSeguro>(this.CmbTipoSeguro.SelectedValue.ToString(), out this.tipoSeguro) &&
                Enum.TryParse<EPlanDePago>(this.CmbFormaDePago.SelectedValue.ToString(), out this.planDePago))
            {
                this.seguro.PlanDePago = planDePago;
                this.seguro.TipoDeSeguro = tipoSeguro;
                if (this.CmbTipoSeguro.SelectedIndex == 0)
                {
                    this.seguro.MontoTotal = this.montoRespCivil;
                }
                else 
                {
                    this.seguro.MontoTotal = this.montoTercerosCompleto;
                }
     
                if (this.seguro is not null)
                {
                        this.asegurado.Seguro = this.seguro;
                        this.DialogResult = DialogResult.OK;
                }
            } 
        }
        /// <summary>
        /// Carga los comboBox con las formas de pago, los tipos de seguro, muestra el monto a pagar del seguro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPlanDePago_Load(object sender, EventArgs e)
        {

            this.CmbFormaDePago.DataSource = Enum.GetValues(typeof(EPlanDePago));
            this.CmbTipoSeguro.DataSource = Enum.GetValues(typeof(ETipoSeguro));
            this.montoRespCivil = this.seguro.GenerarSeguroResponsabilidadCivil(this.asegurado);
            this.txtResponsabilidadCivil.Text= $"${this.montoRespCivil}";
            this.montoTercerosCompleto = this.seguro.GenerarSeguroTercerosCompleto(this.asegurado);
            this.txtTercerosCompleto.Text = $"${this.montoTercerosCompleto}";
        }
        /// <summary>
        /// Permite cancelar la operación realizada 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea cancelar la operación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
