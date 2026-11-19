namespace Practica1
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
            lblPregunta = new Label();
            txtNombre = new TextBox();
            btnSaludar = new Button();
            lblSaludo = new Label();
            lblNumero1 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            lblNumero2 = new Label();
            txtResultado = new TextBox();
            lblResultado = new Label();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.ForeColor = Color.FromArgb(128, 128, 255);
            lblPregunta.Location = new Point(57, 55);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(288, 45);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "¿Como te llamas?";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 16F);
            txtNombre.Location = new Point(57, 155);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 50);
            txtNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.Font = new Font("Segoe UI", 9F);
            btnSaludar.Location = new Point(251, 171);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(112, 34);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(96, 282);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(0, 25);
            lblSaludo.TabIndex = 3;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(37, 346);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(87, 25);
            lblNumero1.TabIndex = 4;
            lblNumero1.Text = "Numero1";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(130, 346);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(150, 31);
            txtNumero1.TabIndex = 5;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(130, 452);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(150, 31);
            txtNumero2.TabIndex = 7;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(37, 455);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(87, 25);
            lblNumero2.TabIndex = 6;
            lblNumero2.Text = "Numero2";
            // 
            // txtResultado
            // 
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(130, 527);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 9;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(37, 533);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(385, 395);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(112, 34);
            btnSumar.TabIndex = 10;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(385, 510);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(112, 34);
            btnRestar.TabIndex = 11;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(563, 395);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(112, 34);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(563, 510);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(112, 34);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 634);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtResultado);
            Controls.Add(lblResultado);
            Controls.Add(txtNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Controls.Add(lblSaludo);
            Controls.Add(btnSaludar);
            Controls.Add(txtNombre);
            Controls.Add(lblPregunta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private TextBox txtNombre;
        private Button btnSaludar;
        private Label lblSaludo;
        private Label lblNumero1;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Label lblNumero2;
        private TextBox txtResultado;
        private Label lblResultado;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}
