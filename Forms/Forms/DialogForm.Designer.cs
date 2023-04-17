namespace Forms
{
    partial class DialogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.qurstionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yesButton
            // 
            this.yesButton.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.yesButton.Location = new System.Drawing.Point(74, 204);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(75, 23);
            this.yesButton.TabIndex = 0;
            this.yesButton.Text = "Да";
            this.yesButton.UseVisualStyleBackColor = true;
            // 
            // noButton
            // 
            this.noButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.noButton.Location = new System.Drawing.Point(208, 204);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(75, 23);
            this.noButton.TabIndex = 1;
            this.noButton.Text = "Нет";
            this.noButton.UseVisualStyleBackColor = true;
            // 
            // qurstionLabel
            // 
            this.qurstionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qurstionLabel.Location = new System.Drawing.Point(43, 42);
            this.qurstionLabel.Name = "qurstionLabel";
            this.qurstionLabel.Size = new System.Drawing.Size(254, 98);
            this.qurstionLabel.TabIndex = 2;
            this.qurstionLabel.Text = "Вы любите кошек?";
            this.qurstionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DialogForm
            // 
            this.AcceptButton = this.yesButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.noButton;
            this.ClientSize = new System.Drawing.Size(350, 267);
            this.Controls.Add(this.qurstionLabel);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "DialogForm";
            this.Text = "Вопрос";
            this.Load += new System.EventHandler(this.DialogForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.Label qurstionLabel;
    }
}