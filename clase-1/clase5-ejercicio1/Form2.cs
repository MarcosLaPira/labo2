using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase5_ejercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        public Form2(string nombre) : this()
        {
            
            this.lblForm2.Text = $"hola {nombre}";          
        }
        public Form2(string nombre,string materiaFav) : this()
        {

            this.lblForm2.Text = $"hola {nombre}";
        }
    }
}
