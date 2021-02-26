using System;
using XadrezConsole.JogoXadrez;
using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.InserirPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.InserirPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.InserirPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ExibirTabuleiro(tab);

            Console.ReadLine();

        }
    }
}
