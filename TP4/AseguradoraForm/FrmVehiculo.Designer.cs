
namespace AseguradoraForm
{
    partial class FrmVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TxtAnio = new System.Windows.Forms.TextBox();
            this.LblAnio = new System.Windows.Forms.Label();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.LblAsegurar = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.CmbMarca = new System.Windows.Forms.ComboBox();
            this.LblModelo = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtPatente = new System.Windows.Forms.TextBox();
            this.LblPatente = new System.Windows.Forms.Label();
            this.TxtCilindrada = new System.Windows.Forms.TextBox();
            this.LblCilidrada = new System.Windows.Forms.Label();
            this.errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAnio
            // 
            this.TxtAnio.AccessibleDescription = "";
            this.TxtAnio.Location = new System.Drawing.Point(76, 307);
            this.TxtAnio.Name = "TxtAnio";
            this.TxtAnio.Size = new System.Drawing.Size(296, 23);
            this.TxtAnio.TabIndex = 3;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAnio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAnio.Location = new System.Drawing.Point(203, 284);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(43, 17);
            this.LblAnio.TabIndex = 2;
            this.LblAnio.Text = "Año: ";
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnContinuar.Location = new System.Drawing.Point(160, 401);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(134, 38);
            this.BtnContinuar.TabIndex = 7;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click);
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(76, 183);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(296, 23);
            this.cmbVehiculo.TabIndex = 1;
            this.cmbVehiculo.SelectedIndexChanged += new System.EventHandler(this.CmbVehiculo_SelectedIndexChanged);
            // 
            // LblAsegurar
            // 
            this.LblAsegurar.AutoSize = true;
            this.LblAsegurar.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAsegurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAsegurar.Location = new System.Drawing.Point(160, 163);
            this.LblAsegurar.Name = "LblAsegurar";
            this.LblAsegurar.Size = new System.Drawing.Size(150, 17);
            this.LblAsegurar.TabIndex = 8;
            this.LblAsegurar.Text = "Que desea asegurar: ";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblMarca.Location = new System.Drawing.Point(203, 223);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(55, 17);
            this.LblMarca.TabIndex = 10;
            this.LblMarca.Text = "Marca:";
            // 
            // CmbMarca
            // 
            this.CmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMarca.FormattingEnabled = true;
            this.CmbMarca.Location = new System.Drawing.Point(76, 243);
            this.CmbMarca.Name = "CmbMarca";
            this.CmbMarca.Size = new System.Drawing.Size(296, 23);
            this.CmbMarca.TabIndex = 2;
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblModelo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblModelo.Location = new System.Drawing.Point(575, 157);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(65, 17);
            this.LblModelo.TabIndex = 12;
            this.LblModelo.Text = "Modelo:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(527, 401);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 38);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // TxtModelo
            // 
            this.TxtModelo.AccessibleDescription = "";
            this.TxtModelo.Location = new System.Drawing.Point(458, 177);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(296, 23);
            this.TxtModelo.TabIndex = 4;
            // 
            // TxtPatente
            // 
            this.TxtPatente.AccessibleDescription = "";
            this.TxtPatente.Location = new System.Drawing.Point(458, 242);
            this.TxtPatente.Name = "TxtPatente";
            this.TxtPatente.Size = new System.Drawing.Size(296, 23);
            this.TxtPatente.TabIndex = 5;
            // 
            // LblPatente
            // 
            this.LblPatente.AutoSize = true;
            this.LblPatente.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblPatente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblPatente.Location = new System.Drawing.Point(575, 222);
            this.LblPatente.Name = "LblPatente";
            this.LblPatente.Size = new System.Drawing.Size(64, 17);
            this.LblPatente.TabIndex = 14;
            this.LblPatente.Text = "Patente:";
            // 
            // TxtCilindrada
            // 
            this.TxtCilindrada.AccessibleDescription = "";
            this.TxtCilindrada.Location = new System.Drawing.Point(458, 307);
            this.TxtCilindrada.Name = "TxtCilindrada";
            this.TxtCilindrada.Size = new System.Drawing.Size(296, 23);
            this.TxtCilindrada.TabIndex = 6;
            // 
            // LblCilidrada
            // 
            this.LblCilidrada.AutoSize = true;
            this.LblCilidrada.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblCilidrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblCilidrada.Location = new System.Drawing.Point(575, 287);
            this.LblCilidrada.Name = "LblCilidrada";
            this.LblCilidrada.Size = new System.Drawing.Size(86, 17);
            this.LblCilidrada.TabIndex = 16;
            this.LblCilidrada.Text = "Cilindrada:";
            // 
            // errorProviderValidacion
            // 
            this.errorProviderValidacion.ContainerControl = this;
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 580);
            this.Controls.Add(this.TxtCilindrada);
            this.Controls.Add(this.LblCilidrada);
            this.Controls.Add(this.TxtPatente);
            this.Controls.Add(this.LblPatente);
            this.Controls.Add(this.TxtModelo);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.LblModelo);
            this.Controls.Add(this.LblMarca);
            this.Controls.Add(this.CmbMarca);
            this.Controls.Add(this.LblAsegurar);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.TxtAnio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCotizar";
            this.Load += new System.EventHandler(this.FrmCotizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAnio;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label LblAsegurar;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.ComboBox CmbMarca;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtPatente;
        private System.Windows.Forms.Label LblPatente;
        private System.Windows.Forms.TextBox TxtCilindrada;
        private System.Windows.Forms.Label LblCilidrada;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;
    }
}