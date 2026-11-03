using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    public class PagoEfectivo : MetodoClase
    {
        public string Nombre => "Efectivo";

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0m;
        }

        public bool Validar(decimal monto)
        {
            return monto > 0;
        }
    }
}
