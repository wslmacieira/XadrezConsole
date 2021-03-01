namespace XadrezConsole.TabuleiroXadrez
{
    public class Posicao
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }
        private readonly int coluna;
        private readonly int linha;

        public void DefinirValores(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;

        }

        public override string ToString()
        {
            return Linha
                + ", "
                + Coluna;
        }
    }
}
