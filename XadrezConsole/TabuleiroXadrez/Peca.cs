namespace XadrezConsole.TabuleiroXadrez
{
    public abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int QtdMovimentos { get; protected set; }
        public Tabuleiro Tabuleiro { get; protected set; }

        public Peca(Tabuleiro tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            QtdMovimentos = 0;
            Tabuleiro = tabuleiro;
        }

        public abstract bool[,] MovimentosPossiveis();

        internal void IncrementarMovimento()
        {
            QtdMovimentos++;
        }
    }
}
