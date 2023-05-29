using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EuclidLibrary;

namespace EuclidGraphics
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var numbers = new double[9];

            for(var i = 0; i < numbers.Length; i++)
                if (!double.TryParse(Controls["textBox" + (i + 1)].Text, out numbers[i]))
                {
                    MessageBox.Show("Ошибка ввода!",
                        "Сообщение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

            var a = new EuclidLibrary.Point(numbers[0], numbers[1]);
            var b = new EuclidLibrary.Point(numbers[2], numbers[3]);
            var c = new EuclidLibrary.Point(numbers[4], numbers[5]);
            var center = new EuclidLibrary.Point(numbers[6], numbers[7]);
            var angle = numbers[8];

            var original = new Triangle(a, b, c);
            var rotated = (original.Clone() as Triangle);
            rotated.Rotate(angle, center);


            var picture = new PictureForm(center, original, rotated);
            picture.Show();
        }
    }
}
