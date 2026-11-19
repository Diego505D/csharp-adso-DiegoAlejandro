namespace Reto
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
            lblTitular = new Label();
            lblSaldo = new Label();
            nudMonto = new NumericUpDown();
            btnDepositar = new Button();
            btnRetirar = new Button();
            lstMovimientos = new ListBox();
            lblCantidad = new Label();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.BackColor = SystemColors.ButtonShadow;
            lblTitular.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitular.Location = new Point(12, 9);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(114, 32);
            lblTitular.TabIndex = 0;
            lblTitular.Text = "Titular: ";
            lblTitular.Click += lblTitular_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.BackColor = SystemColors.ActiveBorder;
            lblSaldo.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSaldo.Location = new Point(367, 9);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(92, 36);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Saldo";
            // 
            // nudMonto
            // 
            nudMonto.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nudMonto.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMonto.Location = new Point(355, 143);
            nudMonto.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudMonto.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(180, 30);
            nudMonto.TabIndex = 2;
            nudMonto.ThousandsSeparator = true;
            nudMonto.Value = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.ValueChanged += nudMonto_ValueChanged;
            // 
            // btnDepositar
            // 
            btnDepositar.BackColor = Color.FromArgb(255, 255, 128);
            btnDepositar.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepositar.Location = new Point(12, 318);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(112, 34);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = false;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.BackColor = Color.Thistle;
            btnRetirar.Font = new Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRetirar.Location = new Point(167, 318);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(112, 34);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = false;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // lstMovimientos
            // 
            lstMovimientos.BackColor = Color.FromArgb(224, 224, 224);
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(12, 202);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(383, 104);
            lstMovimientos.TabIndex = 5;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = SystemColors.ActiveBorder;
            lblCantidad.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(12, 147);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(330, 26);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad a depositar o retirar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(lblCantidad);
            Controls.Add(lstMovimientos);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Controls.Add(nudMonto);
            Controls.Add(lblSaldo);
            Controls.Add(lblTitular);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitular;
        private Label lblSaldo;
        private NumericUpDown nudMonto;
        private Button btnDepositar;
        private Button btnRetirar;
        private ListBox lstMovimientos;
        private Label lblCantidad;
    }
}
