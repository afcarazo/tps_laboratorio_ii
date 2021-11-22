using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace AseguradoraForm
{
 

    public partial class FrmPrincipal : Form
    {
        #region Atributos
        Aseguradora aseguradora;
        Asegurado asegurado;
        Serializador<List<Asegurado>> serializadorXML;
        string ruta = Archivos.GeneradorRuta("asegurados.xml");

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de form principal
        /// </summary>
        public FrmPrincipal()
        {
            InitializeComponent();
            this.aseguradora = new Aseguradora();
            this.aseguradora.TotalAcumulado += new TotalAcumuladoDelegado(TotalGenerado_Evento);
            this.asegurado = new Asegurado();
            this.serializadorXML = new Serializador<List<Asegurado>>(IArchivo<List<Asegurado>>.ETipoDeArchivo.XML);
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Permite cerrar el form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Permite cancelar el cierre del programa y guardar una lista con los asegurados cargados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Permite la carga de los datos que necesita el vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarDatosVehiculo_Click(object sender, EventArgs e)
        {
            FrmVehiculo frmVehiculo = new FrmVehiculo(this.asegurado);
            frmVehiculo.ShowDialog();

            if (frmVehiculo.DialogResult == DialogResult.OK)
            {
                this.asegurado.Vehiculo = frmVehiculo.Vehiculo;
                this.btnCargarDatosVehiculo.Enabled = false;
                this.btnPlanDePago.Enabled = true;
               

            }

        }
        /// <summary>
        /// Permite el ingreso de datos de un usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngreseUsuario_Click(object sender, EventArgs e)
        {
            FrmAsegurado frmAsegurado = new FrmAsegurado(this.asegurado);

            frmAsegurado.ShowDialog();
            this.asegurado = frmAsegurado.Asegurado;

            if (frmAsegurado.DialogResult == DialogResult.OK)
            {
                this.btnPlanDePago.Enabled = false;
                this.btnCargarDatosVehiculo.Enabled = true;
                this.btnIngreseUsuario.Enabled = false;
                this.BtnGenerarInformes.Enabled = true;
                this.btnAsegurados.Enabled = true;
            }
        }
        /// <summary>
        /// Permite establecer los datos del seguro a realizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlanDePago_Click(object sender, EventArgs e)
        {
            FrmPlanDePago frmPlanDePago = new FrmPlanDePago(this.asegurado);
           
            if (this.asegurado is not null)
            {
                frmPlanDePago.ShowDialog();

            }

            if (frmPlanDePago.DialogResult == DialogResult.OK)
            {
                this.btnPlanDePago.Enabled = false;
                this.aseguradora += this.asegurado;
                this.btnAsegurados.Enabled = true;
                this.btnAsegurarOtro.Enabled = true;
            }
        }
   
        /// <summary>
        /// Permite asegurar otro usuario, reiniciando los valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsegurarOtro_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }
        /// <summary>
        /// Permite mostrar los asegurados actuales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAsegurados_Click(object sender, EventArgs e)
        {
            FrmAsegurados frmAsegurados = new FrmAsegurados(this.aseguradora);

            frmAsegurados.ShowDialog();
        }
        /// <summary>
        /// Deshabilita los botones necesarios para el comienzo del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.btnAsegurarOtro.Enabled = false;
            this.btnPlanDePago.Enabled = false;
            this.BtnGenerarInformes.Enabled = false;
            this.btnAsegurados.Enabled = false;
            this.btnCargarDatosVehiculo.Enabled = false;
            this.btnIngreseUsuario.Enabled = true;
            this.BtnDatos.Enabled = true;
        }
        /// <summary>
        /// Permite la generación de informes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnGenerarInformes_Click(object sender, EventArgs e)
        {
            FrmEstadistica frmInformes = new FrmEstadistica(this.aseguradora.Asegurados);
            if (this.aseguradora.Asegurados.Count > 1)
            {
                frmInformes.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Primero deberia agregar al menos dos asegurados!");
            }

        }
        /// <summary>
        /// Muestra submenu de carga de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDatos_Click(object sender, EventArgs e)
        {
            this.subMenuDatos.Visible = true;
        }
        /// <summary>
        /// Permite importar una la lista de asegurados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCargarDatos_Click(object sender, EventArgs e)
        {
            this.subMenuDatos.Visible = false;
            try
            {
    
                if (MessageBox.Show($"Esta seguro de abrir un archivo?\nPerdera todos los cambios que ha realizado", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.aseguradora.Asegurados = this.serializadorXML.LeerArchivo(this.ruta);
                    MessageBox.Show($"Se importo la lista de asegurados,\n Path:{this.ruta}");
                    this.BtnGenerarInformes.Enabled = true;
                    this.btnAsegurados.Enabled = true;
                }
            }
            catch (SerializarException ex)
            {
                MessageBox.Show($"{ex.Message},\n En la clase:{ex.Clase}, \n En el método: {ex.Metodo}\n {ex.InnerException.Message} ");
            }
        }
        /// <summary>
        /// Permite exportar la lista de asegurados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExportarDatos_Click(object sender, EventArgs e)
        {
            this.subMenuDatos.Visible = false;
            try
            {
                if (MessageBox.Show($"Esta seguro de que desea guardar el archivo?\nSe sobreescribiran los datos previos", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    if (this.aseguradora.Asegurados.Count > 0)
                    {
                        serializadorXML.GuardarArchivo(ruta, aseguradora.Asegurados);
                        MessageBox.Show($"Se exportaron los datos,\nPath: {this.ruta}");
                    }
                    else
                    {
                        MessageBox.Show("Primero deberia ingresar asegurados!");
                    }
                }
            }
            catch (SerializarException ex)
            {
                MessageBox.Show($"{ex.Message},\n En la clase:{ex.Clase}, \n En el método: {ex.Metodo}\n {ex.InnerException.Message} ");
            }
        }
        /// <summary>
        /// Hace visible submenu de base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBaseDatos_Click(object sender, EventArgs e)
        {
            this.subMenuBs.Visible = true;
        }
        /// <summary>
        /// Permite importar datos de la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarDatosBs_Click_1(object sender, EventArgs e)
        {
            this.subMenuBs.Visible = false;
            AccederDatos accederDatos = new AccederDatos();
            if (accederDatos.ProbarConexion())
            {

                if (MessageBox.Show($"Esta seguro de que desea guardar el archivo?\nSe sobreescribiran los datos previos", "Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        this.aseguradora.Asegurados = accederDatos.ObtenerListaAsegurado();
                        this.btnAsegurados.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocurrio un problema al importar los datos");
                        this.btnAsegurados.Enabled = false;
                    }
                   
                }
            }
            else 
            {
                MessageBox.Show("Ocurrio un problema con la conexión");
            }
        }
        /// <summary>
        /// Permite exportar datos a la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExportarDatosBs_Click(object sender, EventArgs e)
        {
            this.subMenuBs.Visible = false;

            AccederDatos accederDatos = new AccederDatos();
            foreach (Asegurado item in this.aseguradora.Asegurados)
            {
                if (!accederDatos.AgregarDato(item))
                {
                    MessageBox.Show("Ocurrio un problema al agregar el asegurado");
                }
                
            }
            MessageBox.Show("Exportado con exito!");
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Reincia los valores del asegurado y los botones del form para el ingreso de un nuevo asegurado
        /// </summary>
        private void Refrescar()
        {
            this.asegurado = new Asegurado();
            this.btnCargarDatosVehiculo.Enabled = false;
            this.btnAsegurarOtro.Enabled = false;
            this.btnPlanDePago.Enabled = false;
            this.btnIngreseUsuario.Enabled = true;
        }

        /// <summary>
        ///  Manejador de evento, cada vez que se ingrese una lista de asegurados o asegurados imprimira un txt con las entradas
        /// </summary>
        /// <param name="aseguradora">aseguradora de donde obtendra la lista de asegurados</param>
        public void TotalGenerado_Evento(Aseguradora aseguradora)
        {
            Encoding encoding = Encoding.UTF8;
            string ruta = Archivos.GeneradorRuta("Total.txt");
            try
            {
                using (StreamWriter escritor = new StreamWriter(ruta, true, encoding))
                {
                    double total = 0;
                    escritor.WriteLine("ENTRADAS");
                    escritor.WriteLine("--------------------------------------------");
                    escritor.Write("LA FECHA ES: ");
                    escritor.WriteLine(DateTime.Now);
                    string listadoMontos = aseguradora.MontoTotalExt(out total);
                    escritor.WriteLine(listadoMontos);
                    escritor.WriteLine($"TOTAL: {total}");
                    MessageBox.Show($"Se acumularon los ingresos en el archivo TOTAL.txt en {ruta}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        #endregion


    }
}