namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOrigen.Items.Add("Celsius (°C)");
            cmbOrigen.Items.Add("Fahrenheit (°F)");
            cmbOrigen.Items.Add("Kelvin (K)");

            cmbDestino.Items.Add("Celsius (°C)");
            cmbDestino.Items.Add("Fahrenheit (°F)");
            cmbDestino.Items.Add("Kelvin (K)");
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            double valor;

            if (!double.TryParse(txtValor.Text, out valor))
            {
                errorProvider1.SetError(txtValor, "Ingrese un número válido.");
                return;
            }

            if (cmbOrigen.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbOrigen, "Seleccione la unidad de origen.");
                return;
            }

            if (cmbDestino.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbDestino, "Seleccione la unidad de destino.");
                return;
            }

            ConversorTemperatura conversor = new ConversorTemperatura();

            double resultado = conversor.Convertir(
                valor,
                cmbOrigen.SelectedItem.ToString(),
                cmbDestino.SelectedItem.ToString()
            );

            lblResultado.Text = "Resultado: " + resultado.ToString("N2");
        }
    }
}
