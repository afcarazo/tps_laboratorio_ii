
namespace AseguradoraForm
{
    partial class FrmPlanDePago
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAsegurar = new System.Windows.Forms.Button();
            this.lblTercerosCompleto = new System.Windows.Forms.Label();
            this.txtTercerosCompleto = new System.Windows.Forms.TextBox();
            this.lblPlan = new System.Windows.Forms.Label();
            this.txtResponsabilidadCivil = new System.Windows.Forms.TextBox();
            this.lblResponsabilidadCivil = new System.Windows.Forms.Label();
            this.CmbFormaDePago = new System.Windows.Forms.ComboBox();
            this.LblFormaDePago = new System.Windows.Forms.Label();
            this.LblSeguro = new System.Windows.Forms.Label();
            this.CmbTipoSeguro = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(514, 549);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(134, 38);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAsegurar
            // 
            this.btnAsegurar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAsegurar.Location = new System.Drawing.Point(182, 549);
            this.btnAsegurar.Name = "btnAsegurar";
            this.btnAsegurar.Size = new System.Drawing.Size(134, 38);
            this.btnAsegurar.TabIndex = 18;
            this.btnAsegurar.Text = "Asegurar";
            this.btnAsegurar.UseVisualStyleBackColor = false;
            this.btnAsegurar.Click += new System.EventHandler(this.btnAsegurar_Click);
            // 
            // lblTercerosCompleto
            // 
            this.lblTercerosCompleto.AutoSize = true;
            this.lblTercerosCompleto.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTercerosCompleto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTercerosCompleto.Location = new System.Drawing.Point(136, 270);
            this.lblTercerosCompleto.Name = "lblTercerosCompleto";
            this.lblTercerosCompleto.Size = new System.Drawing.Size(138, 17);
            this.lblTercerosCompleto.TabIndex = 17;
            this.lblTercerosCompleto.Text = "Terceros completo";
            // 
            // txtTercerosCompleto
            // 
            this.txtTercerosCompleto.AccessibleDescription = "";
            this.txtTercerosCompleto.Location = new System.Drawing.Point(136, 304);
            this.txtTercerosCompleto.Name = "txtTercerosCompleto";
            this.txtTercerosCompleto.ReadOnly = true;
            this.txtTercerosCompleto.Size = new System.Drawing.Size(296, 23);
            this.txtTercerosCompleto.TabIndex = 16;
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPlan.Location = new System.Drawing.Point(136, 135);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(144, 17);
            this.lblPlan.TabIndex = 15;
            this.lblPlan.Text = "Seleccione un plan: ";
            // 
            // txtResponsabilidadCivil
            // 
            this.txtResponsabilidadCivil.AccessibleDescription = "";
            this.txtResponsabilidadCivil.Location = new System.Drawing.Point(136, 221);
            this.txtResponsabilidadCivil.Name = "txtResponsabilidadCivil";
            this.txtResponsabilidadCivil.ReadOnly = true;
            this.txtResponsabilidadCivil.Size = new System.Drawing.Size(296, 23);
            this.txtResponsabilidadCivil.TabIndex = 14;
            // 
            // lblResponsabilidadCivil
            // 
            this.lblResponsabilidadCivil.AutoSize = true;
            this.lblResponsabilidadCivil.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResponsabilidadCivil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResponsabilidadCivil.Location = new System.Drawing.Point(136, 185);
            this.lblResponsabilidadCivil.Name = "lblResponsabilidadCivil";
            this.lblResponsabilidadCivil.Size = new System.Drawing.Size(158, 17);
            this.lblResponsabilidadCivil.TabIndex = 20;
            this.lblResponsabilidadCivil.Text = "Responsabilidad civil";
            // 
            // CmbFormaDePago
            // 
            this.CmbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFormaDePago.FormattingEnabled = true;
            this.CmbFormaDePago.Location = new System.Drawing.Point(514, 276);
            this.CmbFormaDePago.Name = "CmbFormaDePago";
            this.CmbFormaDePago.Size = new System.Drawing.Size(204, 23);
            this.CmbFormaDePago.TabIndex = 22;
            // 
            // LblFormaDePago
            // 
            this.LblFormaDePago.AutoSize = true;
            this.LblFormaDePago.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblFormaDePago.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblFormaDePago.Location = new System.Drawing.Point(569, 241);
            this.LblFormaDePago.Name = "LblFormaDePago";
            this.LblFormaDePago.Size = new System.Drawing.Size(109, 17);
            this.LblFormaDePago.TabIndex = 23;
            this.LblFormaDePago.Text = "Forma de pago";
            // 
            // LblSeguro
            // 
            this.LblSeguro.AutoSize = true;
            this.LblSeguro.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LblSeguro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSeguro.Location = new System.Drawing.Point(136, 360);
            this.LblSeguro.Name = "LblSeguro";
            this.LblSeguro.Size = new System.Drawing.Size(133, 17);
            this.LblSeguro.TabIndex = 25;
            this.LblSeguro.Text = "Seleccione seguro";
            // 
            // CmbTipoSeguro
            // 
            this.CmbTipoSeguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipoSeguro.FormattingEnabled = true;
            this.CmbTipoSeguro.Location = new System.Drawing.Point(136, 392);
            this.CmbTipoSeguro.Name = "CmbTipoSeguro";
            this.CmbTipoSeguro.Size = new System.Drawing.Size(204, 23);
            this.CmbTipoSeguro.TabIndex = 24;
            // 
            // FrmPlanDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(836, 719);
            this.Controls.Add(this.LblSeguro);
            this.Controls.Add(this.CmbTipoSeguro);
            this.Controls.Add(this.LblFormaDePago);
            this.Controls.Add(this.CmbFormaDePago);
            this.Controls.Add(this.lblResponsabilidadCivil);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsegurar);
            this.Controls.Add(this.lblTercerosCompleto);
            this.Controls.Add(this.txtTercerosCompleto);
            this.Controls.Add(this.lblPlan);
            this.Controls.Add(this.txtResponsabilidadCivil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPlanDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPlanDePago";
            this.Load += new System.EventHandler(this.FrmPlanDePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAsegurar;
        private System.Windows.Forms.Label lblTercerosCompleto;
        private System.Windows.Forms.TextBox txtTercerosCompleto;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.TextBox txtResponsabilidadCivil;
        private System.Windows.Forms.Label lblResponsabilidadCivil;
        private System.Windows.Forms.ComboBox CmbFormaDePago;
        private System.Windows.Forms.Label LblFormaDePago;
        private System.Windows.Forms.Label LblSeguro;
        private System.Windows.Forms.ComboBox CmbTipoSeguro;
    }
}