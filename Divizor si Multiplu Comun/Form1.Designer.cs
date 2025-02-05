namespace Divizor_si_Multiplu_Comun
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            calcButton = new Button();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(63, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(417, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(63, 150);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(112, 34);
            calcButton.TabIndex = 2;
            calcButton.Text = "determina";
            calcButton.UseVisualStyleBackColor = true;
            calcButton.Click += calcButton_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(63, 223);
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
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button calcButton;
        private Label resultLabel;
    }
}
