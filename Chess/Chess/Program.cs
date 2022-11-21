using System;

namespace Chess
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите позицию белой пешки");
            string whitePawnPosition = Console.ReadLine();

            if(!CheckPawnPosition(whitePawnPosition))
            {
                Console.WriteLine("Позиция белой пешки не корректина");
                Console.ReadKey(); 
                return;
            }

            Console.WriteLine("Введите позицию чёрной пешки");
            string blackPawnPosition = Console.ReadLine();

            if (!CheckPawnPosition(blackPawnPosition))
            {
                Console.WriteLine("Позиция чёрной пешки не корректина");
                Console.ReadKey();
                return;
            }
            else if (IsBlackPawnUnderStrike(blackPawnPosition, whitePawnPosition))
            {
                Console.WriteLine("Черная пешка под ударом");
                Console.ReadKey();
                return;
            }
            else if(blackPawnPosition == whitePawnPosition)
            {
                Console.WriteLine($"Клетка {blackPawnPosition} занята");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите ход белой пешки");
            string whitePownMove = Console.ReadLine();

            if (IsWhitePawnMoveCorrect(blackPawnPosition, whitePawnPosition, whitePownMove))
                Console.WriteLine("Так ходить разрешается");
            else
                Console.WriteLine("Так ходить не разрешается");

            Console.ReadKey();
        }

        static bool CheckPawnPosition(string position)
        {
            int r, c;
            DecodePosition(position, out r, out c); 

            return r > 1 & r < 8;
        }

        static bool IsBlackPawnUnderStrike(string bp, string wp)
        {
            int wr, wc, br, bc;
            DecodePosition(bp, out br, out bc);
            DecodePosition(wp, out wr, out wc);
            return br == wr + 1 && (bc == wc - 1 || bc == wc + 1);
        }

        static bool IsWhitePawnMoveCorrect(string bp, string wp, string move)
        {
            int wr, wc, br, bc, mr, mc;
            DecodePosition(bp, out br, out bc);
            DecodePosition(wp, out wr, out wc);
            DecodePosition(move, out mr, out mc);

            var dr = mr - wr;
            //return wc == mc
            //    && wr == 
            //    && !(mr == br - 1 && (mc == bc - 1 || mc == bc + 1)))

            //    (wc == bc && (mr != br || !(wr == 2 && br == 3 && mr == 4))
            //     (dr == 1 || (wr == 2 && dr == 2)) 
            //    && 

            throw new NotImplementedException();
        }

        static void DecodePosition(string position, out int row, out int column)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 0x60;
        }
    }
}
