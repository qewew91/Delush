namespace Litere
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
            excludeButton = new Button();
            arrayTextBox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // excludeButton
            // 
            excludeButton.Location = new Point(676, 12);
            excludeButton.Name = "excludeButton";
            excludeButton.Size = new Size(112, 34);
            excludeButton.TabIndex = 0;
            excludeButton.Text = "exclude";
            excludeButton.UseVisualStyleBackColor = true;
            excludeButton.Click += excludeButton_Click;
            // 
            // arrayTextBox
            // 
            arrayTextBox.Location = new Point(22, 12);
            arrayTextBox.Name = "arrayTextBox";
            arrayTextBox.Size = new Size(648, 31);
            arrayTextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(22, 69);
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
            Controls.Add(arrayTextBox);
            Controls.Add(excludeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button excludeButton;
        private TextBox arrayTextBox;
        private Label resultLabel;
    }
}
