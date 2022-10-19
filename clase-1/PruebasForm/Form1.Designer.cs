namespace PruebasForm
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
            this.btnSubmenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubmenu
            // 
            this.btnSubmenu.Location = new System.Drawing.Point(326, 125);
            this.btnSubmenu.Name = "btnSubmenu";
            this.btnSubmenu.Size = new System.Drawing.Size(94, 29);
            this.btnSubmenu.TabIndex = 0;
            this.btnSubmenu.Text = "submenu";
            this.btnSubmenu.UseVisualStyleBackColor = true;
            this.btnSubmenu.Click += new System.EventHandler(this.btnSubmenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmenu);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnSubmenu;
    }
}