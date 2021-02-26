using System;
using XadrezConsole.JogoXadrez;

namespace XadrezConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('A', 1);

            Console.WriteLine(posicao);

            Console.WriteLine(posicao.ToPosicao());

            Console.ReadLine();

        }
    }
}
