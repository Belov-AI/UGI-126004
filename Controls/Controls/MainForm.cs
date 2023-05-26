using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class MainForm : Form
    {
        const int time = 30;

        string openFileFolder;
        public MainForm()
        {
            InitializeComponent();

            wordsListBox.Items.Add("Глава");
            wordsListBox.Items.Add("Параграф");
            wordsListBox.Items.Add("Раздел");

            fontFamilyComboBox.Items.Add("Microsoft San Serif");
            fontFamilyComboBox.Items.Add("Times New Roman");
            fontFamilyComboBox.Items.Add("Courier New");

            pictureBox1.Load(Application.StartupPath + @"\Images\pic7.jpg");

            progressBar1.Maximum = 7 * time;

            openFileDialog1.Filter = "Текст|*.txt|Форматировнный текст|*.rtf";
            openFileDialog1.InitialDirectory = Application.StartupPath;
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

        private void slideShowButton_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            slideShowButton.Enabled = false;
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                slideShowButton.Enabled = true;
                return;
            }

            if (progressBar1.Value % time == 0)
                pictureBox1.Image = Properties.Resources.ResourceManager
                    .GetObject("pic" + (progressBar1.Value / time + 1).ToString()) as Image;

            progressBar1.Value++;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FilterIndex == 2)
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                else if(openFileDialog1.FilterIndex == 1)
                    richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName,
                        Encoding.Default);

                openFileDialog1.InitialDirectory =
                     openFileDialog1.FileName.Substring(0,
                     openFileDialog1.FileName.Length - openFileDialog1.SafeFileName.Length);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                inputButton_Click(sender, e);
        }

        private void richTextBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
