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

            if (IsWhitePawnMoveCorrect(whitePawnPosition, blackPawnPosition, whitePownMove))
                Console.WriteLine("Так ходить разрешается");
            else
                Console.WriteLine("Так ходить не разрешается");

            Console.ReadKey();
        }

        static bool CheckPawnPosition(string position)
        {
            int r, c;
            (r, c) = DecodePosition(position); 

            return r > 1 & r < 8;
        }

        static bool IsBlackPawnUnderStrike(string bp, string wp)
        {
            int wr, wc, br, bc;
            (br, bc) = DecodePosition(bp);
            (wr, wc) = DecodePosition(wp);
            return br == wr + 1 && (bc == wc - 1 || bc == wc + 1);
        }

        static bool IsWhitePawnMoveCorrect(string whitePawnPosition, string blackPawnPosition, string move)
        {
            return CanWhitePawnMove(whitePawnPosition, move)
                && !IsWhitePawnBlocked(whitePawnPosition, blackPawnPosition, move)
                && !IsWhitePawnUnderStrike(whitePawnPosition, blackPawnPosition)
                ;
        }

        static bool CanWhitePawnMove(string whitePawnPosition, string move)
        {
            int startRow, startColumn, endRow, endColumn;
            (startRow, startColumn) = DecodePosition(whitePawnPosition);
            (endRow, endColumn) = DecodePosition(move);

            return startColumn == endColumn && (endRow == startRow + 1 || startRow == 2 && endRow == startRow + 2);
        }

        static bool IsWhitePawnBlocked(string whitePawnPosition, string blackPawnPosition, string move)
        {
            int startRow, startColumn, endRow, endColumn;
            (startRow, startColumn) = DecodePosition(whitePawnPosition);
            (endRow, endColumn) = DecodePosition(move);

            int blackPawnRow, blackPawnColumn;
            (blackPawnRow, blackPawnColumn) = DecodePosition(blackPawnPosition);

            return startColumn == blackPawnColumn
                && (blackPawnRow == startRow + 1
                || startRow == 2 && endRow == startRow + 2 && blackPawnRow == endRow);
        }

        static bool IsWhitePawnUnderStrike(string whitePawnPosition, string blackPawnPosition)
        {
            int whitePawnRow, whitePawnColumn;
            (whitePawnRow, whitePawnColumn) = DecodePosition(whitePawnPosition);

            int blackPawnRow, blackPawnColumn;
            (blackPawnRow, blackPawnColumn) = DecodePosition(blackPawnPosition);

            return blackPawnRow == whitePawnRow + 2
                && Math.Abs(blackPawnColumn - whitePawnColumn) == 1;
        }

        static (int, int) DecodePosition(string position)
        {
            var row = int.Parse(position[1].ToString());
            var column = (int)position[0] - 0x60;
            return (row, column);
        }
    }
}
