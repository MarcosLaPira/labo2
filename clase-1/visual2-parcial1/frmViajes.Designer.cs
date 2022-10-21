namespace visual2_parcial1
{
    partial class FrmViajes
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
            this.dtgViajes = new System.Windows.Forms.DataGridView();
            this.ColumnaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblViajesdispo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgViajes
            // 
            this.dtgViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaOrigen,
            this.ColumnaDestino,
            this.ColumnaFechaSalida,
            this.Estado});
            this.dtgViajes.Location = new System.Drawing.Point(85, 85);
            this.dtgViajes.Name = "dtgViajes";
            this.dtgViajes.RowHeadersWidth = 51;
            this.dtgViajes.RowTemplate.Height = 29;
            this.dtgViajes.Size = new System.Drawing.Size(553, 306);
            this.dtgViajes.TabIndex = 0;
            this.dtgViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViajes_CellContentClick);
            // 
            // ColumnaOrigen
            // 
            this.ColumnaOrigen.HeaderText = "Origen";
            this.ColumnaOrigen.MinimumWidth = 6;
            this.ColumnaOrigen.Name = "ColumnaOrigen";
            this.ColumnaOrigen.ReadOnly = true;
            this.ColumnaOrigen.Width = 125;
            // 
            // ColumnaDestino
            // 
            this.ColumnaDestino.HeaderText = "Destino";
            this.ColumnaDestino.MinimumWidth = 6;
            this.ColumnaDestino.Name = "ColumnaDestino";
            this.ColumnaDestino.ReadOnly = true;
            this.ColumnaDestino.Width = 125;
            // 
            // ColumnaFechaSalida
            // 
            this.ColumnaFechaSalida.HeaderText = "Fecha salida";
            this.ColumnaFechaSalida.MinimumWidth = 6;
            this.ColumnaFechaSalida.Name = "ColumnaFechaSalida";
            this.ColumnaFechaSalida.ReadOnly = true;
            this.ColumnaFechaSalida.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "ColumnaEstado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 125;
            // 
            // lblViajesdispo
            // 
            this.lblViajesdispo.AutoSize = true;
            this.lblViajesdispo.Location = new System.Drawing.Point(39, 28);
            this.lblViajesdispo.Name = "lblViajesdispo";
            this.lblViajesdispo.Size = new System.Drawing.Size(120, 20);
            this.lblViajesdispo.TabIndex = 1;
            this.lblViajesdispo.Text = "Seleccionar viaje";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(694, 409);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblViajesdispo);
            this.Controls.Add(this.dtgViajes);
            this.Name = "FrmViajes";
            this.Text = "FrmViajes";
            this.Load += new System.EventHandler(this.frmViajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgViajes;
        private Label lblViajesdispo;
        private DataGridViewTextBoxColumn ColumnaOrigen;
        private DataGridViewTextBoxColumn ColumnaDestino;
        private DataGridViewTextBoxColumn ColumnaFechaSalida;
        private DataGridViewTextBoxColumn Estado;
        private Button btnVolver;
    }
}