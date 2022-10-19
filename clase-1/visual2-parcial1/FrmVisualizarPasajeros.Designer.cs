namespace visual2_parcial1
{
    partial class FrmVisualizarPasajeros
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
            this.ColumnaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPasajeros
            // 
            this.dtgPasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaApellido,
            this.ColumnaNombre,
            this.ColumnaClase});
            this.dtgPasajeros.Location = new System.Drawing.Point(260, 37);
            this.dtgPasajeros.Name = "dtgPasajeros";
            this.dtgPasajeros.RowHeadersWidth = 51;
            this.dtgPasajeros.RowTemplate.Height = 29;
            this.dtgPasajeros.Size = new System.Drawing.Size(427, 351);
            this.dtgPasajeros.TabIndex = 0;
            this.dtgPasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // ColumnaClase
            // 
            this.ColumnaClase.HeaderText = "Clase";
            this.ColumnaClase.MinimumWidth = 6;
            this.ColumnaClase.Name = "ColumnaClase";
            this.ColumnaClase.ReadOnly = true;
            this.ColumnaClase.Width = 125;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(694, 409);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmVisualizarPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dtgPasajeros);
            this.Name = "FrmVisualizarPasajeros";
            this.Text = "FrmVisualizarPasajeros";
            this.Load += new System.EventHandler(this.FrmVisualizarPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgPasajeros;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaClase;
        private Button btnVolver;
    }
}