using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFixacao
{
    internal class Conta
    {

        public int Numero { get; private set; }
        public string Titular { get; private set;}
        public double Saldo { get; private set; }

        public Conta(string titular, int numero, double deposito) : this(titular, numero)
        {
            AplicarDeposito(deposito);
        }

        public Conta(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }

        public void AplicarDeposito(double deposito)
        {
            Saldo += deposito;
        }

        public void AplicarSaque(double saque)
        {
            Saldo -= (saque + 5);
        }

        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Titular}, Saldo: $ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
