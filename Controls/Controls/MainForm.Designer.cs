namespace Controls
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.captionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.boldCheckBox = new System.Windows.Forms.CheckBox();
            this.italicCheckBox = new System.Windows.Forms.CheckBox();
            this.underlineCheckBox = new System.Windows.Forms.CheckBox();
            this.size10radioButton = new System.Windows.Forms.RadioButton();
            this.size12radioButton = new System.Windows.Forms.RadioButton();
            this.size14radioButton = new System.Windows.Forms.RadioButton();
            this.wordsListBox = new System.Windows.Forms.ListBox();
            this.fontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slideShowButton = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // captionLabel
            // 
            this.captionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.captionLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.captionLabel.Location = new System.Drawing.Point(16, 12);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(308, 48);
            this.captionLabel.TabIndex = 0;
            this.captionLabel.Text = "Надпись";
            this.captionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.captionLabel.MouseLeave += new System.EventHandler(this.captionLabel_MouseLeave);
            this.captionLabel.MouseHover += new System.EventHandler(this.captionLabel_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите тест";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(23, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.Location = new System.Drawing.Point(23, 158);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(93, 28);
            this.inputButton.TabIndex = 3;
            this.inputButton.Text = "Ввод";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(348, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(570, 506);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            this.richTextBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.richTextBox1_PreviewKeyDown);
            // 
            // boldCheckBox
            // 
            this.boldCheckBox.AutoSize = true;
            this.boldCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boldCheckBox.Location = new System.Drawing.Point(23, 206);
            this.boldCheckBox.Name = "boldCheckBox";
            this.boldCheckBox.Size = new System.Drawing.Size(109, 21);
            this.boldCheckBox.TabIndex = 4;
            this.boldCheckBox.Text = "полужирный";
            this.boldCheckBox.UseVisualStyleBackColor = true;
            this.boldCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // italicCheckBox
            // 
            this.italicCheckBox.AutoSize = true;
            this.italicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.italicCheckBox.Location = new System.Drawing.Point(23, 233);
            this.italicCheckBox.Name = "italicCheckBox";
            this.italicCheckBox.Size = new System.Drawing.Size(71, 21);
            this.italicCheckBox.TabIndex = 5;
            this.italicCheckBox.Text = "курсив";
            this.italicCheckBox.UseVisualStyleBackColor = true;
            this.italicCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // underlineCheckBox
            // 
            this.underlineCheckBox.AutoSize = true;
            this.underlineCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.underlineCheckBox.Location = new System.Drawing.Point(23, 260);
            this.underlineCheckBox.Name = "underlineCheckBox";
            this.underlineCheckBox.Size = new System.Drawing.Size(129, 21);
            this.underlineCheckBox.TabIndex = 6;
            this.underlineCheckBox.Text = "подчеркивание";
            this.underlineCheckBox.UseVisualStyleBackColor = true;
            this.underlineCheckBox.CheckedChanged += new System.EventHandler(this.ChangeFontStyle);
            // 
            // size10radioButton
            // 
            this.size10radioButton.AutoSize = true;
            this.size10radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size10radioButton.Location = new System.Drawing.Point(198, 209);
            this.size10radioButton.Name = "size10radioButton";
            this.size10radioButton.Size = new System.Drawing.Size(61, 21);
            this.size10radioButton.TabIndex = 8;
            this.size10radioButton.Text = "10 пт";
            this.size10radioButton.UseVisualStyleBackColor = true;
            this.size10radioButton.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // size12radioButton
            // 
            this.size12radioButton.AutoSize = true;
            this.size12radioButton.Checked = true;
            this.size12radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size12radioButton.Location = new System.Drawing.Point(198, 237);
            this.size12radioButton.Name = "size12radioButton";
            this.size12radioButton.Size = new System.Drawing.Size(61, 21);
            this.size12radioButton.TabIndex = 9;
            this.size12radioButton.TabStop = true;
            this.size12radioButton.Text = "12 пт";
            this.size12radioButton.UseVisualStyleBackColor = true;
            this.size12radioButton.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // size14radioButton
            // 
            this.size14radioButton.AutoSize = true;
            this.size14radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size14radioButton.Location = new System.Drawing.Point(198, 264);
            this.size14radioButton.Name = "size14radioButton";
            this.size14radioButton.Size = new System.Drawing.Size(61, 21);
            this.size14radioButton.TabIndex = 10;
            this.size14radioButton.Text = "14 пт";
            this.size14radioButton.UseVisualStyleBackColor = true;
            this.size14radioButton.CheckedChanged += new System.EventHandler(this.ChangeFontSize);
            // 
            // wordsListBox
            // 
            this.wordsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordsListBox.FormattingEnabled = true;
            this.wordsListBox.ItemHeight = 16;
            this.wordsListBox.Location = new System.Drawing.Point(23, 299);
            this.wordsListBox.Name = "wordsListBox";
            this.wordsListBox.Size = new System.Drawing.Size(301, 68);
            this.wordsListBox.TabIndex = 7;
            this.wordsListBox.SelectedIndexChanged += new System.EventHandler(this.wordsListBox_SelectedIndexChanged);
            // 
            // fontFamilyComboBox
            // 
            this.fontFamilyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontFamilyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fontFamilyComboBox.FormattingEnabled = true;
            this.fontFamilyComboBox.Location = new System.Drawing.Point(137, 160);
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(187, 24);
            this.fontFamilyComboBox.TabIndex = 11;
            this.fontFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(301, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 611);
            this.progressBar1.Maximum = 70;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(301, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // slideShowButton
            // 
            this.slideShowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.slideShowButton.Location = new System.Drawing.Point(106, 659);
            this.slideShowButton.Name = "slideShowButton";
            this.slideShowButton.Size = new System.Drawing.Size(115, 30);
            this.slideShowButton.TabIndex = 12;
            this.slideShowButton.Text = "Слайд-шоу";
            this.slideShowButton.UseVisualStyleBackColor = true;
            this.slideShowButton.Click += new System.EventHandler(this.slideShowButton_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton.Location = new System.Drawing.Point(583, 564);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(122, 30);
            this.openFileButton.TabIndex = 13;
            this.openFileButton.Text = "Открыть файл";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 701);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.slideShowButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fontFamilyComboBox);
            this.Controls.Add(this.wordsListBox);
            this.Controls.Add(this.size14radioButton);
            this.Controls.Add(this.size12radioButton);
            this.Controls.Add(this.size10radioButton);
            this.Controls.Add(this.underlineCheckBox);
            this.Controls.Add(this.italicCheckBox);
            this.Controls.Add(this.boldCheckBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captionLabel);
            this.Name = "MainForm";
            this.Text = "Элементы управления";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox boldCheckBox;
        private System.Windows.Forms.CheckBox italicCheckBox;
        private System.Windows.Forms.CheckBox underlineCheckBox;
        private System.Windows.Forms.RadioButton size10radioButton;
        private System.Windows.Forms.RadioButton size12radioButton;
        private System.Windows.Forms.RadioButton size14radioButton;
        private System.Windows.Forms.ListBox wordsListBox;
        private System.Windows.Forms.ComboBox fontFamilyComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button slideShowButton;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

