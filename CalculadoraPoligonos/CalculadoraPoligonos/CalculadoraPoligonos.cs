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
        private string figuraTipo;



        public CalculadoraPoligonos()
        {
            InitializeComponent();
            figuraSelecionada = new Triangulo();
            figuraTipo = "triangulo";
        }

        private void ButtCalcularPerimetro_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show($"El perimetro de la figura {figuraTipo} es {figuraSelecionada.CalcularPerimetro()}");
           
        }

        private void ButtCalcularArea_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show($"El area de la figura {figuraTipo} es {figuraSelecionada.CalcularArea()}");

        }

        private void TabFiguras(object sender, TabControlEventArgs e)
        {

        }

        private void tabFiguras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabFiguras.SelectedIndex == 0) {
                figuraSelecionada = new Triangulo();
                figuraTipo = "triangulo";
            }
            if (tabFiguras.SelectedIndex == 1)
            {
                figuraSelecionada = new Cuadrado();
                figuraTipo = "cuadrado";
            }
            if (tabFiguras.SelectedIndex == 2)
            {
                figuraSelecionada = new Rectangulo();
                figuraTipo = "rectangulo";
            }
            if (tabFiguras.SelectedIndex == 3)
            {
                figuraSelecionada = new Pentagono();
                figuraTipo = "pentagono";
            }
            if (tabFiguras.SelectedIndex == 4)
            {
                figuraSelecionada = new Circulo();
                figuraTipo = "circulo";
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

        private void MeterLadoCuadrado(object sender, EventArgs e)
        {
            Cuadrado cuadrado = (Cuadrado)figuraSelecionada;
            cuadrado.Lado = Convert.ToDouble(textBoxLadoCuadrado.Text);
        }

        private void MeterBaseRectangulo(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)figuraSelecionada;
            rectangulo.Base = Convert.ToDouble(textBoxBaseRectangulo.Text);
        }

        private void MeterAlturaRectangulo(object sender, EventArgs e)
        {
            Rectangulo rectangulo = (Rectangulo)figuraSelecionada;
            rectangulo.Altura = Convert.ToDouble(textBoxAlturaRectangulo.Text);
        }

        private void MeterLadoPentagono(object sender, EventArgs e)
        {
            Pentagono pentagono = (Pentagono)figuraSelecionada;
            pentagono.Lado = Convert.ToDouble(textBoxLadoPentagono.Text);
        }

        private void MeterElRadioCirculo(object sender, EventArgs e)
        {
            Circulo circulo = (Circulo)figuraSelecionada;
            circulo.Radio = Convert.ToDouble(textBoxRadioCirculo.Text);
        }
    }
}
