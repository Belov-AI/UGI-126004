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

            wordsListBox.Items.Add("Глава");
            wordsListBox.Items.Add("Параграф");
            wordsListBox.Items.Add("Раздел");

            fontFamilyComboBox.Items.Add("Microsoft San Serif");
            fontFamilyComboBox.Items.Add("Times New Roman");
            fontFamilyComboBox.Items.Add("Courier New");
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

        private void ChangeFontStyle(object sender, EventArgs e)
        {
            var fontStyle = FontStyle.Regular;

            if(boldCheckBox.Checked)
                fontStyle |= FontStyle.Bold;

            if(italicCheckBox.Checked) 
                fontStyle |= FontStyle.Italic;

            if(underlineCheckBox.Checked) 
                fontStyle |= FontStyle.Underline;

            captionLabel.Font = new Font(captionLabel.Font, fontStyle);
        }

        private void ChangeFontSize(object sender, EventArgs e)
        {
            if(sender is RadioButton rb)
            {
                int size = int.Parse(rb.Text.Split()[0]);
                captionLabel.Font = new Font(
                    captionLabel.Font.FontFamily,
                    size,
                    captionLabel.Font.Style);
            }
        }

        private void wordsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            captionLabel.Text = wordsListBox.SelectedItem.ToString();
        }

        private void fontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            captionLabel.Font = new Font(
                fontFamilyComboBox.SelectedItem.ToString(),
                captionLabel.Font.Size,
                captionLabel.Font.Style);
        }
    }
}
