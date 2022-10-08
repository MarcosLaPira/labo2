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
            this.lblViajesdispo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViajes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgViajes
            // 
            this.dtgViajes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViajes.Location = new System.Drawing.Point(185, 171);
            this.dtgViajes.Name = "dtgViajes";
            this.dtgViajes.RowHeadersWidth = 51;
            this.dtgViajes.RowTemplate.Height = 29;
            this.dtgViajes.Size = new System.Drawing.Size(394, 251);
            this.dtgViajes.TabIndex = 0;
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
    }
}