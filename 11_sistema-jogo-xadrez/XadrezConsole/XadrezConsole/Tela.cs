using tabuleiro;

namespace XadrezConsole
{
    class Tela
    {

        public static void imprimirTabuleiro(Tabuleiro tab)
        {
            for(int i=0;i<tab.linhas;i++)
            {
                Console.Write(8 - i + " ");

                for(int j=0;j<tab.colunas;j++)
                {
                    Peca peca = tab.peca(i, j);

                    if(peca != null)
                    {
                        Tela.imprimirPeca(peca);
                    } else
                    {
                        Console.Write("- ");
                    }

                }

                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirPeca(Peca peca)
        {
            if(peca.cor == Cor.Branca)
            {
                Console.Write($"{peca} ");
            } else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{peca} ");
                Console.ForegroundColor = aux;
            }
        }

    }
}
