namespace Cifre
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
            CounyButton = new Button();
            numberTextBox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // CounyButton
            // 
            CounyButton.Location = new Point(676, 20);
            CounyButton.Name = "CounyButton";
            CounyButton.Size = new Size(112, 34);
            CounyButton.TabIndex = 0;
            CounyButton.Text = "Numara";
            CounyButton.UseVisualStyleBackColor = true;
            CounyButton.Click += CounyButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.Location = new Point(12, 23);
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(658, 31);
            numberTextBox.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(12, 70);
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
            Controls.Add(numberTextBox);
            Controls.Add(CounyButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CounyButton;
        private TextBox numberTextBox;
        private Label resultLabel;
    }
}
