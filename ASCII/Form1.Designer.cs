namespace ASCII
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
            showButton = new Button();
            resultLabel = new Label();
            charTextBox = new TextBox();
            SuspendLayout();
            // 
            // showButton
            // 
            showButton.Location = new Point(676, 9);
            showButton.Name = "showButton";
            showButton.Size = new Size(112, 34);
            showButton.TabIndex = 0;
            showButton.Text = "arata";
            showButton.UseVisualStyleBackColor = true;
            showButton.Click += showButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(12, 88);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 1;
            // 
            // charTextBox
            // 
            charTextBox.Location = new Point(12, 12);
            charTextBox.Name = "charTextBox";
            charTextBox.Size = new Size(658, 31);
            charTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(charTextBox);
            Controls.Add(resultLabel);
            Controls.Add(showButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showButton;
        private Label resultLabel;
        private TextBox charTextBox;
    }
}
