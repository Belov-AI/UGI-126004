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
    public partial class MainForm : Form
    {
        AdditionalForm additionalForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openAdditionaiFormButton_Click(object sender, EventArgs e)
        {
            if(additionalForm == null)
            {
                additionalForm = new AdditionalForm();
                additionalForm.Show();
            }               
        }

        private void closeAdditionalFormButton_Click(object sender, EventArgs e)
        {
            if (additionalForm != null)
            {
                additionalForm.Close();
                additionalForm = null;
            }
                
        }

        private void questionButtonutton_Click(object sender, EventArgs e)
        {
            var result = new DialogForm().ShowDialog();

            if (result == DialogResult.Yes)
                MessageBox.Show("Очень хорошо!");
            else if (result == DialogResult.No)
                MessageBox.Show("А жаль :(");
            else if (result == DialogResult.Cancel)
                MessageBox.Show("Не ухордите от ответа");
        }

        private void openContainerButton_Click(object sender, EventArgs e)
        {
            new ContainerForm().Show();
        }
    }
}
