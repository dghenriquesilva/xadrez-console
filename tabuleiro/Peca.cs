

namespace tabuleiro
{
    class Peca
    {
        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtMovimentos { get; protected set; }
        public Tabuleiro tabuleiro { get; protected set; }

        public Peca(Posicao _posicao, Tabuleiro _tabuleiro, Cor _cor)
        {
            this.posicao = _posicao;
            this.tabuleiro = _tabuleiro;
            this.cor = _cor;
            this.qtMovimentos = 0;
        }
    }
}
