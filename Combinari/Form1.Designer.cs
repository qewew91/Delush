namespace Combinari
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
            nTextBox = new TextBox();
            mTextBox = new TextBox();
            calcButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // nTextBox
            // 
            nTextBox.Location = new Point(25, 17);
            nTextBox.Name = "nTextBox";
            nTextBox.Size = new Size(150, 31);
            nTextBox.TabIndex = 0;
            // 
            // mTextBox
            // 
            mTextBox.Location = new Point(513, 17);
            mTextBox.Name = "mTextBox";
            mTextBox.Size = new Size(150, 31);
            mTextBox.TabIndex = 1;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(25, 81);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(202, 34);
            calcButton.TabIndex = 2;
            calcButton.Text = "calculeaza combinarile";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(25, 208);
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
            Controls.Add(calcButton);
            Controls.Add(mTextBox);
            Controls.Add(nTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nTextBox;
        private TextBox mTextBox;
        private Button calcButton;
        private Label resultLabel;
    }
}
