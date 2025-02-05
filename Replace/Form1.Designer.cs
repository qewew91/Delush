namespace Replace
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
            replaceTextBox = new TextBox();
            toReplaceTextBox = new TextBox();
            replaceButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // phraseTextBox
            // 
            phraseTextBox.Location = new Point(24, 44);
            phraseTextBox.Name = "phraseTextBox";
            phraseTextBox.Size = new Size(737, 31);
            phraseTextBox.TabIndex = 0;
            // 
            // replaceTextBox
            // 
            replaceTextBox.Location = new Point(24, 100);
            replaceTextBox.Name = "replaceTextBox";
            replaceTextBox.Size = new Size(368, 31);
            replaceTextBox.TabIndex = 1;
            // 
            // toReplaceTextBox
            // 
            toReplaceTextBox.Location = new Point(398, 100);
            toReplaceTextBox.Name = "toReplaceTextBox";
            toReplaceTextBox.Size = new Size(363, 31);
            toReplaceTextBox.TabIndex = 2;
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(24, 156);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(112, 34);
            replaceButton.TabIndex = 3;
            replaceButton.Text = "Replace";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += replaceButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(24, 296);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(replaceButton);
            Controls.Add(toReplaceTextBox);
            Controls.Add(replaceTextBox);
            Controls.Add(phraseTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox phraseTextBox;
        private TextBox replaceTextBox;
        private TextBox toReplaceTextBox;
        private Button replaceButton;
        private Label resultLabel;
    }
}
