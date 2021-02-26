using System;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole
{
    public class Tela
    {
        public static void ExibirTabuleiro(Tabuleiro tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linha; i++)
            {
                for (int j = 0; j < tabuleiro.Coluna; j++)
                {
                    if (tabuleiro.Peca(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    Console.Write(tabuleiro.Peca(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
