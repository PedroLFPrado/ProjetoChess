using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessboard;

namespace chessgame
{
    class Queen : Peca
    {
        public Queen(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "Q";
        }

    }
}
