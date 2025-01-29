using System;
using System.Globalization;

namespace DataInput
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassContentPart1();
            ClassContentPart2();
            FixationExercises();

        }

        private static void ClassContentPart1()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] v = Console.ReadLine().Split(" ");
            string a = v[0];
            string b = v[1];
            string c = v[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        private static void ClassContentPart2()
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(" ");
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Você digitou: {n1}, {ch} e " + n2.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine($"Você digitou: {nome}, {sexo}, {idade} e " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }

        private static void FixationExercises()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] splittedUserData = Console.ReadLine().Split(" ");

            Console.WriteLine($"nome: {nome}");
            Console.WriteLine($"quartos: {quartos}");
            Console.WriteLine("preco: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(" ---- ---- ---- ");

            Console.WriteLine($"dados ultima pessoa:");
            Console.WriteLine($"nome: {splittedUserData[0]}");
            Console.WriteLine($"idade: {splittedUserData[1]}");
            Console.WriteLine($"altura: {splittedUserData[2]}");

        }

    }
}