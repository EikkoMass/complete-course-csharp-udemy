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
                PartidaDeXadrez partida = new PartidaDeXadrez();


                Tela.imprimirTabuleiro(partida.tabuleiro);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
