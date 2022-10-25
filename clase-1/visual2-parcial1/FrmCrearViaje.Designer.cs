namespace visual2_parcial1
{
    partial class FrmCrearViaje
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
            this.dtgBarcos = new System.Windows.Forms.DataGridView();
            this.ColumnaMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaCapacidadPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBarcos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mcFechaInicio = new System.Windows.Forms.MonthCalendar();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.cbPartida = new System.Windows.Forms.ComboBox();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblDestino = new System.Windows.Forms.Label();
            this.lblPartida = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBarcos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgBarcos
            // 
            this.dtgBarcos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBarcos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaMatricula,
            this.ColumnaCapacidadPersonas,
            this.ColumnaEstado});
            this.dtgBarcos.Location = new System.Drawing.Point(362, 101);
            this.dtgBarcos.Name = "dtgBarcos";
            this.dtgBarcos.RowHeadersWidth = 51;
            this.dtgBarcos.RowTemplate.Height = 29;
            this.dtgBarcos.Size = new System.Drawing.Size(419, 339);
            this.dtgBarcos.TabIndex = 0;
            this.dtgBarcos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBarcos_CellContentClick);
            // 
            // ColumnaMatricula
            // 
            this.ColumnaMatricula.HeaderText = "Matricula";
            this.ColumnaMatricula.MinimumWidth = 6;
            this.ColumnaMatricula.Name = "ColumnaMatricula";
            this.ColumnaMatricula.ReadOnly = true;
            this.ColumnaMatricula.Width = 125;
            // 
            // ColumnaCapacidadPersonas
            // 
            this.ColumnaCapacidadPersonas.HeaderText = "Capacidad personas";
            this.ColumnaCapacidadPersonas.MinimumWidth = 6;
            this.ColumnaCapacidadPersonas.Name = "ColumnaCapacidadPersonas";
            this.ColumnaCapacidadPersonas.ReadOnly = true;
            this.ColumnaCapacidadPersonas.Width = 125;
            // 
            // ColumnaEstado
            // 
            this.ColumnaEstado.HeaderText = "Estado";
            this.ColumnaEstado.MinimumWidth = 6;
            this.ColumnaEstado.Name = "ColumnaEstado";
            this.ColumnaEstado.ReadOnly = true;
            this.ColumnaEstado.Width = 125;
            // 
            // lblBarcos
            // 
            this.lblBarcos.AutoSize = true;
            this.lblBarcos.Location = new System.Drawing.Point(430, 36);
            this.lblBarcos.Name = "lblBarcos";
            this.lblBarcos.Size = new System.Drawing.Size(195, 20);
            this.lblBarcos.TabIndex = 1;
            this.lblBarcos.Text = "Nuestros barcos disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mcFechaInicio);
            this.groupBox1.Controls.Add(this.cbDestino);
            this.groupBox1.Controls.Add(this.cbPartida);
            this.groupBox1.Controls.Add(this.lblFechaInicio);
            this.groupBox1.Controls.Add(this.lblDestino);
            this.groupBox1.Controls.Add(this.lblPartida);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 449);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // mcFechaInicio
            // 
            this.mcFechaInicio.Location = new System.Drawing.Point(6, 225);
            this.mcFechaInicio.Name = "mcFechaInicio";
            this.mcFechaInicio.TabIndex = 5;
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(6, 141);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(208, 28);
            this.cbDestino.TabIndex = 4;
            // 
            // cbPartida
            // 
            this.cbPartida.FormattingEnabled = true;
            this.cbPartida.Location = new System.Drawing.Point(6, 46);
            this.cbPartida.Name = "cbPartida";
            this.cbPartida.Size = new System.Drawing.Size(208, 28);
            this.cbPartida.TabIndex = 3;
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(6, 196);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(108, 20);
            this.lblFechaInicio.TabIndex = 2;
            this.lblFechaInicio.Text = "Fecha de inicio";
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(6, 107);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(60, 20);
            this.lblDestino.TabIndex = 1;
            this.lblDestino.Text = "Destino";
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(6, 23);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(55, 20);
            this.lblPartida.TabIndex = 0;
            this.lblPartida.Text = "Partida";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(687, 539);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmCrearViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBarcos);
            this.Controls.Add(this.dtgBarcos);
            this.Name = "FrmCrearViaje";
            this.Text = "FrmCrearViaje";
            this.Load += new System.EventHandler(this.FrmCrearViaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBarcos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgBarcos;
        private DataGridViewTextBoxColumn ColumnaMatricula;
        private DataGridViewTextBoxColumn ColumnaCapacidadPersonas;
        private Label lblBarcos;
        private GroupBox groupBox1;
        private Label lblFechaInicio;
        private Label lblDestino;
        private Label lblPartida;
        private ComboBox cbDestino;
        private ComboBox cbPartida;
        private MonthCalendar mcFechaInicio;
        private DataGridViewTextBoxColumn ColumnaEstado;
        private Button btnCancelar;
    }
}