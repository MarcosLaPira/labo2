namespace clase5_ejercicio0._4
{
    partial class FrmSaludar2
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
            this.lblSaludo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cboEquipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.Location = new System.Drawing.Point(361, 92);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(50, 20);
            this.lblSaludo.TabIndex = 0;
            this.lblSaludo.Text = "label1";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(243, 292);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 29);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(456, 294);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 29);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cboEquipo
            // 
            this.cboEquipo.FormattingEnabled = true;
            this.cboEquipo.Items.AddRange(new object[] {
            "boca",
            "river",
            "excurcio",
            "barracas"});
            this.cboEquipo.Location = new System.Drawing.Point(275, 146);
            this.cboEquipo.Name = "cboEquipo";
            this.cboEquipo.Size = new System.Drawing.Size(218, 28);
            this.cboEquipo.TabIndex = 3;
            // 
            // FrmSaludar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboEquipo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblSaludo);
            this.Name = "FrmSaludar2";
            this.Text = "FrmSaludar2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSaludo;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cboEquipo;
    }
}