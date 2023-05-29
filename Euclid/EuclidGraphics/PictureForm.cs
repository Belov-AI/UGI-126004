using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuclidLibrary;

namespace EuclidGraphics
{
    public partial class PictureForm : Form
    {
        EuclidLibrary.Point rotationCenter;
        Triangle original;
        Triangle rotated;

        Graphics g;

        const double scale = 75;
        public PictureForm(EuclidLibrary.Point center, Triangle original, Triangle rotated)
        {
            InitializeComponent();

            rotationCenter = center;
            this.original = original;
            this.rotated = rotated;

            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        void DrawPoint(EuclidLibrary.Point p, Color color) 
        {
            var point = ConvertToScreen(p);

            using (var brush = new SolidBrush(color))
                g.FillEllipse(brush, point.X - 3,point.Y - 3, 7, 7);
                
        }

        void DrawTriangle(Triangle t, Color color, int penWidth, DashStyle d) 
        {
            using(var pen = new Pen(color, penWidth))
            {
                pen.DashStyle = d;
                g.DrawPolygon(pen, new[]
                {
                    ConvertToScreen(t.A),
                    ConvertToScreen(t.B),
                    ConvertToScreen(t.C)
                });
            }
        }


        System.Drawing.Point ConvertToScreen(EuclidLibrary.Point pt) =>
            new System.Drawing.Point(
                (int)Math.Round(pt.X * scale),
                (int)Math.Round(ClientSize.Height - pt.Y * scale)
                );


        private void PictureForm_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;          
            DrawTriangle(original, Color.Blue, 5, DashStyle.Dash);
            DrawTriangle(rotated, Color.Red, 5, DashStyle.Solid);
            DrawPoint(rotationCenter, Color.Green);
        }
    }
}
