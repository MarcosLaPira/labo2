namespace visual2_parcial1
{
    partial class FrmCargarPasajero
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.gbClaseDePasajero = new System.Windows.Forms.GroupBox();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbTurista = new System.Windows.Forms.RadioButton();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbClaseDePasajero.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNacionalidad);
            this.groupBox1.Controls.Add(this.dtpVencimiento);
            this.groupBox1.Controls.Add(this.dtpNacimiento);
            this.groupBox1.Controls.Add(this.gbClaseDePasajero);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(161, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(51, 247);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(125, 27);
            this.txtNacionalidad.TabIndex = 8;
            this.txtNacionalidad.Text = "Nacionalidad";
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.CustomFormat = "yyyy - mm - dd";
            this.dtpVencimiento.Location = new System.Drawing.Point(276, 278);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(270, 27);
            this.dtpVencimiento.TabIndex = 7;
            this.dtpVencimiento.Value = new System.DateTime(2022, 10, 5, 0, 0, 0, 0);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.CustomFormat = "yyyy - mm - dd";
            this.dtpNacimiento.Location = new System.Drawing.Point(276, 225);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(270, 27);
            this.dtpNacimiento.TabIndex = 6;
            this.dtpNacimiento.Value = new System.DateTime(2022, 10, 5, 0, 0, 0, 0);
            // 
            // gbClaseDePasajero
            // 
            this.gbClaseDePasajero.Controls.Add(this.rbPremium);
            this.gbClaseDePasajero.Controls.Add(this.rbTurista);
            this.gbClaseDePasajero.Location = new System.Drawing.Point(276, 67);
            this.gbClaseDePasajero.Name = "gbClaseDePasajero";
            this.gbClaseDePasajero.Size = new System.Drawing.Size(250, 125);
            this.gbClaseDePasajero.TabIndex = 5;
            this.gbClaseDePasajero.TabStop = false;
            this.gbClaseDePasajero.Text = "ClaseDePasajero";
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Location = new System.Drawing.Point(48, 38);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(89, 24);
            this.rbPremium.TabIndex = 3;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbTurista
            // 
            this.rbTurista.AutoSize = true;
            this.rbTurista.Location = new System.Drawing.Point(48, 85);
            this.rbTurista.Name = "rbTurista";
            this.rbTurista.Size = new System.Drawing.Size(74, 24);
            this.rbTurista.TabIndex = 4;
            this.rbTurista.TabStop = true;
            this.rbTurista.Text = "Turista";
            this.rbTurista.UseVisualStyleBackColor = true;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(51, 197);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(125, 27);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.Text = "Edad";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(51, 133);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(125, 27);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(51, 67);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(53, 26);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(228, 20);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Completar los siguientes campos";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(811, 479);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(94, 29);
            this.btnSiguiente.TabIndex = 6;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // FrmCargarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 549);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCargarPasajero";
            this.Text = "CargarPasajero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbClaseDePasajero.ResumeLayout(false);
            this.gbClaseDePasajero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblMensaje;
        private GroupBox gbClaseDePasajero;
        private RadioButton rbPremium;
        private RadioButton rbTurista;
        private Button btnSiguiente;
        private TextBox txtNacionalidad;
        private DateTimePicker dtpVencimiento;
        private DateTimePicker dtpNacimiento;
    }
}