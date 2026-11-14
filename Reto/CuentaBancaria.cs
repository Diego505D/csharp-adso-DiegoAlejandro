using System;
using System.Collections.Generic;
using System.Text;

namespace Reto
{
    public class CuentaBancaria
    {
        public string Titular { get; private set; }
        public string Numero { get; private set; }
        public decimal Saldo { get; private set; }

        public CuentaBancaria(string titular, string numero, decimal saldoInicial)
        {
            Titular = titular;
            Numero = numero;
            Saldo = saldoInicial;
        }

        public bool Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                return false;
            }
            if (monto % 10000 != 0)
            {
                return false;
            }

            Saldo += monto;
            return true;
        }
        public bool Retirar(decimal monto)
        {
            if (monto <= 0 || monto > Saldo)
            {
                return false;
            }
            if (monto % 10000 != 0)
            {
                return false;
            }
            Saldo -= monto;
            return true;
        }
        public bool Transferir(CuentaBancaria destino, decimal monto)
        {
            if (monto <= 0 || monto > Saldo)
            {
                return false;
            }
            if (destino == null)
            {
                return false;
            }
            Saldo -= monto;
            destino.Saldo += monto;

            return true;
        }
    }
}
