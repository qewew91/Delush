namespace Sir_1
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
            phraseTextBox = new TextBox();
            wordTextBox = new TextBox();
            searchButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // phraseTextBox
            // 
            phraseTextBox.Location = new Point(118, 73);
            phraseTextBox.Name = "phraseTextBox";
            phraseTextBox.Size = new Size(336, 31);
            phraseTextBox.TabIndex = 0;
            // 
            // wordTextBox
            // 
            wordTextBox.Location = new Point(509, 73);
            wordTextBox.Name = "wordTextBox";
            wordTextBox.Size = new Size(150, 31);
            wordTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(310, 167);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(112, 34);
            searchButton.TabIndex = 2;
            searchButton.Text = "Cauta";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(118, 313);
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
            Controls.Add(searchButton);
            Controls.Add(wordTextBox);
            Controls.Add(phraseTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phraseTextBox;
        private TextBox wordTextBox;
        private Button searchButton;
        private Label resultLabel;
    }
}
