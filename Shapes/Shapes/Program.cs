using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(new Point(1, 2), 5, 3);
            rectangle.Fill = Color.DarkViolet;
            rectangle.Outline = Color.Black;

            var circle = new Circle(new Point(3, 6), 2);

            var shapes = new Shape[] { rectangle, circle };

            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine($"Площадь фигуры {shape.Area:F3}");
            }

            var point = new Point(1, 2);
            var line = new Line(2, -3);

            var objects = new IDrawable[] {rectangle, line, circle, point};
            DrawObjects(objects);
                
            Console.ReadKey();
        }

        public static void DrawObjects(IDrawable[] objects)
        {
            foreach (var obj in objects)
                obj.Draw();
        }
    }
}
