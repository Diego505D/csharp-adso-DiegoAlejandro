namespace Practica2
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            nudEdad = new NumericUpDown();
            cmbPrograma = new ComboBox();
            rdbManana = new RadioButton();
            rdbTarde = new RadioButton();
            chkTerminos = new CheckBox();
            btnInscribir = new Button();
            lstInscritos = new ListBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(71, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(166, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(253, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(253, 98);
            nudEdad.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(180, 31);
            nudEdad.TabIndex = 2;
            nudEdad.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // cmbPrograma
            // 
            cmbPrograma.FormattingEnabled = true;
            cmbPrograma.Items.AddRange(new object[] { "ADSO", "Multimedia", "Contabilidad" });
            cmbPrograma.Location = new Point(253, 165);
            cmbPrograma.Name = "cmbPrograma";
            cmbPrograma.Size = new Size(182, 33);
            cmbPrograma.TabIndex = 3;
            // 
            // rdbManana
            // 
            rdbManana.AutoSize = true;
            rdbManana.Location = new Point(253, 235);
            rdbManana.Name = "rdbManana";
            rdbManana.Size = new Size(100, 29);
            rdbManana.TabIndex = 4;
            rdbManana.TabStop = true;
            rdbManana.Text = "Mañana";
            rdbManana.UseVisualStyleBackColor = true;
            rdbManana.CheckedChanged += rdbManana_CheckedChanged;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(400, 236);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(79, 29);
            rdbTarde.TabIndex = 5;
            rdbTarde.TabStop = true;
            rdbTarde.Text = "Tarde";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Location = new Point(513, 236);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(198, 29);
            chkTerminos.TabIndex = 6;
            chkTerminos.Text = "Acepto los términos";
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(323, 332);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(112, 34);
            btnInscribir.TabIndex = 7;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // lstInscritos
            // 
            lstInscritos.FormattingEnabled = true;
            lstInscritos.Location = new Point(492, 294);
            lstInscritos.Name = "lstInscritos";
            lstInscritos.Size = new Size(180, 129);
            lstInscritos.TabIndex = 8;
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
            Controls.Add(lstInscritos);
            Controls.Add(btnInscribir);
            Controls.Add(chkTerminos);
            Controls.Add(rdbTarde);
            Controls.Add(rdbManana);
            Controls.Add(cmbPrograma);
            Controls.Add(nudEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private NumericUpDown nudEdad;
        private ComboBox cmbPrograma;
        private RadioButton rdbManana;
        private RadioButton rdbTarde;
        private CheckBox chkTerminos;
        private Button btnInscribir;
        private ListBox lstInscritos;
        private ErrorProvider errorProvider1;
    }
}
