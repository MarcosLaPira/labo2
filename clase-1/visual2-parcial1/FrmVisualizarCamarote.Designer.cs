namespace visual2_parcial1
{
    partial class FrmVisualizarCamarote
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
            this.dtgPasajeros = new System.Windows.Forms.DataGridView();
            this.ColumnaApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.lblIdDeCamarote = new System.Windows.Forms.Label();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.lblClaseCamarote = new System.Windows.Forms.Label();
            this.lblPrueba = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPasajeros
            // 
            this.dtgPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaApellido,
            this.ColumnaNombre});
            this.dtgPasajeros.Location = new System.Drawing.Point(328, 64);
            this.dtgPasajeros.Name = "dtgPasajeros";
            this.dtgPasajeros.ReadOnly = true;
            this.dtgPasajeros.RowHeadersWidth = 51;
            this.dtgPasajeros.RowTemplate.Height = 29;
            this.dtgPasajeros.Size = new System.Drawing.Size(302, 291);
            this.dtgPasajeros.TabIndex = 0;
            // 
            // ColumnaApellido
            // 
            this.ColumnaApellido.HeaderText = "Apellido";
            this.ColumnaApellido.MinimumWidth = 6;
            this.ColumnaApellido.Name = "ColumnaApellido";
            this.ColumnaApellido.ReadOnly = true;
            this.ColumnaApellido.Width = 125;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.MinimumWidth = 6;
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            this.ColumnaNombre.Width = 125;
            // 
            // lblPasajeros
            // 
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(328, 27);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(70, 20);
            this.lblPasajeros.TabIndex = 1;
            this.lblPasajeros.Text = "Pasajeros";
            // 
            // lblIdDeCamarote
            // 
            this.lblIdDeCamarote.AutoSize = true;
            this.lblIdDeCamarote.Location = new System.Drawing.Point(35, 116);
            this.lblIdDeCamarote.Name = "lblIdDeCamarote";
            this.lblIdDeCamarote.Size = new System.Drawing.Size(136, 20);
            this.lblIdDeCamarote.TabIndex = 2;
            this.lblIdDeCamarote.Text = "Camarote numero :";
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(35, 176);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(158, 20);
            this.lblCantidadPasajeros.TabIndex = 3;
            this.lblCantidadPasajeros.Text = "Cantidad de Pasajeros:";
            // 
            // lblClaseCamarote
            // 
            this.lblClaseCamarote.AutoSize = true;
            this.lblClaseCamarote.Location = new System.Drawing.Point(35, 64);
            this.lblClaseCamarote.Name = "lblClaseCamarote";
            this.lblClaseCamarote.Size = new System.Drawing.Size(139, 20);
            this.lblClaseCamarote.TabIndex = 4;
            this.lblClaseCamarote.Text = "Clase del camarote:";
            // 
            // lblPrueba
            // 
            this.lblPrueba.AutoSize = true;
            this.lblPrueba.Location = new System.Drawing.Point(82, 267);
            this.lblPrueba.Name = "lblPrueba";
            this.lblPrueba.Size = new System.Drawing.Size(50, 20);
            this.lblPrueba.TabIndex = 5;
            this.lblPrueba.Text = "label1";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(655, 375);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 6;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmVisualizarCamarote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 416);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblPrueba);
            this.Controls.Add(this.lblClaseCamarote);
            this.Controls.Add(this.lblCantidadPasajeros);
            this.Controls.Add(this.lblIdDeCamarote);
            this.Controls.Add(this.lblPasajeros);
            this.Controls.Add(this.dtgPasajeros);
            this.Name = "FrmVisualizarCamarote";
            this.Text = "FrmVisualizarCamarote";
            this.Load += new System.EventHandler(this.FrmVisualizarCamarote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgPasajeros;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private Label lblPasajeros;
        private Label lblIdDeCamarote;
        private Label lblCantidadPasajeros;
        private Label lblClaseCamarote;
        private Label lblPrueba;
        private Button btnVolver;
    }
}