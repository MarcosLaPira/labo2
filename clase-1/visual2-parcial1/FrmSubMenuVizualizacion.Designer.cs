﻿namespace visual2_parcial1
{
    partial class FrmSubMenuVizualizacion
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
            this.dtgSubmenuViajes = new System.Windows.Forms.DataGridView();
            this.ColumnaOrigen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstadoCrucero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubmenuViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSubmenuViajes
            // 
            this.dtgSubmenuViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSubmenuViajes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaOrigen,
            this.ColumnaDestino,
            this.ColumnaFechaSalida,
            this.ColumnaEstadoCrucero});
            this.dtgSubmenuViajes.Location = new System.Drawing.Point(127, 78);
            this.dtgSubmenuViajes.Name = "dtgSubmenuViajes";
            this.dtgSubmenuViajes.RowHeadersWidth = 51;
            this.dtgSubmenuViajes.RowTemplate.Height = 29;
            this.dtgSubmenuViajes.Size = new System.Drawing.Size(553, 278);
            this.dtgSubmenuViajes.TabIndex = 0;
            this.dtgSubmenuViajes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSubmenuViajes_CellContentClick);
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
            this.ColumnaFechaSalida.HeaderText = "Fecha Salida";
            this.ColumnaFechaSalida.MinimumWidth = 6;
            this.ColumnaFechaSalida.Name = "ColumnaFechaSalida";
            this.ColumnaFechaSalida.ReadOnly = true;
            this.ColumnaFechaSalida.Width = 125;
            // 
            // ColumnaEstadoCrucero
            // 
            this.ColumnaEstadoCrucero.HeaderText = "Estado";
            this.ColumnaEstadoCrucero.MinimumWidth = 6;
            this.ColumnaEstadoCrucero.Name = "ColumnaEstadoCrucero";
            this.ColumnaEstadoCrucero.ReadOnly = true;
            this.ColumnaEstadoCrucero.Width = 125;
            // 
            // FrmSubMenuVizualizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtgSubmenuViajes);
            this.Name = "FrmSubMenuVizualizacion";
            this.Text = "FrmSubMenuVizualizacion";
            this.Load += new System.EventHandler(this.FrmSubMenuVizualizacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSubmenuViajes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtgSubmenuViajes;
        private DataGridViewTextBoxColumn ColumnaOrigen;
        private DataGridViewTextBoxColumn ColumnaDestino;
        private DataGridViewTextBoxColumn ColumnaFechaSalida;
        private DataGridViewTextBoxColumn ColumnaEstadoCrucero;
    }
}