namespace clase5_ejercicio0._3
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
            this.buttonSaludo = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonSaludar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSaludo
            // 
            this.buttonSaludo.Location = new System.Drawing.Point(358, 218);
            this.buttonSaludo.Name = "buttonSaludo";
            this.buttonSaludo.Size = new System.Drawing.Size(143, 77);
            this.buttonSaludo.TabIndex = 0;
            this.buttonSaludo.Text = "saludo";
            this.buttonSaludo.UseVisualStyleBackColor = true;
            this.buttonSaludo.Click += new System.EventHandler(this.buttonSaludo_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(379, 66);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(125, 27);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.Text = "ingrese nombre";
            // 
            // buttonSaludar2
            // 
            this.buttonSaludar2.Location = new System.Drawing.Point(580, 218);
            this.buttonSaludar2.Name = "buttonSaludar2";
            this.buttonSaludar2.Size = new System.Drawing.Size(111, 74);
            this.buttonSaludar2.TabIndex = 2;
            this.buttonSaludar2.Text = "buttonSaludar2";
            this.buttonSaludar2.UseVisualStyleBackColor = true;
            this.buttonSaludar2.Click += new System.EventHandler(this.buttonSaludar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaludar2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonSaludo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSaludo;
        private TextBox textBoxNombre;
        private Button buttonSaludar2;
    }
}