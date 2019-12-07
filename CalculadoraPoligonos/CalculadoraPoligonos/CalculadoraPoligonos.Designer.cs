namespace CalculadoraPoligonos
{
    partial class CalculadoraPoligonos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabFiguras = new System.Windows.Forms.TabControl();
            this.tabTriangulo = new System.Windows.Forms.TabPage();
            this.textBoxLado2 = new System.Windows.Forms.TextBox();
            this.textBoxLado3 = new System.Windows.Forms.TextBox();
            this.textBoxLado1 = new System.Windows.Forms.TextBox();
            this.labLado3 = new System.Windows.Forms.Label();
            this.labLado2 = new System.Windows.Forms.Label();
            this.labLado1 = new System.Windows.Forms.Label();
            this.tabCuadrado = new System.Windows.Forms.TabPage();
            this.tabRectangulo = new System.Windows.Forms.TabPage();
            this.tabPentagono = new System.Windows.Forms.TabPage();
            this.tabCirculo = new System.Windows.Forms.TabPage();
            this.labTitulo = new System.Windows.Forms.Label();
            this.butCalcularArea = new System.Windows.Forms.Button();
            this.butCalcularPerimetro = new System.Windows.Forms.Button();
            this.tabFiguras.SuspendLayout();
            this.tabTriangulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFiguras
            // 
            this.tabFiguras.Controls.Add(this.tabTriangulo);
            this.tabFiguras.Controls.Add(this.tabCuadrado);
            this.tabFiguras.Controls.Add(this.tabRectangulo);
            this.tabFiguras.Controls.Add(this.tabPentagono);
            this.tabFiguras.Controls.Add(this.tabCirculo);
            this.tabFiguras.Location = new System.Drawing.Point(50, 81);
            this.tabFiguras.Name = "tabFiguras";
            this.tabFiguras.SelectedIndex = 0;
            this.tabFiguras.Size = new System.Drawing.Size(501, 463);
            this.tabFiguras.TabIndex = 0;
            // 
            // tabTriangulo
            // 
            this.tabTriangulo.Controls.Add(this.textBoxLado2);
            this.tabTriangulo.Controls.Add(this.textBoxLado3);
            this.tabTriangulo.Controls.Add(this.textBoxLado1);
            this.tabTriangulo.Controls.Add(this.labLado3);
            this.tabTriangulo.Controls.Add(this.labLado2);
            this.tabTriangulo.Controls.Add(this.labLado1);
            this.tabTriangulo.Location = new System.Drawing.Point(4, 22);
            this.tabTriangulo.Name = "tabTriangulo";
            this.tabTriangulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabTriangulo.Size = new System.Drawing.Size(493, 437);
            this.tabTriangulo.TabIndex = 0;
            this.tabTriangulo.Text = "Triangulo";
            this.tabTriangulo.UseVisualStyleBackColor = true;
            // 
            // textBoxLado2
            // 
            this.textBoxLado2.Location = new System.Drawing.Point(171, 70);
            this.textBoxLado2.Name = "textBoxLado2";
            this.textBoxLado2.Size = new System.Drawing.Size(100, 20);
            this.textBoxLado2.TabIndex = 5;
            // 
            // textBoxLado3
            // 
            this.textBoxLado3.Location = new System.Drawing.Point(171, 128);
            this.textBoxLado3.Name = "textBoxLado3";
            this.textBoxLado3.Size = new System.Drawing.Size(100, 20);
            this.textBoxLado3.TabIndex = 4;
            // 
            // textBoxLado1
            // 
            this.textBoxLado1.Location = new System.Drawing.Point(171, 28);
            this.textBoxLado1.Name = "textBoxLado1";
            this.textBoxLado1.Size = new System.Drawing.Size(100, 20);
            this.textBoxLado1.TabIndex = 3;
            // 
            // labLado3
            // 
            this.labLado3.AutoSize = true;
            this.labLado3.Location = new System.Drawing.Point(25, 135);
            this.labLado3.Name = "labLado3";
            this.labLado3.Size = new System.Drawing.Size(88, 13);
            this.labLado3.TabIndex = 2;
            this.labLado3.Text = "Ingrese el lado 3:";
            // 
            // labLado2
            // 
            this.labLado2.AutoSize = true;
            this.labLado2.Location = new System.Drawing.Point(25, 77);
            this.labLado2.Name = "labLado2";
            this.labLado2.Size = new System.Drawing.Size(88, 13);
            this.labLado2.TabIndex = 1;
            this.labLado2.Text = "Ingrese el lado 2:";
            // 
            // labLado1
            // 
            this.labLado1.AutoSize = true;
            this.labLado1.Location = new System.Drawing.Point(25, 28);
            this.labLado1.Name = "labLado1";
            this.labLado1.Size = new System.Drawing.Size(88, 13);
            this.labLado1.TabIndex = 0;
            this.labLado1.Text = "Ingrese el lado 1:";
            // 
            // tabCuadrado
            // 
            this.tabCuadrado.Location = new System.Drawing.Point(4, 22);
            this.tabCuadrado.Name = "tabCuadrado";
            this.tabCuadrado.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuadrado.Size = new System.Drawing.Size(493, 437);
            this.tabCuadrado.TabIndex = 1;
            this.tabCuadrado.Text = "Cuadrado";
            this.tabCuadrado.UseVisualStyleBackColor = true;
            // 
            // tabRectangulo
            // 
            this.tabRectangulo.Location = new System.Drawing.Point(4, 22);
            this.tabRectangulo.Name = "tabRectangulo";
            this.tabRectangulo.Padding = new System.Windows.Forms.Padding(3);
            this.tabRectangulo.Size = new System.Drawing.Size(493, 437);
            this.tabRectangulo.TabIndex = 2;
            this.tabRectangulo.Text = "Rectangulo";
            this.tabRectangulo.UseVisualStyleBackColor = true;
            // 
            // tabPentagono
            // 
            this.tabPentagono.Location = new System.Drawing.Point(4, 22);
            this.tabPentagono.Name = "tabPentagono";
            this.tabPentagono.Padding = new System.Windows.Forms.Padding(3);
            this.tabPentagono.Size = new System.Drawing.Size(493, 437);
            this.tabPentagono.TabIndex = 3;
            this.tabPentagono.Text = "Pentagono";
            this.tabPentagono.UseVisualStyleBackColor = true;
            // 
            // tabCirculo
            // 
            this.tabCirculo.Location = new System.Drawing.Point(4, 22);
            this.tabCirculo.Name = "tabCirculo";
            this.tabCirculo.Padding = new System.Windows.Forms.Padding(3);
            this.tabCirculo.Size = new System.Drawing.Size(493, 437);
            this.tabCirculo.TabIndex = 4;
            this.tabCirculo.Text = "Circulo";
            this.tabCirculo.UseVisualStyleBackColor = true;
            // 
            // labTitulo
            // 
            this.labTitulo.AutoSize = true;
            this.labTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitulo.Location = new System.Drawing.Point(177, 31);
            this.labTitulo.Name = "labTitulo";
            this.labTitulo.Size = new System.Drawing.Size(212, 20);
            this.labTitulo.TabIndex = 1;
            this.labTitulo.Text = "Calculadora de Poligonos";
            // 
            // butCalcularArea
            // 
            this.butCalcularArea.Location = new System.Drawing.Point(437, 585);
            this.butCalcularArea.Name = "butCalcularArea";
            this.butCalcularArea.Size = new System.Drawing.Size(131, 23);
            this.butCalcularArea.TabIndex = 2;
            this.butCalcularArea.Text = "Calcular Area";
            this.butCalcularArea.UseVisualStyleBackColor = true;
            // 
            // butCalcularPerimetro
            // 
            this.butCalcularPerimetro.Location = new System.Drawing.Point(265, 585);
            this.butCalcularPerimetro.Name = "butCalcularPerimetro";
            this.butCalcularPerimetro.Size = new System.Drawing.Size(124, 23);
            this.butCalcularPerimetro.TabIndex = 3;
            this.butCalcularPerimetro.Text = "Calcular Perimetro";
            this.butCalcularPerimetro.UseVisualStyleBackColor = true;
            // 
            // CalculadoraPoligonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 645);
            this.Controls.Add(this.butCalcularPerimetro);
            this.Controls.Add(this.butCalcularArea);
            this.Controls.Add(this.labTitulo);
            this.Controls.Add(this.tabFiguras);
            this.Name = "CalculadoraPoligonos";
            this.Text = "Calculadora de poligonos";
            this.tabFiguras.ResumeLayout(false);
            this.tabTriangulo.ResumeLayout(false);
            this.tabTriangulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabFiguras;
        private System.Windows.Forms.TabPage tabTriangulo;
        private System.Windows.Forms.TabPage tabCuadrado;
        private System.Windows.Forms.Label labTitulo;
        private System.Windows.Forms.TabPage tabRectangulo;
        private System.Windows.Forms.TabPage tabPentagono;
        private System.Windows.Forms.Button butCalcularArea;
        private System.Windows.Forms.Button butCalcularPerimetro;
        private System.Windows.Forms.TabPage tabCirculo;
        private System.Windows.Forms.Label labLado3;
        private System.Windows.Forms.Label labLado2;
        private System.Windows.Forms.Label labLado1;
        private System.Windows.Forms.TextBox textBoxLado2;
        private System.Windows.Forms.TextBox textBoxLado3;
        private System.Windows.Forms.TextBox textBoxLado1;
    }
}

