using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Configuration;

namespace Shapes
{
    public abstract class Shape : IDrawable
    {
        public Color Fill { get; set; }
        public Color Outline { get; set; }
        
        public abstract double Area { get; }

        public abstract void Draw();
    }
}
