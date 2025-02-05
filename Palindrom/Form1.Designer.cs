namespace Palindrom
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
            checkButton = new Button();
            textBox1 = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // checkButton
            // 
            checkButton.Location = new Point(676, 59);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(112, 34);
            checkButton.TabIndex = 0;
            checkButton.Text = "verifica";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(627, 31);
            textBox1.TabIndex = 1;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(43, 265);
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
            Controls.Add(textBox1);
            Controls.Add(checkButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button checkButton;
        private TextBox textBox1;
        private Label resultLabel;
    }
}
