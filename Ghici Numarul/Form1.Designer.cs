namespace Ghici_Numarul
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
            guessButton = new Button();
            resultLabel = new Label();
            guessedNumberTextBox = new TextBox();
            SuspendLayout();
            // 
            // guessButton
            // 
            guessButton.Location = new Point(676, 12);
            guessButton.Name = "guessButton";
            guessButton.Size = new Size(112, 34);
            guessButton.TabIndex = 0;
            guessButton.Text = "Ghici";
            guessButton.UseVisualStyleBackColor = true;
            guessButton.Click += guessButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(12, 108);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 1;
            // 
            // guessedNumberTextBox
            // 
            guessedNumberTextBox.Location = new Point(12, 15);
            guessedNumberTextBox.Name = "guessedNumberTextBox";
            guessedNumberTextBox.Size = new Size(658, 31);
            guessedNumberTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(guessedNumberTextBox);
            Controls.Add(resultLabel);
            Controls.Add(guessButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button guessButton;
        private Label resultLabel;
        private TextBox guessedNumberTextBox;
    }
}
