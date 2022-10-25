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
            this.btnSeleccionarViaje = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnCrearViaje = new System.Windows.Forms.Button();
            this.btnEstadisticasHistoricas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSeleccionarViaje
            // 
            this.btnSeleccionarViaje.Location = new System.Drawing.Point(501, 251);
            this.btnSeleccionarViaje.Name = "btnSeleccionarViaje";
            this.btnSeleccionarViaje.Size = new System.Drawing.Size(214, 68);
            this.btnSeleccionarViaje.TabIndex = 1;
            this.btnSeleccionarViaje.Text = "Agregar nuevo pasajero";
            this.btnSeleccionarViaje.UseVisualStyleBackColor = true;
            this.btnSeleccionarViaje.Click += new System.EventHandler(this.btnSeleccionarViaje_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(501, 123);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(213, 68);
            this.btnVisualizar.TabIndex = 2;
            this.btnVisualizar.Text = "Visualizar viajes";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnCrearViaje
            // 
            this.btnCrearViaje.Location = new System.Drawing.Point(218, 131);
            this.btnCrearViaje.Name = "btnCrearViaje";
            this.btnCrearViaje.Size = new System.Drawing.Size(150, 41);
            this.btnCrearViaje.TabIndex = 3;
            this.btnCrearViaje.Text = "Crear nuevo viaje";
            this.btnCrearViaje.UseVisualStyleBackColor = true;
            this.btnCrearViaje.Click += new System.EventHandler(this.btnCrearViaje_Click);
            // 
            // btnEstadisticasHistoricas
            // 
            this.btnEstadisticasHistoricas.Location = new System.Drawing.Point(201, 266);
            this.btnEstadisticasHistoricas.Name = "btnEstadisticasHistoricas";
            this.btnEstadisticasHistoricas.Size = new System.Drawing.Size(218, 38);
            this.btnEstadisticasHistoricas.TabIndex = 4;
            this.btnEstadisticasHistoricas.Text = "Estadisticas historicas";
            this.btnEstadisticasHistoricas.UseVisualStyleBackColor = true;
            this.btnEstadisticasHistoricas.Click += new System.EventHandler(this.btnEstadisticasHistoricas_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEstadisticasHistoricas);
            this.Controls.Add(this.btnCrearViaje);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnSeleccionarViaje);
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnSeleccionarViaje;
        private Button btnVisualizar;
        private Button btnCrearViaje;
        private Button btnEstadisticasHistoricas;
    }
}