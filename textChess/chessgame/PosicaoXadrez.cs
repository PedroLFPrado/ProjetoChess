using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessboard;

namespace chessgame
{
    class PosicaoXadrez
    {
        public char coloumn { get; set; }
        public int  row { get; set; }

        public PosicaoXadrez(char coloumn, int row)
        {
            this.coloumn = coloumn;
            this.row = row;
        }

        public Position ToPosition()
        {
            return new Position(8 - row, coloumn - 'a');
        }

        public override string ToString()
        {
            return "" + coloumn + row;
        }
    }
}
