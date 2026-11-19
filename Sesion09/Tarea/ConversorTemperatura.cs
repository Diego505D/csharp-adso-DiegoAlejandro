using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    public class ConversorTemperatura
    {
        public double Convertir(double valor, string origen, string destino)
        {
            double celsius = 0;

            if (origen == "Celsius (°C)")
            {
                celsius = valor;
            }
            else if (origen == "Fahrenheit (°F)")
            {
                celsius = (valor - 32) * 5 / 9;
            }
            else if (origen == "Kelvin (K)")
            {
                celsius = valor - 273.15;
            }
            if (destino == "Celsius (°C)")
            {
                return celsius;
            }
            else if (destino == "Fahrenheit (°F)")
            {
                return (celsius * 9 / 5) + 32;
            }
            else if (destino == "Kelvin (K)")
            {
                return celsius + 273.15;
            }

            return 0;
        }
    }
}