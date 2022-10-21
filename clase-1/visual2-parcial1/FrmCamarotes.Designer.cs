namespace visual2_parcial1
{
    partial class FrmCamarotes
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
            this.dtgCamarotes = new System.Windows.Forms.DataGridView();
            this.idCamarote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaTipoClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidadDePersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblCamaroteLibre = new System.Windows.Forms.Label();
            this.btnCamaroteAzar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCamarotes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCamarotes
            // 
            this.dtgCamarotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCamarotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCamarote,
            this.ColumnaTipoClase,
            this.ColumnaCantidadDePersonas});
            this.dtgCamarotes.Location = new System.Drawing.Point(248, 22);
            this.dtgCamarotes.Name = "dtgCamarotes";
            this.dtgCamarotes.ReadOnly = true;
            this.dtgCamarotes.RowHeadersWidth = 51;
            this.dtgCamarotes.RowTemplate.Height = 29;
            this.dtgCamarotes.Size = new System.Drawing.Size(433, 298);
            this.dtgCamarotes.TabIndex = 0;
            this.dtgCamarotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idCamarote
            // 
            this.idCamarote.HeaderText = "id ";
            this.idCamarote.MinimumWidth = 6;
            this.idCamarote.Name = "idCamarote";
            this.idCamarote.ReadOnly = true;
            this.idCamarote.Width = 125;
            // 
            // ColumnaTipoClase
            // 
            this.ColumnaTipoClase.HeaderText = "Clase";
            this.ColumnaTipoClase.MinimumWidth = 6;
            this.ColumnaTipoClase.Name = "ColumnaTipoClase";
            this.ColumnaTipoClase.ReadOnly = true;
            this.ColumnaTipoClase.Width = 125;
            // 
            // ColumnaCantidadDePersonas
            // 
            this.ColumnaCantidadDePersonas.HeaderText = "Cantidad Pasajeros";
            this.ColumnaCantidadDePersonas.MinimumWidth = 6;
            this.ColumnaCantidadDePersonas.Name = "ColumnaCantidadDePersonas";
            this.ColumnaCantidadDePersonas.ReadOnly = true;
            this.ColumnaCantidadDePersonas.Width = 125;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 22);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(167, 20);
            this.lblMensaje.TabIndex = 1;
            this.lblMensaje.Text = "Seleccione un camarote";
            // 
            // lblCamaroteLibre
            // 
            this.lblCamaroteLibre.AutoSize = true;
            this.lblCamaroteLibre.Location = new System.Drawing.Point(12, 106);
            this.lblCamaroteLibre.Name = "lblCamaroteLibre";
            this.lblCamaroteLibre.Size = new System.Drawing.Size(156, 20);
            this.lblCamaroteLibre.TabIndex = 2;
            this.lblCamaroteLibre.Text = "Camarote libre al azar";
            // 
            // btnCamaroteAzar
            // 
            this.btnCamaroteAzar.Location = new System.Drawing.Point(32, 151);
            this.btnCamaroteAzar.Name = "btnCamaroteAzar";
            this.btnCamaroteAzar.Size = new System.Drawing.Size(94, 29);
            this.btnCamaroteAzar.TabIndex = 3;
            this.btnCamaroteAzar.Text = "Al azar";
            this.btnCamaroteAzar.UseVisualStyleBackColor = true;
            // 
            // FrmCamarotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCamaroteAzar);
            this.Controls.Add(this.lblCamaroteLibre);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.dtgCamarotes);
            this.Name = "FrmCamarotes";
            this.Text = "FrmCamarotes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCamarotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgCamarotes;
        private DataGridViewTextBoxColumn idCamarote;
        private DataGridViewTextBoxColumn ColumnaTipoClase;
        private DataGridViewTextBoxColumn ColumnaCantidadDePersonas;
        private Label lblMensaje;
        private Label lblCamaroteLibre;
        private Button btnCamaroteAzar;
    }
}