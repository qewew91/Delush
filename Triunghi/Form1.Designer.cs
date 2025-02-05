namespace Triunghi
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
            button1 = new Button();
            perimeterLabel = new Label();
            areaLabel = new Label();
            triangleTypeLabel = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 115);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Calculeaza";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // perimeterLabel
            // 
            perimeterLabel.AutoSize = true;
            perimeterLabel.Location = new Point(33, 206);
            perimeterLabel.Name = "perimeterLabel";
            perimeterLabel.Size = new Size(0, 25);
            perimeterLabel.TabIndex = 1;
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new Point(33, 283);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(0, 25);
            areaLabel.TabIndex = 2;
            // 
            // triangleTypeLabel
            // 
            triangleTypeLabel.AutoSize = true;
            triangleTypeLabel.Location = new Point(33, 361);
            triangleTypeLabel.Name = "triangleTypeLabel";
            triangleTypeLabel.Size = new Size(0, 25);
            triangleTypeLabel.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(478, 38);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(triangleTypeLabel);
            Controls.Add(areaLabel);
            Controls.Add(perimeterLabel);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label perimeterLabel;
        private Label areaLabel;
        private Label triangleTypeLabel;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
