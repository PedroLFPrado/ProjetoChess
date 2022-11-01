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
            try{
                Position p = new Position(3, 4);
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Rook(tab, Cor.Preta), new Position(0, 1));
                tab.colocarPeca(new King(tab, Cor.Preta), new Position(1, 0));
                Tela.imprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
