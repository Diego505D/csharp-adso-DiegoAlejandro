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
            components = new System.ComponentModel.Container();
            dgvContacto = new DataGridView();
            txtBuscar = new TextBox();
            lblTotal = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNombre = new TextBox();
            btnAgregar = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnEliminar = new Button();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContacto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvContacto
            // 
            dgvContacto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacto.Location = new Point(22, 12);
            dgvContacto.Name = "dgvContacto";
            dgvContacto.Size = new Size(385, 153);
            dgvContacto.TabIndex = 0;
            dgvContacto.CellContentClick += dgvContacto_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(454, 24);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(123, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(618, 27);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "label1";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(191, 224);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(123, 23);
            txtTelefono.TabIndex = 3;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(339, 224);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(123, 23);
            txtCorreo.TabIndex = 4;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(34, 224);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(123, 23);
            txtNombre.TabIndex = 5;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(502, 224);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(476, 133);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(101, 23);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(634, 133);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 48);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guarda Cambios";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtNombre);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(lblTotal);
            Controls.Add(txtBuscar);
            Controls.Add(dgvContacto);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvContacto).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvContacto;
        private TextBox txtBuscar;
        private Label lblTotal;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNombre;
        private Button btnAgregar;
        private ErrorProvider errorProvider1;
        private Button btnEliminar;
        private Button btnGuardar;
    }
}
