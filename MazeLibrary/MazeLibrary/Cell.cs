﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeLibrary
{
    public class Cell
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool Wall { get; set; }
        public int Weight { get; set; }
    }
}
