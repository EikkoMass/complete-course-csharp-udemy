using tabuleiro;
using xadrez;
using XadrezConsole.tabuleiro;
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

                while (!partida.terminada)
                {
                    try
                    {

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tabuleiro);
                        Console.WriteLine();
                        Console.WriteLine($"Turno: {partida.turno}");
                        Console.WriteLine($"Aguardando jogada: {partida.jogadorAtual}");
                        Console.WriteLine();

                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();

                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tabuleiro.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tabuleiro, posicoesPossiveis);
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException ex) {
                        Console.WriteLine(ex.Message);
                        Console.ReadLine();
                    }
                }

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
