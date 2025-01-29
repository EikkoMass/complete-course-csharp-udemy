using System;
using System.Globalization;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char dep = char.Parse(Console.ReadLine());
            Conta conta;


            if ('s' == dep || 'S' == dep)
            {
                Console.Write("Entre o valor de depósito inicial: ");
                conta = new Conta(titular, numero, double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            }else
            {
                conta = new Conta(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            conta.AplicarDeposito(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            conta.AplicarSaque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
            Console.Write("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}