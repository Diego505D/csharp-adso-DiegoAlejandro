using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reto
{
    public partial class FormPin : Form
    {
        private const string pinCorrecto = "2205";
        private int intentos = 0;
        public FormPin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == pinCorrecto)
            {
                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            intentos++;

            if (intentos >= 3)
            {
                MessageBox.Show("Has agotado los 3 intentos.",
                    "Acceso denegado");

                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                MessageBox.Show($"PIN incorrecto. Te quedan {3 - intentos} intentos.",
                    "Error");

                txtPin.Clear();
                txtPin.Focus();

            }
        }
    }
}
