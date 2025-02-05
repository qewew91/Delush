namespace Sistem_de_ecuatii
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
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            xLabel = new Label();
            yLabel = new Label();
            calcButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(56, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(323, 60);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(593, 60);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(56, 129);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(323, 129);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(593, 129);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 64);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 6;
            label1.Text = "x + ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(479, 60);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 7;
            label2.Text = "y = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 135);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 8;
            label3.Text = "x + ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(479, 135);
            label4.Name = "label4";
            label4.Size = new Size(43, 25);
            label4.TabIndex = 9;
            label4.Text = "y + ";
            // 
            // xLabel
            // 
            xLabel.AutoSize = true;
            xLabel.Location = new Point(73, 284);
            xLabel.Name = "xLabel";
            xLabel.Size = new Size(0, 25);
            xLabel.TabIndex = 10;
            // 
            // yLabel
            // 
            yLabel.AutoSize = true;
            yLabel.Location = new Point(73, 341);
            yLabel.Name = "yLabel";
            yLabel.Size = new Size(0, 25);
            yLabel.TabIndex = 11;
            // 
            // calcButton
            // 
            calcButton.Location = new Point(631, 189);
            calcButton.Name = "calcButton";
            calcButton.Size = new Size(112, 34);
            calcButton.TabIndex = 12;
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
            Controls.Add(yLabel);
            Controls.Add(xLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
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
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label xLabel;
        private Label yLabel;
        private Button calcButton;
    }
}
