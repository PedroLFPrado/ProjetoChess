using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using chessboard;
using chessgame;

namespace textChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Position p = new Position(3, 4);
            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPeca(new Rook(tab, Cor.Preta), new Position(0, 0));
            Tela.imprimirTabuleiro(tab);
        }
    }
}
