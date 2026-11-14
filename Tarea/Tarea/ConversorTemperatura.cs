
namespace Sesion09
{
    public class ConversorTemperatura
    {
        public static double Convertir(double temperatura,string origen, string destino)
        {
            double celsius;

           
            switch (origen)
            {
                case "Celsius":
                    celsius = temperatura;
                    break;

                case "Fahrenheit":
                    celsius = (temperatura - 32) * 5 / 9;
                    break;

                case "Kelvin":
                    celsius = temperatura - 273.15;
                    break;

                default:
                    throw new ArgumentException(
                        "Unidad de origen no válida");
            }

           
            if (celsius < -273.15)
            {
                throw new ArgumentException(
                    "La temperatura no puede ser inferior al cero absoluto");
            }

            
            switch (destino)
            {
                case "Celsius":
                    return celsius;

                case "Fahrenheit":
                    return (celsius * 9 / 5) + 32;

                case "Kelvin":
                    return celsius + 273.15;

                default:
                    throw new ArgumentException(
                        "Unidad de destino no válida");
            }
        }
    }
}

