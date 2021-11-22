
namespace AseguradoraForm
{
    partial class FrmAsegurado
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
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.LblLocalidad = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.CmbLocalidad = new System.Windows.Forms.ComboBox();
            this.CmbGenero = new System.Windows.Forms.ComboBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblApellido = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.LblNumeroDni = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.errorProviderValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnContinuar.Location = new System.Drawing.Point(161, 382);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(134, 38);
            this.BtnContinuar.TabIndex = 8;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = false;
            this.BtnContinuar.Click += new System.EventHandler(this.BtnContinuar_Click_1);
            // 
            // LblLocalidad
            // 
            this.LblLocalidad.AutoSize = true;
            this.LblLocalidad.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblLocalidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblLocalidad.Location = new System.Drawing.Point(399, 274);
            this.LblLocalidad.Name = "LblLocalidad";
            this.LblLocalidad.Size = new System.Drawing.Size(80, 17);
            this.LblLocalidad.TabIndex = 11;
            this.LblLocalidad.Text = "Localidad:";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblEmail.Location = new System.Drawing.Point(399, 189);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(55, 17);
            this.LblEmail.TabIndex = 9;
            this.LblEmail.Text = "Email: ";
            // 
            // TxtEmail
            // 
            this.TxtEmail.AccessibleDescription = "";
            this.TxtEmail.Location = new System.Drawing.Point(399, 223);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(296, 23);
            this.TxtEmail.TabIndex = 5;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelar.Location = new System.Drawing.Point(507, 382);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(134, 38);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // CmbLocalidad
            // 
            this.CmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbLocalidad.FormattingEnabled = true;
            this.CmbLocalidad.Location = new System.Drawing.Point(399, 308);
            this.CmbLocalidad.Name = "CmbLocalidad";
            this.CmbLocalidad.Size = new System.Drawing.Size(296, 23);
            this.CmbLocalidad.TabIndex = 6;
            // 
            // CmbGenero
            // 
            this.CmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbGenero.FormattingEnabled = true;
            this.CmbGenero.Location = new System.Drawing.Point(399, 140);
            this.CmbGenero.Name = "CmbGenero";
            this.CmbGenero.Size = new System.Drawing.Size(174, 23);
            this.CmbGenero.TabIndex = 4;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblGenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblGenero.Location = new System.Drawing.Point(399, 110);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(41, 17);
            this.LblGenero.TabIndex = 36;
            this.LblGenero.Text = "Sexo";
            // 
            // LblApellido
            // 
            this.LblApellido.AutoSize = true;
            this.LblApellido.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblApellido.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblApellido.Location = new System.Drawing.Point(147, 274);
            this.LblApellido.Name = "LblApellido";
            this.LblApellido.Size = new System.Drawing.Size(68, 17);
            this.LblApellido.TabIndex = 35;
            this.LblApellido.Text = "Apellido";
            // 
            // TxtApellido
            // 
            this.TxtApellido.AccessibleDescription = "";
            this.TxtApellido.Location = new System.Drawing.Point(147, 308);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(166, 23);
            this.TxtApellido.TabIndex = 3;
            // 
            // LblNumeroDni
            // 
            this.LblNumeroDni.AutoSize = true;
            this.LblNumeroDni.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNumeroDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNumeroDni.Location = new System.Drawing.Point(147, 110);
            this.LblNumeroDni.Name = "LblNumeroDni";
            this.LblNumeroDni.Size = new System.Drawing.Size(73, 17);
            this.LblNumeroDni.TabIndex = 33;
            this.LblNumeroDni.Text = "N° de DNI";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNombre.Location = new System.Drawing.Point(147, 189);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(64, 17);
            this.LblNombre.TabIndex = 32;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.AccessibleDescription = "";
            this.TxtNombre.Location = new System.Drawing.Point(147, 223);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(166, 23);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtDni
            // 
            this.TxtDni.AccessibleDescription = "";
            this.TxtDni.Location = new System.Drawing.Point(147, 140);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(166, 23);
            this.TxtDni.TabIndex = 0;
            // 
            // errorProviderValidacion
            // 
            this.errorProviderValidacion.ContainerControl = this;
            // 
            // FrmAsegurado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 580);
            this.Controls.Add(this.CmbGenero);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.LblApellido);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.LblNumeroDni);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtDni);
            this.Controls.Add(this.CmbLocalidad);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnContinuar);
            this.Controls.Add(this.LblLocalidad);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsegurado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnContinuar;
        private System.Windows.Forms.Label LblLocalidad;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.ComboBox CmbLocalidad;
        private System.Windows.Forms.ComboBox CmbGenero;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblApellido;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label LblNumeroDni;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.ErrorProvider errorProviderValidacion;
    }
}