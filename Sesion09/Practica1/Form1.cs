using System.Linq.Expressions;

namespace Practica1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Hola, {txtNombre.Text}! bienvenido a mi programa";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text));
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) - Convert.ToInt32(txtNumero2.Text));
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) * Convert.ToInt32(txtNumero2.Text));
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(txtNumero1.Text);
            int numero2 = Convert.ToInt32(txtNumero2.Text);

            if (numero2 == 0)
            {
                throw new ArgumentException("No se puede dividir entre cero (0).");
            }

            txtResultado.Text = (numero1 / numero2).ToString();
        }

        private void MostrarError(ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    
        
    }
}
