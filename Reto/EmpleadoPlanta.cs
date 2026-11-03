using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public class EmpleadoPlanta : Empleado
    {
        public decimal SalarioMensual { get; }
        public int AnosAntiguedad { get; }

        public override string Tipo => "Empleado de planta";

        public EmpleadoPlanta(string nombre, string documento, decimal salarioMensual, int anosAntiguedad)
            : base(nombre, documento)
        {
            SalarioMensual = salarioMensual;
            AnosAntiguedad = anosAntiguedad;
        }

        public override decimal CalcularSalario()
        {
            if (AnosAntiguedad >= 5)
            {
                return SalarioMensual + (SalarioMensual * 0.05m);
            }

            return SalarioMensual;
        }
    }
}
