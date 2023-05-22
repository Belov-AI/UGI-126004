using MazeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ширину лабиринта");
            var width = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите высоту лабиринта");
            var height = int.Parse(Console.ReadLine());
            
            var maze = new Maze(width, height);

            PrintMaze(maze, new Stack<Cell>());

            Console.WriteLine("Координаты начала пути через пробел");
            var start = Console.ReadLine().Split();
            Console.WriteLine("Координаты конца пути через пробел");
            var end = Console.ReadLine().Split();
            var path = maze.MakePath(int.Parse(start[0]), int.Parse(start[1]),
                int.Parse(end[0]), int.Parse(end[1]));
            
            PrintMaze(maze, path);

            Console.ReadKey();
        }

        static void PrintMaze(Maze maze, Stack<Cell> path)
        {
            for(var x = 0; x < maze.Height; x++)
            {
                for (var y = 0; y < maze.Width; y++)
                    if(path.Count >0 && maze.IsCellInPath(x, y, path))
                        Console.Write('*');
                    else if (maze.IsInMazeAndWall(x, y))
                        Console.Write((char)0x2588);
                    else
                        Console.Write(' ');

                Console.WriteLine();
            }
        }
    }
}
