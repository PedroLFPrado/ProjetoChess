using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessgame;

namespace chessboard
{
    class Peca
    {

        public Position position { get; set; }
        public Cor cor { get; protected set; }

        public int qntMovimentos { get; protected set; }

        public Tabuleiro tab { get; protected set; }

        public Peca( Tabuleiro tab, Cor cor)
        {
            this.position = null;
            this.cor = cor;
            this.tab = tab;
            this.qntMovimentos = 0;
        }
    }
}
