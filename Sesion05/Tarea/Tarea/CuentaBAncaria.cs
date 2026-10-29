using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea
{
    public class CuentaBancaria
    {
        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }


        public CuentaBancaria(string titular, string numero, decimal saldoInicial = 0)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldoInicial;
        }
        public bool depositar(decimal monto)
        {
            if (monto <= 0)
            {
                return false;
            }
            Saldo += monto;
            return true;
        }
        public bool retirar(decimal monto)
        {
            if (monto <= 0 || monto > Saldo)
            {
                return false;
            }
            Saldo -= monto;
            return true;
        }
        public bool transferir(CuentaBancaria cuentaDestino, decimal monto)
        {
            if (cuentaDestino == null || monto <= 0 || monto > Saldo)
            {
                return false;
            }
            Saldo -= monto;
            cuentaDestino.depositar(monto);
            return true;
        }
    }

}
