namespace Ecuatii
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
            aTextBox = new TextBox();
            bTextBox = new TextBox();
            cTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            linearLabel = new Label();
            quadraticLabel = new Label();
            calcButton = new Button();
            SuspendLayout();
            // 
            // aTextBox
            // 
            aTextBox.Location = new Point(35, 62);
            aTextBox.Name = "aTextBox";
            aTextBox.Size = new Size(45, 31);
            aTextBox.TabIndex = 0;
            // 
            // bTextBox
            // 
            bTextBox.Location = new Point(159, 62);
            bTextBox.Name = "bTextBox";
            bTextBox.Size = new Size(150, 31);
            bTextBox.TabIndex = 1;
            // 
            // cTextBox
            // 
            cTextBox.Location = new Point(363, 62);
            cTextBox.Name = "cTextBox";
            cTextBox.Size = new Size(150, 31);
            cTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 68);
            label1.Name = "label1";
            label1.Size = new Size(64, 25);
            label1.TabIndex = 3;
            label1.Text = "x^2 + ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 65);
            label2.Name = "label2";
            label2.Size = new Size(42, 25);
            label2.TabIndex = 4;
            label2.Text = "x + ";
            // 
            // linearLabel
            // 
            linearLabel.AutoSize = true;
            linearLabel.Location = new Point(35, 142);
            linearLabel.Name = "linearLabel";
            linearLabel.Size = new Size(0, 25);
            linearLabel.TabIndex = 5;
            // 
            // quadraticLabel
            // 
            quadraticLabel.AutoSize = true;
            quadraticLabel.Location = new Point(35, 218);
            quadraticLabel.Name = "quadraticLabel";
            quadraticLabel.Size = new Size(0, 25);
            quadraticLabel.TabIndex = 6;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(676, 56);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(112, 34);
            calcButton.TabIndex = 7;
            calcButton.Text = "Calculeaza";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcButton);
            Controls.Add(quadraticLabel);
            Controls.Add(linearLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cTextBox);
            Controls.Add(bTextBox);
            Controls.Add(aTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox aTextBox;
        private TextBox bTextBox;
        private TextBox cTextBox;
        private Label label1;
        private Label label2;
        private Label linearLabel;
        private Label quadraticLabel;
        private Button calcButton;
    }
}
