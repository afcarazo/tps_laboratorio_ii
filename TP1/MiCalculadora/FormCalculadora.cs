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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Cierra la aplicacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Realiza la conversion de decimal a binario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            this.lblResultado.Text = operando.DecimalBinario(this.lblResultado.Text);

        }

        /// <summary>
        /// Realiza la conversion de binario a decimal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            this.lblResultado.Text = operando.BinarioDecimal(this.lblResultado.Text);
        }
        /// <summary>
        /// Limpia los datos en pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// Realiza la operacion seleccionada por el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (this.EsNumero(this.txtNumero1.Text) && this.EsNumero(this.txtNumero2.Text)) {
                double resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString();
                this.lstOperaciones.Items.Add(this.txtNumero1.Text + this.cmbOperador.Text +
                                              this.txtNumero2.Text + "=" + resultado.ToString());
            }
            }

        /// <summary>
        /// Muestra todos los datos asignados por defecto al label (resultado), comboBox (operador) y asigna los valores 
        /// del desplegable del comboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Borrará los datos de los TextBox, ComboBox y Label de la pantalla.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.cmbOperador.SelectedIndex = 0;
            this.lblResultado.Text = "0";
        }


        /// <summary>
        /// recibirá los dos números y el operador para luego llamar al método Operar de Calculadora
        /// </summary>
        /// <param name="numero1">primer operando para realizar la operacion</param>
        /// <param name="numero2">segundo operando para realizar la operacion</param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado de la operacion</returns>
        private static double Operar(string numero1, string numero2,string operador)
        {
            double resultado;
            Operando operandoUno = new Operando(numero1);
            Operando operandoDos = new Operando(numero2);
            char.TryParse(operador, out char auxOperador);

            resultado=Calculadora.Operar(operandoUno, operandoDos, auxOperador);
            return resultado;
        }
        /// <summary>
        /// Permite cancelar el cierre del programa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Verifica si la cadena ingresada se trata de un numero valido
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Devuelve true si se trata de un numero de lo contrario regresa false </returns>
        private bool EsNumero(string numero)
        {
            bool esNumero = true;
            if (!int.TryParse(numero, out int auxNumero))
            {
                esNumero = false;
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Limpiar();
            }
            return esNumero;

        }
 
    }
}
