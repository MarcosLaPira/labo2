namespace visual2_parcial1
{
    partial class FrmMenu
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
            this.btnAgregarPasajero = new System.Windows.Forms.Button();
            this.btnSeleccionarViaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarPasajero
            // 
            this.btnAgregarPasajero.Location = new System.Drawing.Point(447, 64);
            this.btnAgregarPasajero.Name = "btnAgregarPasajero";
            this.btnAgregarPasajero.Size = new System.Drawing.Size(149, 71);
            this.btnAgregarPasajero.TabIndex = 0;
            this.btnAgregarPasajero.Text = "AgregarPasajero";
            this.btnAgregarPasajero.UseVisualStyleBackColor = true;
            this.btnAgregarPasajero.Click += new System.EventHandler(this.btnAgregarPasajero_Click);
            // 
            // btnSeleccionarViaje
            // 
            this.btnSeleccionarViaje.Location = new System.Drawing.Point(447, 167);
            this.btnSeleccionarViaje.Name = "btnSeleccionarViaje";
            this.btnSeleccionarViaje.Size = new System.Drawing.Size(149, 77);
            this.btnSeleccionarViaje.TabIndex = 1;
            this.btnSeleccionarViaje.Text = "Ver viajes";
            this.btnSeleccionarViaje.UseVisualStyleBackColor = true;
            this.btnSeleccionarViaje.Click += new System.EventHandler(this.btnSeleccionarViaje_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSeleccionarViaje);
            this.Controls.Add(this.btnAgregarPasajero);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAgregarPasajero;
        private Button btnSeleccionarViaje;
    }
}