
namespace AseguradoraForm
{
    partial class FrmEstadistica
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
            this.LblInformes = new System.Windows.Forms.Label();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblMostrarEstadistica = new System.Windows.Forms.Label();
            this.lblCalculandoEstadistica = new System.Windows.Forms.Label();
            this.pgbEstadisticas = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LblInformes
            // 
            this.LblInformes.AutoSize = true;
            this.LblInformes.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblInformes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblInformes.Location = new System.Drawing.Point(323, 46);
            this.LblInformes.Name = "LblInformes";
            this.LblInformes.Size = new System.Drawing.Size(177, 32);
            this.LblInformes.TabIndex = 4;
            this.LblInformes.Text = "ESTADISTICA";
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Location = new System.Drawing.Point(447, 647);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(108, 36);
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(256, 647);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 36);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblMostrarEstadistica
            // 
            this.lblMostrarEstadistica.AutoSize = true;
            this.lblMostrarEstadistica.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMostrarEstadistica.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblMostrarEstadistica.Location = new System.Drawing.Point(12, 245);
            this.lblMostrarEstadistica.Name = "lblMostrarEstadistica";
            this.lblMostrarEstadistica.Size = new System.Drawing.Size(0, 16);
            this.lblMostrarEstadistica.TabIndex = 12;
            // 
            // lblCalculandoEstadistica
            // 
            this.lblCalculandoEstadistica.AutoSize = true;
            this.lblCalculandoEstadistica.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCalculandoEstadistica.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCalculandoEstadistica.Location = new System.Drawing.Point(12, 124);
            this.lblCalculandoEstadistica.Name = "lblCalculandoEstadistica";
            this.lblCalculandoEstadistica.Size = new System.Drawing.Size(0, 23);
            this.lblCalculandoEstadistica.TabIndex = 14;
            // 
            // pgbEstadisticas
            // 
            this.pgbEstadisticas.BackColor = System.Drawing.Color.White;
            this.pgbEstadisticas.Location = new System.Drawing.Point(12, 171);
            this.pgbEstadisticas.Name = "pgbEstadisticas";
            this.pgbEstadisticas.Size = new System.Drawing.Size(200, 21);
            this.pgbEstadisticas.TabIndex = 15;
            // 
            // FrmEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 728);
            this.Controls.Add(this.pgbEstadisticas);
            this.Controls.Add(this.lblCalculandoEstadistica);
            this.Controls.Add(this.lblMostrarEstadistica);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.LblInformes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInformes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblInformes;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMostrarEstadistica;
        private System.Windows.Forms.Label lblCalculandoEstadistica;
        private System.Windows.Forms.ProgressBar pgbEstadisticas;
    }
}