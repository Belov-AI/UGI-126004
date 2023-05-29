using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            g.FillEllipse(Brushes.Yellow, 50, 50, 200, 100);

            using(Pen p = new Pen(Color.Red, 3))
            {
                g.DrawLine(p, 80, 20, 200, 200);
                p.Color = Color.DarkGreen;
                g.DrawRectangle(p, 10, 10, 150, 250);

                p.Color = Color.Blue;
                p.Width = 10;
                g.DrawLine(p, 0, 0, ClientSize.Width, ClientSize.Height);
            }

            g.DrawString("Рисунок", new Font("Tahoma", 24), Brushes.Magenta, 10, 300); 
        }
    }
}
