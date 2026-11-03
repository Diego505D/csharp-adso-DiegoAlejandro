using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    public interface MetodoClase
    {
        string Nombre { get; }

        decimal CalcularComision(decimal monto);

        bool Validar(decimal monto);
    }
}
