using System;
using System.Globalization;

namespace Output
{

    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia!");
            Console.WriteLine("Boa Tarde!");
            Console.WriteLine("Boa Noite!");
            Console.WriteLine("----");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString ("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            int idade2 = 32;
            double saldo2 = 10.35784;
            string nome2 = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome2, idade2, saldo2);
            Console.WriteLine($"{nome2} tem {idade2} anos e tem saldo igual a {saldo2:F2} reais");
            Console.WriteLine(nome2 + " tem " + idade2 + " anos e tem saldo igual a " + saldo2.ToString("F2", CultureInfo.InvariantCulture) + " reais");

            string fixaProduto1 = "Computador";
            string fixaProduto2 = "Mesa de Escritorio";

            byte fixaIdade = 30;
            int fixaCodigo = 5290;
            char fixaGenero = 'M';

            double fixaPreco1 = 2100.0;
            double fixaPreco2 = 650.50;
            double fixaMedida = 53.234567;

            Console.WriteLine($"{fixaProduto1}, cujo o preço é $ {fixaPreco1:F2}");
            Console.WriteLine($"{fixaProduto2}, cujo o preço é $ {fixaPreco2:F2}");

            Console.WriteLine($"{fixaIdade} anos de idade, código {fixaCodigo} e gênero: {fixaGenero}");

            Console.WriteLine($"Medida com oito casas decimais: {fixaMedida:F8}");
            Console.WriteLine($"Arredondado (três casas decimais): {fixaMedida:F3}");
            Console.WriteLine("Separador decimal invariant culture: " + fixaMedida.ToString("F3", CultureInfo.InvariantCulture));
        }
    }

}