
namespace AseguradoraForm
{
    partial class FrmAsegurados
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
            this.DgvAsegurados = new System.Windows.Forms.DataGridView();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblAsegurados = new System.Windows.Forms.Label();
            this.BtnBorrarAsegurado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsegurados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAsegurados
            // 
            this.DgvAsegurados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAsegurados.Location = new System.Drawing.Point(71, 116);
            this.DgvAsegurados.Name = "DgvAsegurados";
            this.DgvAsegurados.ReadOnly = true;
            this.DgvAsegurados.RowTemplate.Height = 25;
            this.DgvAsegurados.Size = new System.Drawing.Size(717, 515);
            this.DgvAsegurados.TabIndex = 0;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAceptar.Location = new System.Drawing.Point(654, 650);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(134, 35);
            this.BtnAceptar.TabIndex = 1;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblAsegurados
            // 
            this.LblAsegurados.AutoSize = true;
            this.LblAsegurados.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblAsegurados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAsegurados.Location = new System.Drawing.Point(71, 60);
            this.LblAsegurados.Name = "LblAsegurados";
            this.LblAsegurados.Size = new System.Drawing.Size(165, 32);
            this.LblAsegurados.TabIndex = 5;
            this.LblAsegurados.Text = "Asegurados:";
            // 
            // BtnBorrarAsegurado
            // 
            this.BtnBorrarAsegurado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.BtnBorrarAsegurado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrarAsegurado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnBorrarAsegurado.Location = new System.Drawing.Point(71, 650);
            this.BtnBorrarAsegurado.Name = "BtnBorrarAsegurado";
            this.BtnBorrarAsegurado.Size = new System.Drawing.Size(134, 35);
            this.BtnBorrarAsegurado.TabIndex = 6;
            this.BtnBorrarAsegurado.Text = "Eliminar asegurado";
            this.BtnBorrarAsegurado.UseVisualStyleBackColor = true;
            this.BtnBorrarAsegurado.Click += new System.EventHandler(this.BtnBorrarAsegurado_Click);
            // 
            // FrmAsegurados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 719);
            this.Controls.Add(this.BtnBorrarAsegurado);
            this.Controls.Add(this.LblAsegurados);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.DgvAsegurados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAsegurados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAsegurados";
            this.Load += new System.EventHandler(this.FrmAsegurados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAsegurados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAsegurados;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblAsegurados;
        private System.Windows.Forms.Button BtnBorrarAsegurado;
    }
}