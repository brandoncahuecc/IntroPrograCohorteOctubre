namespace Clase4Escritorio
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
            btnIniciar = new Button();
            btnPagos = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(106, 122);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(135, 23);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Sesión";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(257, 120);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(133, 23);
            btnPagos.TabIndex = 1;
            btnPagos.Text = "Realizar Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPagos);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIniciar;
        private Button btnPagos;
    }
}
