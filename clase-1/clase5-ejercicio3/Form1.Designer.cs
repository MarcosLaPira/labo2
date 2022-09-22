namespace clase5_ejercicio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblEuroA = new System.Windows.Forms.Label();
            this.lblDoalrA = new System.Windows.Forms.Label();
            this.lblPesoA = new System.Windows.Forms.Label();
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.btnConvertirEuro = new System.Windows.Forms.Button();
            this.btnConvertirDolar = new System.Windows.Forms.Button();
            this.btnConvertirPeso = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.btnLookCotizacion = new System.Windows.Forms.Button();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(12, 138);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(39, 20);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Location = new System.Drawing.Point(12, 223);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(46, 20);
            this.lblDolar.TabIndex = 1;
            this.lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 315);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(39, 20);
            this.lblPeso.TabIndex = 2;
            this.lblPeso.Text = "Peso";
            // 
            // lblEuroA
            // 
            this.lblEuroA.AutoSize = true;
            this.lblEuroA.Location = new System.Drawing.Point(337, 92);
            this.lblEuroA.Name = "lblEuroA";
            this.lblEuroA.Size = new System.Drawing.Size(39, 20);
            this.lblEuroA.TabIndex = 3;
            this.lblEuroA.Text = "Euro";
            // 
            // lblDoalrA
            // 
            this.lblDoalrA.AutoSize = true;
            this.lblDoalrA.Location = new System.Drawing.Point(466, 92);
            this.lblDoalrA.Name = "lblDoalrA";
            this.lblDoalrA.Size = new System.Drawing.Size(46, 20);
            this.lblDoalrA.TabIndex = 4;
            this.lblDoalrA.Text = "Dolar";
            // 
            // lblPesoA
            // 
            this.lblPesoA.AutoSize = true;
            this.lblPesoA.Location = new System.Drawing.Point(609, 92);
            this.lblPesoA.Name = "lblPesoA";
            this.lblPesoA.Size = new System.Drawing.Size(39, 20);
            this.lblPesoA.TabIndex = 5;
            this.lblPesoA.Text = "Peso";
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Location = new System.Drawing.Point(68, 37);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(79, 20);
            this.lblCotizacion.TabIndex = 6;
            this.lblCotizacion.Text = "Cotizacion";
            // 
            // btnConvertirEuro
            // 
            this.btnConvertirEuro.Location = new System.Drawing.Point(199, 136);
            this.btnConvertirEuro.Name = "btnConvertirEuro";
            this.btnConvertirEuro.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirEuro.TabIndex = 7;
            this.btnConvertirEuro.Text = "->";
            this.btnConvertirEuro.UseVisualStyleBackColor = true;
            this.btnConvertirEuro.Click += new System.EventHandler(this.btnConvertirEuro_Click);
            // 
            // btnConvertirDolar
            // 
            this.btnConvertirDolar.Location = new System.Drawing.Point(199, 214);
            this.btnConvertirDolar.Name = "btnConvertirDolar";
            this.btnConvertirDolar.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirDolar.TabIndex = 8;
            this.btnConvertirDolar.Text = "->";
            this.btnConvertirDolar.UseVisualStyleBackColor = true;
            this.btnConvertirDolar.Click += new System.EventHandler(this.btnConvertirDolar_Click);
            // 
            // btnConvertirPeso
            // 
            this.btnConvertirPeso.Location = new System.Drawing.Point(199, 306);
            this.btnConvertirPeso.Name = "btnConvertirPeso";
            this.btnConvertirPeso.Size = new System.Drawing.Size(94, 29);
            this.btnConvertirPeso.TabIndex = 9;
            this.btnConvertirPeso.Text = "->";
            this.btnConvertirPeso.UseVisualStyleBackColor = true;
            this.btnConvertirPeso.Click += new System.EventHandler(this.btnConvertirPeso_Click);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(81, 306);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(87, 27);
            this.txtPeso.TabIndex = 10;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(81, 214);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(93, 27);
            this.txtDolar.TabIndex = 11;
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(83, 135);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(86, 27);
            this.txtEuro.TabIndex = 12;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(321, 135);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.ReadOnly = true;
            this.txtEuroAEuro.Size = new System.Drawing.Size(96, 27);
            this.txtEuroAEuro.TabIndex = 13;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(449, 136);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.ReadOnly = true;
            this.txtEuroADolar.Size = new System.Drawing.Size(99, 27);
            this.txtEuroADolar.TabIndex = 14;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(594, 135);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.ReadOnly = true;
            this.txtEuroAPeso.Size = new System.Drawing.Size(84, 27);
            this.txtEuroAPeso.TabIndex = 15;
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(321, 214);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.ReadOnly = true;
            this.txtDolarAEuro.Size = new System.Drawing.Size(96, 27);
            this.txtDolarAEuro.TabIndex = 16;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(449, 214);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.ReadOnly = true;
            this.txtDolarADolar.Size = new System.Drawing.Size(99, 27);
            this.txtDolarADolar.TabIndex = 17;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(594, 214);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.ReadOnly = true;
            this.txtDolarAPeso.Size = new System.Drawing.Size(84, 27);
            this.txtDolarAPeso.TabIndex = 18;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(321, 306);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.ReadOnly = true;
            this.txtPesoAEuro.Size = new System.Drawing.Size(96, 27);
            this.txtPesoAEuro.TabIndex = 19;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(449, 306);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.ReadOnly = true;
            this.txtPesoADolar.Size = new System.Drawing.Size(99, 27);
            this.txtPesoADolar.TabIndex = 20;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(594, 306);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.ReadOnly = true;
            this.txtPesoAPeso.Size = new System.Drawing.Size(84, 27);
            this.txtPesoAPeso.TabIndex = 21;
            // 
            // btnLookCotizacion
            // 
            this.btnLookCotizacion.Location = new System.Drawing.Point(199, 28);
            this.btnLookCotizacion.Name = "btnLookCotizacion";
            this.btnLookCotizacion.Size = new System.Drawing.Size(94, 29);
            this.btnLookCotizacion.TabIndex = 22;
            this.btnLookCotizacion.Text = "candado";
            this.btnLookCotizacion.UseVisualStyleBackColor = true;
            this.btnLookCotizacion.Click += new System.EventHandler(this.btnLookCotizacion_Click);
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(321, 28);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.Size = new System.Drawing.Size(85, 27);
            this.txtCotizacionEuro.TabIndex = 23;
            this.txtCotizacionEuro.Leave += new System.EventHandler(this.txtCotizacionEuro_Leave);
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Enabled = false;
            this.txtCotizacionDolar.Location = new System.Drawing.Point(449, 28);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.ReadOnly = true;
            this.txtCotizacionDolar.Size = new System.Drawing.Size(83, 27);
            this.txtCotizacionDolar.TabIndex = 24;
            this.txtCotizacionDolar.Text = "1";
            this.txtCotizacionDolar.Leave += new System.EventHandler(this.txtCotizacionDolar_Leave);
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(594, 28);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(84, 27);
            this.txtCotizacionPeso.TabIndex = 25;
            this.txtCotizacionPeso.Leave += new System.EventHandler(this.txtCotizacionPeso_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.btnLookCotizacion);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnConvertirPeso);
            this.Controls.Add(this.btnConvertirDolar);
            this.Controls.Add(this.btnConvertirEuro);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.lblPesoA);
            this.Controls.Add(this.lblDoalrA);
            this.Controls.Add(this.lblEuroA);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.lblEuro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblEuro;
        private Label lblDolar;
        private Label lblPeso;
        private Label lblEuroA;
        private Label lblDoalrA;
        private Label lblPesoA;
        private Label lblCotizacion;
        private Button btnConvertirEuro;
        private Button btnConvertirDolar;
        private Button btnConvertirPeso;
        private TextBox txtPeso;
        private TextBox txtDolar;
        private TextBox txtEuro;
        private TextBox txtEuroAEuro;
        private TextBox txtEuroADolar;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAEuro;
        private TextBox txtDolarADolar;
        private TextBox txtDolarAPeso;
        private TextBox txtPesoAEuro;
        private TextBox txtPesoADolar;
        private TextBox txtPesoAPeso;
        private Button btnLookCotizacion;
        private TextBox txtCotizacionEuro;
        private TextBox txtCotizacionDolar;
        private TextBox txtCotizacionPeso;
    }
}