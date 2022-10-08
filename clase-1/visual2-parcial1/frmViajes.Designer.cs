namespace visual2_parcial1
{
    partial class frmViajes
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
            this.ColumnaEstadoBarco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblViajesdispo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgViajes
            // 
            this.dtgViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaOrigen,
            this.ColumnaDestino,
            this.ColumnaEstadoBarco});
            this.dtgViajes.Location = new System.Drawing.Point(39, 88);
            this.dtgViajes.Name = "dtgViajes";
            this.dtgViajes.RowHeadersWidth = 51;
            this.dtgViajes.RowTemplate.Height = 29;
            this.dtgViajes.Size = new System.Drawing.Size(512, 257);
            this.dtgViajes.TabIndex = 0;
            this.dtgViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViajes_CellContentClick);
            // 
            // ColumnaOrigen
            // 
            this.ColumnaOrigen.HeaderText = "Origen";
            this.ColumnaOrigen.MinimumWidth = 6;
            this.ColumnaOrigen.Name = "ColumnaOrigen";
            this.ColumnaOrigen.Width = 125;
            // 
            // ColumnaDestino
            // 
            this.ColumnaDestino.HeaderText = "Destino";
            this.ColumnaDestino.MinimumWidth = 6;
            this.ColumnaDestino.Name = "ColumnaDestino";
            this.ColumnaDestino.Width = 125;
            // 
            // ColumnaEstadoBarco
            // 
            this.ColumnaEstadoBarco.HeaderText = "Barco en puerto";
            this.ColumnaEstadoBarco.MinimumWidth = 6;
            this.ColumnaEstadoBarco.Name = "ColumnaEstadoBarco";
            this.ColumnaEstadoBarco.Width = 125;
            // 
            // lblViajesdispo
            // 
            this.lblViajesdispo.AutoSize = true;
            this.lblViajesdispo.Location = new System.Drawing.Point(39, 28);
            this.lblViajesdispo.Name = "lblViajesdispo";
            this.lblViajesdispo.Size = new System.Drawing.Size(128, 20);
            this.lblViajesdispo.TabIndex = 1;
            this.lblViajesdispo.Text = "Viajes disponibles";
            // 
            // frmViajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblViajesdispo);
            this.Controls.Add(this.dtgViajes);
            this.Name = "frmViajes";
            this.Text = "frmViajes";
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
        private DataGridViewTextBoxColumn ColumnaEstadoBarco;
    }
}