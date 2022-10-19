namespace visual2_parcial1
{
    partial class FrmVisualizarEstadisticas
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
            this.columnaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCantidadPasajero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidadPasajeros = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCamarotesTuristaDispo = new System.Windows.Forms.TextBox();
            this.lblCamarotesTuristaDispo = new System.Windows.Forms.Label();
            this.txtCamarotesPremiumDisponibles = new System.Windows.Forms.TextBox();
            this.txtEstadoCrucero = new System.Windows.Forms.TextBox();
            this.txtFechaSalida = new System.Windows.Forms.TextBox();
            this.txtCantidadPasajeros = new System.Windows.Forms.TextBox();
            this.lblCamarotesPremiumDispo = new System.Windows.Forms.Label();
            this.lblEstadoCrucero = new System.Windows.Forms.Label();
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.lblCamarotes = new System.Windows.Forms.Label();
            this.btnListaPasajeros = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCamarotes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCamarotes
            // 
            this.dtgCamarotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCamarotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaId,
            this.ColumnaClase,
            this.ColumnaCantidadPasajero});
            this.dtgCamarotes.Location = new System.Drawing.Point(352, 43);
            this.dtgCamarotes.Name = "dtgCamarotes";
            this.dtgCamarotes.RowHeadersWidth = 51;
            this.dtgCamarotes.RowTemplate.Height = 29;
            this.dtgCamarotes.Size = new System.Drawing.Size(426, 229);
            this.dtgCamarotes.TabIndex = 0;
            this.dtgCamarotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCamarotes_CellContentClick);
            // 
            // columnaId
            // 
            this.columnaId.HeaderText = "Id";
            this.columnaId.MinimumWidth = 6;
            this.columnaId.Name = "columnaId";
            this.columnaId.ReadOnly = true;
            this.columnaId.Width = 125;
            // 
            // ColumnaClase
            // 
            this.ColumnaClase.HeaderText = "Clase";
            this.ColumnaClase.MinimumWidth = 6;
            this.ColumnaClase.Name = "ColumnaClase";
            this.ColumnaClase.ReadOnly = true;
            this.ColumnaClase.Width = 125;
            // 
            // ColumnaCantidadPasajero
            // 
            this.ColumnaCantidadPasajero.HeaderText = "Cantidad Pasajeros";
            this.ColumnaCantidadPasajero.MinimumWidth = 6;
            this.ColumnaCantidadPasajero.Name = "ColumnaCantidadPasajero";
            this.ColumnaCantidadPasajero.ReadOnly = true;
            this.ColumnaCantidadPasajero.Width = 125;
            // 
            // lblCantidadPasajeros
            // 
            this.lblCantidadPasajeros.AutoSize = true;
            this.lblCantidadPasajeros.Location = new System.Drawing.Point(15, 31);
            this.lblCantidadPasajeros.Name = "lblCantidadPasajeros";
            this.lblCantidadPasajeros.Size = new System.Drawing.Size(134, 20);
            this.lblCantidadPasajeros.TabIndex = 1;
            this.lblCantidadPasajeros.Text = "Cantidad Pasajeros";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCamarotesTuristaDispo);
            this.groupBox1.Controls.Add(this.lblCamarotesTuristaDispo);
            this.groupBox1.Controls.Add(this.txtCamarotesPremiumDisponibles);
            this.groupBox1.Controls.Add(this.txtEstadoCrucero);
            this.groupBox1.Controls.Add(this.txtFechaSalida);
            this.groupBox1.Controls.Add(this.txtCantidadPasajeros);
            this.groupBox1.Controls.Add(this.lblCamarotesPremiumDispo);
            this.groupBox1.Controls.Add(this.lblEstadoCrucero);
            this.groupBox1.Controls.Add(this.lblFechaSalida);
            this.groupBox1.Controls.Add(this.lblCantidadPasajeros);
            this.groupBox1.Location = new System.Drawing.Point(33, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 415);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtCamarotesTuristaDispo
            // 
            this.txtCamarotesTuristaDispo.Location = new System.Drawing.Point(15, 382);
            this.txtCamarotesTuristaDispo.Name = "txtCamarotesTuristaDispo";
            this.txtCamarotesTuristaDispo.ReadOnly = true;
            this.txtCamarotesTuristaDispo.Size = new System.Drawing.Size(125, 27);
            this.txtCamarotesTuristaDispo.TabIndex = 9;
            // 
            // lblCamarotesTuristaDispo
            // 
            this.lblCamarotesTuristaDispo.AutoSize = true;
            this.lblCamarotesTuristaDispo.Location = new System.Drawing.Point(15, 341);
            this.lblCamarotesTuristaDispo.Name = "lblCamarotesTuristaDispo";
            this.lblCamarotesTuristaDispo.Size = new System.Drawing.Size(210, 20);
            this.lblCamarotesTuristaDispo.TabIndex = 5;
            this.lblCamarotesTuristaDispo.Text = "Camarotes Turista Disponibles";
            // 
            // txtCamarotesPremiumDisponibles
            // 
            this.txtCamarotesPremiumDisponibles.Location = new System.Drawing.Point(15, 295);
            this.txtCamarotesPremiumDisponibles.Name = "txtCamarotesPremiumDisponibles";
            this.txtCamarotesPremiumDisponibles.ReadOnly = true;
            this.txtCamarotesPremiumDisponibles.Size = new System.Drawing.Size(125, 27);
            this.txtCamarotesPremiumDisponibles.TabIndex = 8;
            // 
            // txtEstadoCrucero
            // 
            this.txtEstadoCrucero.Location = new System.Drawing.Point(15, 214);
            this.txtEstadoCrucero.Name = "txtEstadoCrucero";
            this.txtEstadoCrucero.ReadOnly = true;
            this.txtEstadoCrucero.Size = new System.Drawing.Size(125, 27);
            this.txtEstadoCrucero.TabIndex = 7;
            // 
            // txtFechaSalida
            // 
            this.txtFechaSalida.Location = new System.Drawing.Point(15, 131);
            this.txtFechaSalida.Name = "txtFechaSalida";
            this.txtFechaSalida.ReadOnly = true;
            this.txtFechaSalida.Size = new System.Drawing.Size(125, 27);
            this.txtFechaSalida.TabIndex = 6;
            // 
            // txtCantidadPasajeros
            // 
            this.txtCantidadPasajeros.Location = new System.Drawing.Point(15, 54);
            this.txtCantidadPasajeros.Name = "txtCantidadPasajeros";
            this.txtCantidadPasajeros.ReadOnly = true;
            this.txtCantidadPasajeros.Size = new System.Drawing.Size(125, 27);
            this.txtCantidadPasajeros.TabIndex = 5;
            // 
            // lblCamarotesPremiumDispo
            // 
            this.lblCamarotesPremiumDispo.AutoSize = true;
            this.lblCamarotesPremiumDispo.Location = new System.Drawing.Point(15, 260);
            this.lblCamarotesPremiumDispo.Name = "lblCamarotesPremiumDispo";
            this.lblCamarotesPremiumDispo.Size = new System.Drawing.Size(225, 20);
            this.lblCamarotesPremiumDispo.TabIndex = 4;
            this.lblCamarotesPremiumDispo.Text = "Camarotes Premium Disponibles";
            // 
            // lblEstadoCrucero
            // 
            this.lblEstadoCrucero.AutoSize = true;
            this.lblEstadoCrucero.Location = new System.Drawing.Point(15, 179);
            this.lblEstadoCrucero.Name = "lblEstadoCrucero";
            this.lblEstadoCrucero.Size = new System.Drawing.Size(109, 20);
            this.lblEstadoCrucero.TabIndex = 3;
            this.lblEstadoCrucero.Text = "Estado Crucero";
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(15, 97);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(92, 20);
            this.lblFechaSalida.TabIndex = 2;
            this.lblFechaSalida.Text = "Fecha Salida";
            // 
            // lblCamarotes
            // 
            this.lblCamarotes.AutoSize = true;
            this.lblCamarotes.Location = new System.Drawing.Point(500, 12);
            this.lblCamarotes.Name = "lblCamarotes";
            this.lblCamarotes.Size = new System.Drawing.Size(80, 20);
            this.lblCamarotes.TabIndex = 3;
            this.lblCamarotes.Text = "Camarotes";
            // 
            // btnListaPasajeros
            // 
            this.btnListaPasajeros.Location = new System.Drawing.Point(393, 307);
            this.btnListaPasajeros.Name = "btnListaPasajeros";
            this.btnListaPasajeros.Size = new System.Drawing.Size(130, 78);
            this.btnListaPasajeros.TabIndex = 4;
            this.btnListaPasajeros.Text = "Ver lista detellada Pasajeros";
            this.btnListaPasajeros.UseVisualStyleBackColor = true;
            this.btnListaPasajeros.Click += new System.EventHandler(this.btnListaPasajeros_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(684, 409);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 29);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmVisualizarEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnListaPasajeros);
            this.Controls.Add(this.lblCamarotes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgCamarotes);
            this.Name = "FrmVisualizarEstadisticas";
            this.Text = "FrmVisualizarEstadisticas";
            this.Load += new System.EventHandler(this.FrmVisualizarEstadisticas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCamarotes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgCamarotes;
        private Label lblCantidadPasajeros;
        private GroupBox groupBox1;
        private TextBox txtCamarotesPremiumDisponibles;
        private TextBox txtEstadoCrucero;
        private TextBox txtFechaSalida;
        private TextBox txtCantidadPasajeros;
        private Label lblCamarotesPremiumDispo;
        private Label lblEstadoCrucero;
        private Label lblFechaSalida;
        private Label lblCamarotes;
        private Label lblCamarotesTuristaDispo;
        private TextBox txtCamarotesTuristaDispo;
        private Button btnListaPasajeros;
        private DataGridViewTextBoxColumn columnaId;
        private DataGridViewTextBoxColumn ColumnaClase;
        private DataGridViewTextBoxColumn ColumnaCantidadPasajero;
        private Button btnVolver;
    }
}