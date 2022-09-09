namespace clase5_ejercicio1
{
    partial class Form2
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
            this.lblForm2 = new System.Windows.Forms.Label();
            this.lblSaludoTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForm2
            // 
            this.lblForm2.AutoSize = true;
            this.lblForm2.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForm2.Location = new System.Drawing.Point(316, 234);
            this.lblForm2.Name = "lblForm2";
            this.lblForm2.Size = new System.Drawing.Size(128, 22);
            this.lblForm2.TabIndex = 0;
            this.lblForm2.Text = "label1";
            // 
            // lblSaludoTitulo
            // 
            this.lblSaludoTitulo.AutoSize = true;
            this.lblSaludoTitulo.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaludoTitulo.Location = new System.Drawing.Point(265, 92);
            this.lblSaludoTitulo.Name = "lblSaludoTitulo";
            this.lblSaludoTitulo.Size = new System.Drawing.Size(254, 29);
            this.lblSaludoTitulo.TabIndex = 1;
            this.lblSaludoTitulo.Text = "Hola,window form";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSaludoTitulo);
            this.Controls.Add(this.lblForm2);
            this.Name = "Form2";
            this.Text = "saludo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblForm2;
        private Label lblSaludoTitulo;
    }
}