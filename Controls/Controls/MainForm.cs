using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void captionLabel_MouseHover(object sender, EventArgs e)
        {
            captionLabel.ForeColor = Color.Red;
        }

        private void captionLabel_MouseLeave(object sender, EventArgs e)
        {
            captionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            captionLabel.Text = textBox1.Text;
            textBox1.Text = string.Empty;
        }
    }
}
