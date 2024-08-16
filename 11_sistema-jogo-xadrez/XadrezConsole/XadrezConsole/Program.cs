using tabuleiro;
using xadrez;
using XadrezConsole.xadrez;

namespace XadrezConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PosicaoXadrez poxa = new PosicaoXadrez('c', 7);

                Console.WriteLine(poxa);
                Console.WriteLine(poxa.toPosicao());
             //   Tela.imprimirTabuleiro(tab);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
