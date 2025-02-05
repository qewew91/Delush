namespace Cuvant_maxim
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
            determineButton = new Button();
            wordsTextBox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // determineButton
            // 
            determineButton.Location = new Point(676, 12);
            determineButton.Name = "determineButton";
            determineButton.Size = new Size(112, 34);
            determineButton.TabIndex = 0;
            determineButton.Text = "Determina";
            determineButton.UseVisualStyleBackColor = true;
            determineButton.Click += determineButton_Click;
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
            resultLabel.Location = new Point(12, 73);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(wordsTextBox);
            Controls.Add(determineButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button determineButton;
        private TextBox wordsTextBox;
        private Label resultLabel;
    }
}
