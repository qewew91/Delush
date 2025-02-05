namespace Sir_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            countButton = new Button();
            phraseTextBox = new TextBox();
            wordTextBox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // countButton
            // 
            countButton.Location = new Point(26, 131);
            countButton.Name = "countButton";
            countButton.Size = new Size(112, 34);
            countButton.TabIndex = 0;
            countButton.Text = "numara";
            countButton.UseVisualStyleBackColor = true;
            countButton.Click += countButton_Click;
            // 
            // phraseTextBox
            // 
            phraseTextBox.Location = new Point(26, 54);
            phraseTextBox.Name = "phraseTextBox";
            phraseTextBox.Size = new Size(606, 31);
            phraseTextBox.TabIndex = 1;
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(638, 54);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(150, 31);
            wordTextBox.TabIndex = 2;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(26, 304);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(wordTextBox);
            Controls.Add(phraseTextBox);
            Controls.Add(countButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button countButton;
        private TextBox phraseTextBox;
        private TextBox wordTextBox;
        private Label resultLabel;
    }
}
