using tabuleiro;

namespace xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro _tabuleiro, Cor _cor) : base(_tabuleiro, _cor)
        {

        }
        public override string ToString()
        {
            return "T";
        }
    }
}
