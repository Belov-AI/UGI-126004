using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ContainerForm : Form
    {
        int counter = 0;
        public ContainerForm()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var form = new DocumentForm();
            form.Text = "Документ " + (++counter);
            form.MdiParent = this;
            form.Show();
        }
    }
}
