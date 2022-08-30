using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro _tabuleiro, Cor _cor): base(_tabuleiro, _cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
