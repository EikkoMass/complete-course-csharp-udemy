using System;
using System.Globalization;

namespace SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {produto}");

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado: ");
            produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido: ");
            produto.RemoverProdutos(int.Parse(Console.ReadLine()));
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}
