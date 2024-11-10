namespace Clase3Escritorio
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
            numeroUno = new TextBox();
            numeroDos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            resultadoSuma = new TextBox();
            resultadoResta = new TextBox();
            resultadoMultiplicacion = new TextBox();
            resultadoDivision = new TextBox();
            btnOperar = new Button();
            label7 = new Label();
            resultadoPotencia = new TextBox();
            lblNombreCompleto = new Label();
            SuspendLayout();
            // 
            // numeroUno
            // 
            numeroUno.Location = new Point(169, 12);
            numeroUno.Name = "numeroUno";
            numeroUno.Size = new Size(100, 23);
            numeroUno.TabIndex = 0;
            // 
            // numeroDos
            // 
            numeroDos.Location = new Point(169, 53);
            numeroDos.Name = "numeroDos";
            numeroDos.Size = new Size(100, 23);
            numeroDos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 15);
            label1.Name = "label1";
            label1.Size = new Size(140, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el primer número";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 3;
            label2.Text = "Ingrese el segundo número";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 150);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 4;
            label3.Text = "Resultado de la Suma";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 190);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 5;
            label4.Text = "Resultado de la Resta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 231);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 6;
            label5.Text = "Resultado de la Multiplicación";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 267);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 7;
            label6.Text = "Resultado de la División";
            // 
            // resultadoSuma
            // 
            resultadoSuma.Enabled = false;
            resultadoSuma.Location = new Point(188, 150);
            resultadoSuma.Name = "resultadoSuma";
            resultadoSuma.Size = new Size(100, 23);
            resultadoSuma.TabIndex = 8;
            // 
            // resultadoResta
            // 
            resultadoResta.Enabled = false;
            resultadoResta.Location = new Point(188, 187);
            resultadoResta.Name = "resultadoResta";
            resultadoResta.Size = new Size(100, 23);
            resultadoResta.TabIndex = 9;
            // 
            // resultadoMultiplicacion
            // 
            resultadoMultiplicacion.Enabled = false;
            resultadoMultiplicacion.Location = new Point(188, 223);
            resultadoMultiplicacion.Name = "resultadoMultiplicacion";
            resultadoMultiplicacion.Size = new Size(100, 23);
            resultadoMultiplicacion.TabIndex = 10;
            // 
            // resultadoDivision
            // 
            resultadoDivision.Enabled = false;
            resultadoDivision.Location = new Point(188, 264);
            resultadoDivision.Name = "resultadoDivision";
            resultadoDivision.Size = new Size(100, 23);
            resultadoDivision.TabIndex = 11;
            // 
            // btnOperar
            // 
            btnOperar.Location = new Point(121, 101);
            btnOperar.Name = "btnOperar";
            btnOperar.Size = new Size(75, 23);
            btnOperar.TabIndex = 12;
            btnOperar.Text = "Operar";
            btnOperar.UseVisualStyleBackColor = true;
            btnOperar.Click += btnOperar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 306);
            label7.Name = "label7";
            label7.Size = new Size(166, 15);
            label7.TabIndex = 13;
            label7.Text = "Resultado de la Potencia a la 3";
            // 
            // resultadoPotencia
            // 
            resultadoPotencia.Enabled = false;
            resultadoPotencia.Location = new Point(188, 298);
            resultadoPotencia.Name = "resultadoPotencia";
            resultadoPotencia.Size = new Size(100, 23);
            resultadoPotencia.TabIndex = 14;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.Location = new Point(351, 20);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(32, 15);
            lblNombreCompleto.TabIndex = 15;
            lblNombreCompleto.Text = "Hola";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombreCompleto);
            Controls.Add(resultadoPotencia);
            Controls.Add(label7);
            Controls.Add(btnOperar);
            Controls.Add(resultadoDivision);
            Controls.Add(resultadoMultiplicacion);
            Controls.Add(resultadoResta);
            Controls.Add(resultadoSuma);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numeroDos);
            Controls.Add(numeroUno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox numeroUno;
        private TextBox numeroDos;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox resultadoSuma;
        private TextBox resultadoResta;
        private TextBox resultadoMultiplicacion;
        private TextBox resultadoDivision;
        private Button btnOperar;
        private Label label7;
        private TextBox resultadoPotencia;
        private Label lblNombreCompleto;
    }
}
