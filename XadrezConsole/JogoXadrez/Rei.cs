using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole.JogoXadrez
{
    public class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
        {
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis()
        {
            bool[,] mat = new bool[Tabuleiro.Linha, Tabuleiro.Coluna];

            Posicao Posicao = new Posicao(0, 0);

            // acima
            Posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }
            // ne
            Posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }
            // direita
            Posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }
            // se
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }
            // abaixo
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }
            // so
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }
            // esquerda
            Posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }
            // no
            Posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                mat[Posicao.Linha, Posicao.Coluna] = true;
            }

            return mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
