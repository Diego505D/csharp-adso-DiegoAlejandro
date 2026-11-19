namespace Tarea
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
            components = new System.ComponentModel.Container();
            lblValor = new Label();
            txtValor = new TextBox();
            lblOrigen = new Label();
            cmbOrigen = new ComboBox();
            lblDestino = new Label();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            lblResultado = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(40, 18);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(61, 25);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor: ";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(40, 58);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 1;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(316, 18);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(159, 25);
            lblOrigen.TabIndex = 2;
            lblOrigen.Text = "Unidad de origen: ";
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Location = new Point(307, 56);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(182, 33);
            cmbOrigen.TabIndex = 3;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(148, 132);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(167, 25);
            lblDestino.TabIndex = 4;
            lblDestino.Text = "Unidad de destino: ";
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Location = new Point(133, 186);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(182, 33);
            cmbDestino.TabIndex = 5;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(78, 287);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(112, 34);
            btnConvertir.TabIndex = 6;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(247, 292);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(90, 25);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(lblDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(lblOrigen);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private TextBox txtValor;
        private Label lblOrigen;
        private ComboBox cmbOrigen;
        private Label lblDestino;
        private ComboBox cmbDestino;
        private Button btnConvertir;
        private Label lblResultado;
        private ErrorProvider errorProvider1;
    }
}
