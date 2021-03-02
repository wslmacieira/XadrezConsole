using XadrezConsole.TabuleiroXadrez;

namespace XadrezConsole.JogoXadrez
{
    public class Rei : Peca
    {
        private PartidaDeXadrez partida;
        public Rei(Tabuleiro tabuleiro, Cor cor, PartidaDeXadrez partida) : base(tabuleiro, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca Peca = Tabuleiro.Peca(posicao);
            return Peca == null || Peca.Cor != Cor;
        }

        private bool TesteTorreParaRoque(Posicao pos)
        {
            Peca p = Tabuleiro.Peca(pos);
            return p != null && p is Torre && p.Cor == Cor && p.QtdMovimentos == 0;
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

            // #jogadaespecial roque
            if (QtdMovimentos == 0 && !partida.Xeque)
            {
                // #jogadaespecial roque pequeno
                Posicao posT1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);
                if (TesteTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);
                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }
                // #jogadaespecial roque grande
                Posicao posT2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);
                if (TesteTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);
                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null && Tabuleiro.Peca(p3) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return mat;
        }
    }
}
