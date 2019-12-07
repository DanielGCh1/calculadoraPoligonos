using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNA.Poligonos;

namespace CalculadoraPoligonos
{
    

    public partial class CalculadoraPoligonos : Form
    {
        private Figura figuraSelecionada;



        public CalculadoraPoligonos()
        {
            InitializeComponent();
            figuraSelecionada = new Triangulo();
        }

        private void ButtCalcularPerimetro_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show($"El Perimetro de la figura es {figuraSelecionada.CalcularPerimetro()}");
           
        }

        private void ButtCalcularArea_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show($"El Perimetro de la figura es {figuraSelecionada.CalcularArea()}");

        }

        private void TabFiguras(object sender, TabControlEventArgs e)
        {

        }

        private void tabFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabFiguras.SelectedIndex == 0) {
                figuraSelecionada = new Triangulo();
            }
            if (tabFiguras.SelectedIndex == 1)
            {
                figuraSelecionada = new Cuadrado();
            }
            if (tabFiguras.SelectedIndex == 2)
            {
                figuraSelecionada = new Rectangulo();
            }
            if (tabFiguras.SelectedIndex == 3)
            {
                figuraSelecionada = new Pentagono();
            }
            if (tabFiguras.SelectedIndex == 4)
            {
                figuraSelecionada = new Circulo();
            }
        }

        private void MeterLado1Triangulo(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo) figuraSelecionada;
            triangulo.Lado1 = Convert.ToDouble(textBoxLado1.Text);
        }

        private void MeterLado2Triangulo(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSelecionada;
            triangulo.Lado2 = Convert.ToDouble(textBoxLado2.Text);
        }


        private void MeterLado3Triangulo(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSelecionada;
            triangulo.Lado3 = Convert.ToDouble(textBoxLado3.Text);
        }

        private void MeterBaseTriangulo(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSelecionada;
            triangulo.Base = Convert.ToDouble(textBoxBaseTriangulo.Text);
        }

        private void MeterAlturaTriangulo(object sender, EventArgs e)
        {
            Triangulo triangulo = (Triangulo)figuraSelecionada;
            triangulo.Altura = Convert.ToDouble(textBoxAlturaTriangulo.Text);
        }
    }
}
