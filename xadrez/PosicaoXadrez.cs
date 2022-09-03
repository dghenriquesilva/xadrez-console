using tabuleiro;
namespace xadrez
{ 
    // Corrige a posicao da matriz para que se comporte como nas posições do tabuleiro de xadrez
    // ex: a7 retorna: 0,1
    // porque 8 = número de posições, logo 8-7 = 1
    // char a = 96; a-a=0
    class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }
        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }
        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }
        public override string ToString()
        {
            return " " + coluna + linha;
        }
    }
}
