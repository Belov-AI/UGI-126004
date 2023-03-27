using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public interface IDrawable
    {
        Color Outline { get; set; }
        void Draw();
    }
}
