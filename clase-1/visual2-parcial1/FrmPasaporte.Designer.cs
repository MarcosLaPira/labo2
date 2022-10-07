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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mcNacimiento
            // 
            this.mcNacimiento.Location = new System.Drawing.Point(35, 77);
            this.mcNacimiento.Name = "mcNacimiento";
            this.mcNacimiento.TabIndex = 0;
            // 
            // mcVencimientoPasaporte
            // 
            this.mcVencimientoPasaporte.Location = new System.Drawing.Point(454, 77);
            this.mcVencimientoPasaporte.Name = "mcVencimientoPasaporte";
            this.mcVencimientoPasaporte.TabIndex = 1;
            // 
            // lblNaciemiento
            // 
            this.lblNaciemiento.AutoSize = true;
            this.lblNaciemiento.Location = new System.Drawing.Point(94, 48);
            this.lblNaciemiento.Name = "lblNaciemiento";
            this.lblNaciemiento.Size = new System.Drawing.Size(146, 20);
            this.lblNaciemiento.TabIndex = 2;
            this.lblNaciemiento.Text = "Fecha de nacimiento";
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(517, 48);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(162, 20);
            this.lblVencimiento.TabIndex = 3;
            this.lblVencimiento.Text = "Vencimiento pasaporte";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(188, 411);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(125, 27);
            this.txtNacionalidad.TabIndex = 4;
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(188, 312);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(188, 367);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(35, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 20);
            this.lblInfo.TabIndex = 8;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(611, 312);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(86, 27);
            this.txtEdad.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(85, 312);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(85, 374);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(85, 418);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(98, 20);
            this.lblNacionalidad.TabIndex = 12;
            this.lblNacionalidad.Text = "Nacionalidad";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(480, 319);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 13;
            this.lblEdad.Text = "Edad";
            // 
            // FrmPasaporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.lblVencimiento);
            this.Controls.Add(this.lblNaciemiento);
            this.Controls.Add(this.mcVencimientoPasaporte);
            this.Controls.Add(this.mcNacimiento);
            this.Name = "FrmPasaporte";
            this.Text = "FrmPasaporte";
            this.Load += new System.EventHandler(this.FrmPasaporte_Load);
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
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblInfo;
        private TextBox txtEdad;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblNacionalidad;
        private Label lblEdad;
    }
}