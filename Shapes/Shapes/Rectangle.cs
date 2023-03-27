using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Point TopLeft { get; set; }

        double width;
        public double Width 
        { 
            get => width;
            set
            {
                if (value < 0)
                    throw new ArgumentException();

                width = value;
            } 
        }

        double height;
        public double Height 
        { 
            get => height;
            set
            {
                if(value < 0) 
                    throw new ArgumentException();
                
                height = value;
            }
        }
        public override double Area => Height * Width;

        public Rectangle(Point topLeft, double width, double height)
        {
            TopLeft = topLeft;
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine("Рисуем прямоугольник");
        }
    }
}
