using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public class EmpleadoPorHoras : Empleado
    {
        public int Horas { get; }
        public decimal ValorHora { get; }

        public override string Tipo => "Empleado por horas";

        public EmpleadoPorHoras(string nombre, string documento, int horas, decimal valorHora)
            : base(nombre, documento)
        {
            Horas = horas;
            ValorHora = valorHora;
        }

        public override decimal CalcularSalario()
        {
            if (Horas <= 160)
            {
                return Horas * ValorHora;
            }

            decimal salarioNormal = 160 * ValorHora;
            decimal horasExtras = (Horas - 160) * ValorHora * 1.5m;

            return salarioNormal + horasExtras;
        }
    }
}
