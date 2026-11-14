
using Sesion09;
using System;
using System.Windows.Forms;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            comboBox1.Items.Add("Celsius");
            comboBox1.Items.Add("Fahrenheit");
            comboBox1.Items.Add("Kelvin");

            comboBox2.Items.Add("Celsius");
            comboBox2.Items.Add("Fahrenheit");
            comboBox2.Items.Add("Kelvin");

            
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }

        private void txtTemperatura_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperatura;

            
            if (!double.TryParse(txtTemperatura.Text, out temperatura))
            {
                MessageBox.Show("Ingresa una temperatura válida");
                return;
            }

            
            string origen = comboBox1.Text;
            string destino = comboBox2.Text;

            try
            {
                
                double resultado = ConversorTemperatura.Convertir(
                    temperatura, origen, destino);

                
                MessageBox.Show(
                    "El resultado es: " +
                    resultado.ToString("F2") + " " + destino);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
