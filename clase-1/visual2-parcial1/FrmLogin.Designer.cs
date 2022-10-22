namespace visual2_parcial1
{
    partial class FrmLogin
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
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnLoguearse = new System.Windows.Forms.Button();
            this.labellblUsuario = new System.Windows.Forms.Label();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblBienvenido.Location = new System.Drawing.Point(505, 27);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(98, 18);
            this.lblBienvenido.TabIndex = 0;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(478, 120);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(125, 27);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(478, 222);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(125, 27);
            this.txtContrasena.TabIndex = 2;
            // 
            // btnLoguearse
            // 
            this.btnLoguearse.Location = new System.Drawing.Point(637, 384);
            this.btnLoguearse.Name = "btnLoguearse";
            this.btnLoguearse.Size = new System.Drawing.Size(94, 29);
            this.btnLoguearse.TabIndex = 3;
            this.btnLoguearse.Text = "Ingresar";
            this.btnLoguearse.UseVisualStyleBackColor = true;
            this.btnLoguearse.Click += new System.EventHandler(this.btnLoguearse_Click);
            // 
            // labellblUsuario
            // 
            this.labellblUsuario.AutoSize = true;
            this.labellblUsuario.Location = new System.Drawing.Point(327, 120);
            this.labellblUsuario.Name = "labellblUsuario";
            this.labellblUsuario.Size = new System.Drawing.Size(59, 20);
            this.labellblUsuario.TabIndex = 4;
            this.labellblUsuario.Text = "Usuario";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(327, 225);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(83, 20);
            this.lblContrasena.TabIndex = 5;
            this.lblContrasena.Text = "Contraseña";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 458);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.labellblUsuario);
            this.Controls.Add(this.btnLoguearse);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblBienvenido);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblBienvenido;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private Button btnLoguearse;
        private Label labellblUsuario;
        private Label lblContrasena;
    }
}