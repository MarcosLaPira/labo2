namespace clase10_ejercicio2._0_guia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKilometros = new System.Windows.Forms.Label();
            this.lblLitros = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.txtLitros = new System.Windows.Forms.TextBox();
            this.rtxResultado = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKilometros
            // 
            this.lblKilometros.AutoSize = true;
            this.lblKilometros.Location = new System.Drawing.Point(71, 58);
            this.lblKilometros.Name = "lblKilometros";
            this.lblKilometros.Size = new System.Drawing.Size(81, 20);
            this.lblKilometros.TabIndex = 0;
            this.lblKilometros.Text = "Kilometros";
            // 
            // lblLitros
            // 
            this.lblLitros.AutoSize = true;
            this.lblLitros.Location = new System.Drawing.Point(71, 169);
            this.lblLitros.Name = "lblLitros";
            this.lblLitros.Size = new System.Drawing.Size(45, 20);
            this.lblLitros.TabIndex = 1;
            this.lblLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(71, 91);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(125, 27);
            this.txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            this.txtLitros.Location = new System.Drawing.Point(71, 219);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Size = new System.Drawing.Size(125, 27);
            this.txtLitros.TabIndex = 3;
            // 
            // rtxResultado
            // 
            this.rtxResultado.Location = new System.Drawing.Point(316, 55);
            this.rtxResultado.Name = "rtxResultado";
            this.rtxResultado.ReadOnly = true;
            this.rtxResultado.Size = new System.Drawing.Size(125, 120);
            this.rtxResultado.TabIndex = 4;
            this.rtxResultado.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(326, 233);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(94, 29);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rtxResultado);
            this.Controls.Add(this.txtLitros);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.lblLitros);
            this.Controls.Add(this.lblKilometros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKilometros;
        private Label lblLitros;
        private TextBox txtKilometros;
        private TextBox txtLitros;
        private RichTextBox rtxResultado;
        private Button btnCalcular;
    }
}