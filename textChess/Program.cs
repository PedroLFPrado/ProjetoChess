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
                PosicaoXadrez pos = new PosicaoXadrez('a', 1);

                Console.WriteLine(pos);
                Console.WriteLine(pos.ToPosition());


                Console.ReadLine();

            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
