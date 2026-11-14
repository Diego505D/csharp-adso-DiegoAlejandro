namespace Reto
{
    public partial class Form1 : Form
    {
        private CuentaBancaria cuenta;
        public Form1()
        {
            InitializeComponent();
            cuenta = new CuentaBancaria("Diego", "P001", 100000);

            ActualizarDatos();
        }
        private void ActualizarDatos()
        {
            lblTitular.Text = "Titular: " + cuenta.Titular;
            lblSaldo.Text = "Saldo: $" + cuenta.Saldo;
        }

        private void nudMonto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (cuenta.Depositar(monto))
            {
                ActualizarDatos();

                lstMovimientos.Items.Insert(0,
                    $"{DateTime.Now:HH:mm} | Depósito | {monto:N0}");
            }
            else
            {
                MessageBox.Show("No se pudo realizar el depósito. Verifique que el monto sea válido y múltiplo de $10.000.");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;

            if (cuenta.Retirar(monto))
            {
                ActualizarDatos();

                lstMovimientos.Items.Insert(0,
                    $"{DateTime.Now:HH:mm} | Retiro | {monto:N0}");
            }
            else
            {
                MessageBox.Show(
                    "No se pudo realizar el retiro. Verifique que tenga saldo suficiente y que el monto sea múltiplo de $10.000.",
                    "Error en el retiro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void lblTitular_Click(object sender, EventArgs e)
        {

        }
    }
}
