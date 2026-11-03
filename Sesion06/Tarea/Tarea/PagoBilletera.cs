using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{

    public class PagoBilletera : MetodoClase, Rembolsable
    {
        public string Nombre => "Billetera";

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.01m;
        }

        public bool Validar(decimal monto)
        {
            return monto > 0 && monto <= 2000000;
        }

        public decimal Reembolsar(decimal monto)
        {
            return monto;
        }
    }
}


