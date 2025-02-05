namespace CopyPaste
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
            copyButtonRight = new Button();
            copyButtonLeft = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // copyButtonRight
            // 
            copyButtonRight.Location = new Point(181, 195);
            copyButtonRight.Name = "copyButtonRight";
            copyButtonRight.Size = new Size(201, 34);
            copyButtonRight.TabIndex = 0;
            copyButtonRight.Text = "Copie si insereaza";
            copyButtonRight.UseVisualStyleBackColor = true;
            copyButtonRight.Click += copyButtonRight_Click;
            // 
            // copyButtonLeft
            // 
            copyButtonLeft.Location = new Point(673, 195);
            copyButtonLeft.Name = "copyButtonLeft";
            copyButtonLeft.Size = new Size(211, 34);
            copyButtonLeft.TabIndex = 1;
            copyButtonLeft.Text = "Copie si insereaza";
            copyButtonLeft.UseVisualStyleBackColor = true;
            copyButtonLeft.Click += copyButtonLeft_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(181, 140);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(378, 31);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(673, 140);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(414, 31);
            textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1320, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(copyButtonLeft);
            Controls.Add(copyButtonRight);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button copyButtonRight;
        private Button copyButtonLeft;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
