using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0;i<tab.linhas;i++)
            {
                for(int j=0;j<tab.colunas;j++)
                {
                    Peca peca = tab.peca(i, j);

                    Console.Write($"{(peca != null ? peca : "-")} ");
                }

                Console.WriteLine();
            }
        }

    }
}
