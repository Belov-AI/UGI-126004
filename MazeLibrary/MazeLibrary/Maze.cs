using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
