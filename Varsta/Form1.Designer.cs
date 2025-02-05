namespace Varsta
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
            calcButton = new Button();
            weightLabel = new Label();
            heightLabel = new Label();
            ageTextBox = new TextBox();
            SuspendLayout();
            // 
            // calcButton
            // 
            calcButton.Location = new Point(676, 12);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(112, 34);
            calcButton.TabIndex = 0;
            calcButton.Text = "determina";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(12, 90);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(0, 25);
            weightLabel.TabIndex = 1;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(12, 246);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(0, 25);
            heightLabel.TabIndex = 2;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(12, 12);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(658, 31);
            ageTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ageTextBox);
            Controls.Add(heightLabel);
            Controls.Add(weightLabel);
            Controls.Add(calcButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calcButton;
        private Label weightLabel;
        private Label heightLabel;
        private TextBox ageTextBox;
    }
}
