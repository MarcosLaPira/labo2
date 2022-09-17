namespace clase5_ejercicio2
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
            this.gbDetallesUsuario = new System.Windows.Forms.GroupBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.nUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbGenero = new System.Windows.Forms.GroupBox();
            this.rbNoBinario = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.gbCursos = new System.Windows.Forms.GroupBox();
            this.cbJavaScript = new System.Windows.Forms.CheckBox();
            this.cbCmas = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.tbPais = new System.Windows.Forms.ListBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.gbDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownEdad)).BeginInit();
            this.gbGenero.SuspendLayout();
            this.gbCursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDetallesUsuario
            // 
            this.gbDetallesUsuario.Controls.Add(this.lblEdad);
            this.gbDetallesUsuario.Controls.Add(this.lblApellido);
            this.gbDetallesUsuario.Controls.Add(this.lblNombre);
            this.gbDetallesUsuario.Controls.Add(this.nUpDownEdad);
            this.gbDetallesUsuario.Controls.Add(this.tbApellido);
            this.gbDetallesUsuario.Controls.Add(this.tbNombre);
            this.gbDetallesUsuario.Location = new System.Drawing.Point(81, 27);
            this.gbDetallesUsuario.Name = "gbDetallesUsuario";
            this.gbDetallesUsuario.Size = new System.Drawing.Size(319, 242);
            this.gbDetallesUsuario.TabIndex = 0;
            this.gbDetallesUsuario.TabStop = false;
            this.gbDetallesUsuario.Text = "Detalles usuario";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(42, 168);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(43, 20);
            this.lblEdad.TabIndex = 5;
            this.lblEdad.Text = "Edad";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(41, 94);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(64, 20);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // nUpDownEdad
            // 
            this.nUpDownEdad.Location = new System.Drawing.Point(34, 188);
            this.nUpDownEdad.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nUpDownEdad.Name = "nUpDownEdad";
            this.nUpDownEdad.Size = new System.Drawing.Size(125, 27);
            this.nUpDownEdad.TabIndex = 2;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(34, 116);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(125, 27);
            this.tbApellido.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(34, 51);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(125, 27);
            this.tbNombre.TabIndex = 0;
            // 
            // gbGenero
            // 
            this.gbGenero.Controls.Add(this.rbNoBinario);
            this.gbGenero.Controls.Add(this.rbFemenino);
            this.gbGenero.Controls.Add(this.rbMasculino);
            this.gbGenero.Location = new System.Drawing.Point(494, 38);
            this.gbGenero.Name = "gbGenero";
            this.gbGenero.Size = new System.Drawing.Size(250, 188);
            this.gbGenero.TabIndex = 1;
            this.gbGenero.TabStop = false;
            this.gbGenero.Text = "Genero";
            // 
            // rbNoBinario
            // 
            this.rbNoBinario.AutoSize = true;
            this.rbNoBinario.Location = new System.Drawing.Point(55, 116);
            this.rbNoBinario.Name = "rbNoBinario";
            this.rbNoBinario.Size = new System.Drawing.Size(97, 24);
            this.rbNoBinario.TabIndex = 2;
            this.rbNoBinario.TabStop = true;
            this.rbNoBinario.Text = "NoBinario";
            this.rbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(55, 71);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(95, 24);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(55, 28);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(97, 24);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // gbCursos
            // 
            this.gbCursos.Controls.Add(this.cbJavaScript);
            this.gbCursos.Controls.Add(this.cbCmas);
            this.gbCursos.Controls.Add(this.cbC);
            this.gbCursos.Location = new System.Drawing.Point(494, 253);
            this.gbCursos.Name = "gbCursos";
            this.gbCursos.Size = new System.Drawing.Size(250, 125);
            this.gbCursos.TabIndex = 4;
            this.gbCursos.TabStop = false;
            this.gbCursos.Text = "Cursos";
            // 
            // cbJavaScript
            // 
            this.cbJavaScript.AutoSize = true;
            this.cbJavaScript.Location = new System.Drawing.Point(55, 90);
            this.cbJavaScript.Name = "cbJavaScript";
            this.cbJavaScript.Size = new System.Drawing.Size(101, 24);
            this.cbJavaScript.TabIndex = 2;
            this.cbJavaScript.Text = "Java Script";
            this.cbJavaScript.UseVisualStyleBackColor = true;
            // 
            // cbCmas
            // 
            this.cbCmas.AutoSize = true;
            this.cbCmas.Location = new System.Drawing.Point(55, 60);
            this.cbCmas.Name = "cbCmas";
            this.cbCmas.Size = new System.Drawing.Size(60, 24);
            this.cbCmas.TabIndex = 1;
            this.cbCmas.Text = "C++";
            this.cbCmas.UseVisualStyleBackColor = true;
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(55, 26);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(49, 24);
            this.cbC.TabIndex = 0;
            this.cbC.Text = "C#";
            this.cbC.UseVisualStyleBackColor = true;
            // 
            // tbPais
            // 
            this.tbPais.FormattingEnabled = true;
            this.tbPais.ItemHeight = 20;
            this.tbPais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.tbPais.Location = new System.Drawing.Point(125, 319);
            this.tbPais.Name = "tbPais";
            this.tbPais.Size = new System.Drawing.Size(150, 104);
            this.tbPais.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(648, 406);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 29);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.tbPais);
            this.Controls.Add(this.gbCursos);
            this.Controls.Add(this.gbGenero);
            this.Controls.Add(this.gbDetallesUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbDetallesUsuario.ResumeLayout(false);
            this.gbDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownEdad)).EndInit();
            this.gbGenero.ResumeLayout(false);
            this.gbGenero.PerformLayout();
            this.gbCursos.ResumeLayout(false);
            this.gbCursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbDetallesUsuario;
        private Label lblEdad;
        private Label lblApellido;
        private Label lblNombre;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox gbGenero;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox gbCursos;
        private CheckBox cbJavaScript;
        private CheckBox cbCmas;
        private CheckBox cbC;
        private ListBox tbPais;
        private Button btnIngresar;
        private TextBox tbApellido;
        private TextBox tbNombre;
        private NumericUpDown nUpDownEdad;
        private RadioButton rbNoBinario;
        private RadioButton rbFemenino;
        private RadioButton rbMasculino;
    }
}