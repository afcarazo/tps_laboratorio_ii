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
    public partial class FrmInformes : Form
    {

        #region Atributos
        Estadistica estadistica;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor del form informes
        /// </summary>
        public FrmInformes()
        {
            InitializeComponent();
        }   
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="asegurados">asegurados que se seran utilizados en la estadistica del form informes</param>
        public FrmInformes(List<Asegurado>asegurados):this()
        {
            InitializeComponent();
            this.estadistica = new Estadistica(asegurados);
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Permite realizar informe de autos asegurados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAutosAsegurados_Click(object sender, EventArgs e)
        {
            estadistica.CantidadDeAutos();
            MessageBox.Show("Informe realizado y guardado");
        }
        /// <summary>
        /// Permite realizar el informe de camionetas aseguradas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCamionetasAseguradas_Click(object sender, EventArgs e)
        {
            estadistica.CantidadDeCamionetas();
            MessageBox.Show("Informe realizado y guardado");
        }
        /// <summary>
        /// Permite realizar el informe de motos aseguradas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnMotosAseguradas_Click(object sender, EventArgs e)
        {
            estadistica.CantidadDeMotos();
            MessageBox.Show("Informe realizado y guardado");
        }
        /// <summary>
        /// Permite realizar informe de seguros superiores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSegurosSuperiores_Click(object sender, EventArgs e)
        {
            estadistica.SeguroMasElevados();
            MessageBox.Show("Informe realizado y guardado");
        }
        /// <summary>
        /// Permite realizar informe de vehiculo mas asegurado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnVehiculoMasAsegurado_Click(object sender, EventArgs e)
        {
            estadistica.VehiculoMasAsegurado();
            MessageBox.Show("Informe realizado y guardado");
        }
        /// <summary>
        /// Permite realizar informe de localidad que mas asegura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLocalidadQueMasAsegura_Click(object sender, EventArgs e)
        {
            estadistica.LocalidadQueMasAsegura();
            MessageBox.Show("Informe realizado y guardado");
        }
        /// <summary>
        /// Permite continuar con el flujo del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        /// <summary>
        ///  Permite realizar informe del genero que mas asegura
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGeneroQueMasAsegura_Click(object sender, EventArgs e)
        {
            estadistica.GeneroQueMasAseguraVehiculo();
            MessageBox.Show("Informe realizado y guardado");
        }
        #endregion


    }
}
