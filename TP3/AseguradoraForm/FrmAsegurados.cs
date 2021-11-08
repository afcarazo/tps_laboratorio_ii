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
    public partial class FrmAsegurados : Form
    {
        #region Atributos
        Aseguradora aseguradora;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de form de asegurados
        /// </summary>
        public FrmAsegurados()
        {
            InitializeComponent();
            this.aseguradora = new Aseguradora();
        }        
        /// <summary>
        /// Constructor parametrizado de form Asegurados
        /// </summary>
        /// <param name="aseguradora">aseguradora que se asignara en el form de aseguradora</param>
        public FrmAsegurados(Aseguradora aseguradora):this()
        {
            this.aseguradora = aseguradora;
        }
        #endregion

        #region Eventos
        /// <summary>
        /// Refresca y asigna los asegurados al dataGriedView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAsegurados_Load(object sender, EventArgs e)
        {
            this.RefrescarDataGrid();
            this.DgvAsegurados.DataSource = this.aseguradora.Asegurados;
        }

        /// <summary>
        /// Permite seguir con el flujo del programa cerrando el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        /// <summary>
        /// Asinga en null el dataGriedView y reasigna la lista de asegurados
        /// </summary>
        private void RefrescarDataGrid()
        {
            this.DgvAsegurados.DataSource = null;
            this.DgvAsegurados.DataSource = this.aseguradora.Asegurados;
        }
        /// <summary>
        /// Permiete borrar a un asegurado y refrescar el dataGriedView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBorrarAsegurado_Click(object sender, EventArgs e)
        {
            Asegurado asegurado = this.DgvAsegurados.CurrentRow.DataBoundItem as Asegurado;
            if (MessageBox.Show($"Esta seguro de que desea eliminar a: \n{asegurado}", "Adevertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.aseguradora -= asegurado;
                this.RefrescarDataGrid();
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }
        }
        #endregion
    }
}
