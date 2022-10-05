namespace visual2_parcial1
{
    partial class FrmPasaporte
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
            this.mcNacimiento = new System.Windows.Forms.MonthCalendar();
            this.mcVencimientoPasaporte = new System.Windows.Forms.MonthCalendar();
            this.lblNaciemiento = new System.Windows.Forms.Label();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mcNacimiento
            // 
            this.mcNacimiento.Location = new System.Drawing.Point(35, 56);
            this.mcNacimiento.Name = "mcNacimiento";
            this.mcNacimiento.TabIndex = 0;
            // 
            // mcVencimientoPasaporte
            // 
            this.mcVencimientoPasaporte.Location = new System.Drawing.Point(465, 56);
            this.mcVencimientoPasaporte.Name = "mcVencimientoPasaporte";
            this.mcVencimientoPasaporte.TabIndex = 1;
            // 
            // lblNaciemiento
            // 
            this.lblNaciemiento.AutoSize = true;
            this.lblNaciemiento.Location = new System.Drawing.Point(94, 27);
            this.lblNaciemiento.Name = "lblNaciemiento";
            this.lblNaciemiento.Size = new System.Drawing.Size(146, 20);
            this.lblNaciemiento.TabIndex = 2;
            this.lblNaciemiento.Text = "Fecha de nacimiento";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(582, 27);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(162, 20);
            this.lblVencimiento.TabIndex = 3;
            this.lblVencimiento.Text = "Vencimiento pasaporte";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(90, 320);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(150, 27);
            this.txtNacionalidad.TabIndex = 4;
            this.txtNacionalidad.Text = "Nacionalidad";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(671, 409);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(94, 29);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FrmPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblNaciemiento);
            this.Controls.Add(this.mcVencimientoPasaporte);
            this.Controls.Add(this.mcNacimiento);
            this.Name = "FrmPasaporte";
            this.Text = "FrmPasaporte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthCalendar mcNacimiento;
        private MonthCalendar mcVencimientoPasaporte;
        private Label lblNaciemiento;
        private Label lblVencimiento;
        private TextBox txtNacionalidad;
        private Button btnSiguiente;
    }
}