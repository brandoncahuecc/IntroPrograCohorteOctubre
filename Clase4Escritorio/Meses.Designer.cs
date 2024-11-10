namespace Clase4Escritorio
{
    partial class Meses
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
            txtMes = new TextBox();
            label1 = new Label();
            ejecutar = new Button();
            SuspendLayout();
            // 
            // txtMes
            // 
            txtMes.Location = new Point(10, 30);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 12);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingrese el número del mes";
            // 
            // ejecutar
            // 
            ejecutar.Location = new Point(10, 59);
            ejecutar.Name = "ejecutar";
            ejecutar.Size = new Size(75, 23);
            ejecutar.TabIndex = 2;
            ejecutar.Text = "Ver Mes";
            ejecutar.UseVisualStyleBackColor = true;
            ejecutar.Click += ejecutar_Click;
            // 
            // Meses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ejecutar);
            Controls.Add(label1);
            Controls.Add(txtMes);
            Name = "Meses";
            Text = "Meses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMes;
        private Label label1;
        private Button ejecutar;
    }
}