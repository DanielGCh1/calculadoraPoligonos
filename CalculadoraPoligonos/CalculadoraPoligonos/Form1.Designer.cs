namespace CalculadoraPoligonos
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.butCalArea = new System.Windows.Forms.Button();
            this.butCalPerimetro = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabFiguras.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFiguras
            // 
            this.tabFiguras.Controls.Add(this.tabPage1);
            this.tabFiguras.Controls.Add(this.tabPage2);
            this.tabFiguras.Controls.Add(this.tabPage3);
            this.tabFiguras.Controls.Add(this.tabPage4);
            this.tabFiguras.Location = new System.Drawing.Point(50, 81);
            this.tabFiguras.Name = "tabFiguras";
            this.tabFiguras.SelectedIndex = 0;
            this.tabFiguras.Size = new System.Drawing.Size(501, 463);
            this.tabFiguras.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(493, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Triangulo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(493, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cuadrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(493, 437);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rectangulo";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(493, 437);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pentagono";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora de Poligonos";
            // 
            // butCalArea
            // 
            this.butCalArea.Location = new System.Drawing.Point(437, 585);
            this.butCalArea.Name = "butCalArea";
            this.butCalArea.Size = new System.Drawing.Size(131, 23);
            this.butCalArea.TabIndex = 2;
            this.butCalArea.Text = "Calcular Area";
            this.butCalArea.UseVisualStyleBackColor = true;
            this.butCalArea.Click += new System.EventHandler(this.CalculaArea);
            // 
            // butCalPerimetro
            // 
            this.butCalPerimetro.Location = new System.Drawing.Point(265, 585);
            this.butCalPerimetro.Name = "butCalPerimetro";
            this.butCalPerimetro.Size = new System.Drawing.Size(124, 23);
            this.butCalPerimetro.TabIndex = 3;
            this.butCalPerimetro.Text = "Calcular Perimetro";
            this.butCalPerimetro.UseVisualStyleBackColor = true;
            this.butCalPerimetro.Click += new System.EventHandler(this.calculaPerimetro);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 645);
            this.Controls.Add(this.butCalPerimetro);
            this.Controls.Add(this.butCalArea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabFiguras);
            this.Name = "Form1";
            this.Text = "Calculadora de poligonos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabFiguras.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabFiguras;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button butCalArea;
        private System.Windows.Forms.Button butCalPerimetro;
        private System.Windows.Forms.TextBox textBox1;
    }
}

