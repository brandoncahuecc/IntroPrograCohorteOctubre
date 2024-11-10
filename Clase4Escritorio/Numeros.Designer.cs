namespace Clase4Escritorio
{
    partial class Numeros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            noUno = new TextBox();
            noDos = new TextBox();
            noTres = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            respuesta = new TextBox();
            validarMayor = new Button();
            SuspendLayout();
            // 
            // noUno
            // 
            noUno.Location = new Point(25, 27);
            noUno.Name = "noUno";
            noUno.Size = new Size(100, 23);
            noUno.TabIndex = 0;
            // 
            // noDos
            // 
            noDos.Location = new Point(153, 27);
            noDos.Name = "noDos";
            noDos.Size = new Size(100, 23);
            noDos.TabIndex = 1;
            // 
            // noTres
            // 
            noTres.Location = new Point(278, 27);
            noTres.Name = "noTres";
            noTres.Size = new Size(100, 23);
            noTres.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "No. Uno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 9);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "No. Dos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(278, 9);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "No. Tres";
            // 
            // respuesta
            // 
            respuesta.Enabled = false;
            respuesta.Location = new Point(25, 85);
            respuesta.Name = "respuesta";
            respuesta.Size = new Size(353, 23);
            respuesta.TabIndex = 6;
            // 
            // validarMayor
            // 
            validarMayor.Location = new Point(25, 56);
            validarMayor.Name = "validarMayor";
            validarMayor.Size = new Size(75, 23);
            validarMayor.TabIndex = 7;
            validarMayor.Text = "Validar";
            validarMayor.UseVisualStyleBackColor = true;
            validarMayor.Click += validarMayor_Click;
            // 
            // Numeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(validarMayor);
            Controls.Add(respuesta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(noTres);
            Controls.Add(noDos);
            Controls.Add(noUno);
            Name = "Numeros";
            Text = "Numeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox noUno;
        private TextBox noDos;
        private TextBox noTres;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox respuesta;
        private Button validarMayor;
    }
}