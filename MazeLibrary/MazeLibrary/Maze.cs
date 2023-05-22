using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary
{
    public class Maze
    {
        Cell[,] board;

        public int Height => board.GetLength(0);
        public int Width => board.GetLength(1);

        int minSize = 3;
        int maxSize = 79;

        (int dx, int dy)[] dir = new[] { (1, 0), (-1, 0), (0, 1), (0, -1) };

        public Maze(int width, int height)
        {
            if(width % 2 == 0) width++;
            if(height % 2 == 0) height++;

            if(width < minSize) width = minSize;
            if(height < minSize) height = minSize;
            if(width > maxSize) width = maxSize;
            if(height > maxSize) height = maxSize;

            board = new Cell[height, width];

            for(var x = 0; x < board.GetLength(0); x++)
                for(var y = 0; y < board.GetLength(1); y++)
                    board[x, y] = new Cell() { Row = x, Column = y, Wall = true };

            var moves = new Stack<Cell>();
            var rnd = new Random();
            var current = board[
                2 * rnd.Next(height / 2) + 1,
                2 * rnd.Next(width / 2) + 1
                ];

            current.Wall = false;
            moves.Push(current);

            while(moves.Count > 0)
            {
                var deadend = true;

                var directions = new List<(int dx, int dy)>(dir);

                while(directions.Count > 0)
                {
                    var move = directions[rnd.Next(directions.Count)];
                    directions.Remove(move);

                    var rNew = current.Row + 2 * move.dx;
                    var cNew = current.Column + 2 * move.dy; 
                    
                    if( IsInMazeAndWall(rNew, cNew ) )
                    {
                        current = board[rNew, cNew];
                        board[rNew, cNew].Wall = false;
                        board[rNew - move.dx, cNew - move.dy].Wall = false;
                        deadend = false;
                        moves.Push(current);
                        break;
                    }
                }

                if (deadend)
                    current = moves.Pop();
            }
        }

        public bool IsInMazeAndWall(int x, int y) => IsInMaze(x, y) && board[x, y].Wall;

        public bool IsInMaze(int x, int y) => x >= 0 && x < Height && y >= 0 && y < Width;

        public Stack<Cell> MakePath(int rowStart, int columnStart, int rowEnd, int columnEnd)
        {
            var path = new Stack<Cell>();

            if (!IsInMaze(rowStart, columnStart) || !IsInMaze(rowEnd, columnEnd) ||
                board[rowStart, columnStart].Wall || board[rowEnd, columnEnd].Wall)
                return path;

            var start = board[rowStart, columnStart];
            MakeWave(start);

            var current = board[rowEnd, columnEnd];
            path.Push(current);

            do
            {
                foreach(var d in dir)
                {
                    var next = board[current.Row + d.dx, current.Column + d.dy];
                    if(!next.Wall && next.Weight < current.Weight)
                    {
                        current = next;
                        break;
                    }
                }

                path.Push(current);

            }while(current != start);

            return path;
        }

        public bool IsCellInPath(int x, int y, Stack<Cell> path) => path.Contains(board[x,y]);

        private void MakeWave(Cell cell)
        {
            if (cell.Wall) return;

            foreach (var item in board)
                if (!item.Wall)
                    item.Weight = int.MaxValue;

            var cells = new Queue<Cell>();

            cell.Weight = 0;
            cells.Enqueue(cell);


            while(cells.Count > 0)
            {
                var current = cells.Dequeue();

                foreach (var d in dir)
                {
                    var rNew = current.Row + d.dx;
                    var cNew = current.Column + d.dy;

                    if (!board[rNew, cNew].Wall)
                    {
                        var weight = current.Weight + 1;
                        if(board[rNew, cNew].Weight > weight)
                        {
                            board[rNew, cNew].Weight = weight;
                            cells.Enqueue(board[rNew, cNew]);
                        }                          
                    }
                }
            }
        }

    }
}
