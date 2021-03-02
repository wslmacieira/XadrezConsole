using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole.JogoXadrez
{
    public class Torre : Peca
    {
        public Torre(Tabuleiro tabuleiro, Cor cor) : base(tabuleiro, cor)
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
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                {
                    break;
                }
                Posicao.Linha = Posicao.Linha - 1;
            }

            // abaixo
            Posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                {
                    break;
                }
                Posicao.Linha = Posicao.Linha + 1;
            }

            // direita
            Posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                {
                    break;
                }
                Posicao.Coluna = Posicao.Coluna + 1;
            }

            // esquerda
            Posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(Posicao) && PodeMover(Posicao))
            {
                if (Tabuleiro.Peca(Posicao) != null && Tabuleiro.Peca(Posicao).Cor != Cor)
                {
                    break;
                }
                Posicao.Coluna = Posicao.Coluna - 1;
            }

            return mat;
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
