using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessboard;

namespace chessgame
{
    class Pawn : Peca
    {
        public Pawn(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "P";
        }

    }
}
