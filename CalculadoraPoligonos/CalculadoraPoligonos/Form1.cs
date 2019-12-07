using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPoligonos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void calculaPerimetro(object sender, EventArgs e)
        {
            textBox1.Text = "Hola desde el boton de calcular perimetro";
            Console.WriteLine("Hola desde el boton de calcular perimetro");
        }

        private void CalculaArea(object sender, EventArgs e)
        {
            Console.WriteLine("Hola desde el boton de calcular area");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
