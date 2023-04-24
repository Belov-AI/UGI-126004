namespace Forms
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
            this.openAdditionaiFormButton = new System.Windows.Forms.Button();
            this.closeAdditionalFormButton = new System.Windows.Forms.Button();
            this.questionButtonutton = new System.Windows.Forms.Button();
            this.openContainerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openAdditionaiFormButton
            // 
            this.openAdditionaiFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openAdditionaiFormButton.Location = new System.Drawing.Point(228, 32);
            this.openAdditionaiFormButton.Name = "openAdditionaiFormButton";
            this.openAdditionaiFormButton.Size = new System.Drawing.Size(146, 75);
            this.openAdditionaiFormButton.TabIndex = 0;
            this.openAdditionaiFormButton.Text = "Открыть дополнительное окно";
            this.openAdditionaiFormButton.UseVisualStyleBackColor = true;
            this.openAdditionaiFormButton.Click += new System.EventHandler(this.openAdditionaiFormButton_Click);
            // 
            // closeAdditionalFormButton
            // 
            this.closeAdditionalFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeAdditionalFormButton.Location = new System.Drawing.Point(228, 143);
            this.closeAdditionalFormButton.Name = "closeAdditionalFormButton";
            this.closeAdditionalFormButton.Size = new System.Drawing.Size(146, 75);
            this.closeAdditionalFormButton.TabIndex = 0;
            this.closeAdditionalFormButton.Text = "Закрыть дополнительное окно";
            this.closeAdditionalFormButton.UseVisualStyleBackColor = true;
            this.closeAdditionalFormButton.Click += new System.EventHandler(this.closeAdditionalFormButton_Click);
            // 
            // questionButtonutton
            // 
            this.questionButtonutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionButtonutton.Location = new System.Drawing.Point(228, 259);
            this.questionButtonutton.Name = "questionButtonutton";
            this.questionButtonutton.Size = new System.Drawing.Size(146, 75);
            this.questionButtonutton.TabIndex = 0;
            this.questionButtonutton.Text = "Вопрос";
            this.questionButtonutton.UseVisualStyleBackColor = true;
            this.questionButtonutton.Click += new System.EventHandler(this.questionButtonutton_Click);
            // 
            // openContainerButton
            // 
            this.openContainerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openContainerButton.Location = new System.Drawing.Point(228, 365);
            this.openContainerButton.Name = "openContainerButton";
            this.openContainerButton.Size = new System.Drawing.Size(146, 75);
            this.openContainerButton.TabIndex = 0;
            this.openContainerButton.Text = "Открыть контейнер";
            this.openContainerButton.UseVisualStyleBackColor = true;
            this.openContainerButton.Click += new System.EventHandler(this.openContainerButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 470);
            this.Controls.Add(this.openContainerButton);
            this.Controls.Add(this.questionButtonutton);
            this.Controls.Add(this.closeAdditionalFormButton);
            this.Controls.Add(this.openAdditionaiFormButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "MainForm";
            this.Text = "Формы";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openAdditionaiFormButton;
        private System.Windows.Forms.Button closeAdditionalFormButton;
        private System.Windows.Forms.Button questionButtonutton;
        private System.Windows.Forms.Button openContainerButton;
    }
}

