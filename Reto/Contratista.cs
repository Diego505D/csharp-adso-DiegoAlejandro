using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public class Contratista : Empleado
    {
        public decimal ValorContrato { get; }

        public override string Tipo => "Contratista";

        public Contratista(string nombre, string documento, decimal valorContrato)
            : base(nombre, documento)
        {
            ValorContrato = valorContrato;
        }

        public override decimal CalcularSalario()
        {
            return ValorContrato * 0.90m;
        }
    }
}
