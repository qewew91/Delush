namespace Inversul
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
            reverseButton = new Button();
            wordsTextBox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // reverseButton
            // 
            reverseButton.Location = new Point(676, 12);
            reverseButton.Name = "reverseButton";
            reverseButton.Size = new Size(112, 34);
            reverseButton.TabIndex = 0;
            reverseButton.Text = "Modifica";
            reverseButton.UseVisualStyleBackColor = true;
            reverseButton.Click += reverseButton_Click;
            // 
            // wordsTextBox
            // 
            wordsTextBox.Location = new Point(12, 12);
            wordsTextBox.Name = "wordsTextBox";
            wordsTextBox.Size = new Size(658, 31);
            wordsTextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(12, 75);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 2;
            resultLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(wordsTextBox);
            Controls.Add(reverseButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reverseButton;
        private TextBox wordsTextBox;
        private Label resultLabel;
    }
}
