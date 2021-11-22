using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace AseguradoraForm
{
    public delegate void DelegadoTaskSBarra();
    public partial class FrmEstadistica : Form
    {

        #region Atributos
        Estadistica estadistica;
        #endregion


        #region Constructores
        /// <summary>
        /// Constructor del form informes
        /// </summary>
        public FrmEstadistica()
        {
            InitializeComponent();
        }   
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="asegurados">asegurados que se seran utilizados en la estadistica del form informes</param>
        public FrmEstadistica(List<Asegurado>asegurados):this()
        {
            InitializeComponent();
            this.estadistica = new Estadistica(asegurados);
        }
        #endregion

        #region Eventos
        
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


        #endregion
   
        /// <summary>
        /// guarda la etadistica en un txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Archivos archivo = new Archivos();
                string path = Archivos.GeneradorRuta("Estadistica.txt");
                archivo.GuardarArchivo(path, "\nESTADISTICA DE LA ASEGURADORA:\n" + this.estadistica.ToString());
                MessageBox.Show($"Se guardo con exito!\n Path:{path}");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al guardar");
            }

        }

        private void FrmInformes_Load(object sender, EventArgs e)
        {

            this.lblMostrarEstadistica.Text = "";
            this.lblMostrarEstadistica.AutoSize = true;
            Task task = new Task(() => GenerarEstadisticas());
            task.Start();
        }
        private void GenerarEstadisticas()
        {
            while (this.pgbEstadisticas.Maximum > this.pgbEstadisticas.Value)
            {
                Thread.Sleep(300);
                Progreso();
            }
        }
        private void Progreso()
        {
            if (this.pgbEstadisticas.InvokeRequired)
            {
                DelegadoTaskSBarra delegado = new DelegadoTaskSBarra(this.Progreso);
                Invoke(delegado);
            }
            else 
            {
                if (pgbEstadisticas.Value < 100)
                {
                    pgbEstadisticas.Value++;
                    lblCalculandoEstadistica.Text = $"Calculando {pgbEstadisticas.Value}%";
                }
               

                if (pgbEstadisticas.Value == 100)
                {
                    lblCalculandoEstadistica.Text = "Completado!!";
                    this.lblMostrarEstadistica.Text = estadistica.ToString();
                }
            }
        }
    }
}
