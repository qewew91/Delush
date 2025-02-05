namespace Scrie
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
            allowButton = new Button();
            forbidButton = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // allowButton
            // 
            allowButton.Location = new Point(64, 271);
            allowButton.Name = "allowButton";
            allowButton.Size = new Size(112, 34);
            allowButton.TabIndex = 0;
            allowButton.Text = "scrie";
            allowButton.UseVisualStyleBackColor = true;
            allowButton.Click += allowButton_Click;
            // 
            // forbidButton
            // 
            forbidButton.Location = new Point(533, 271);
            forbidButton.Name = "forbidButton";
            forbidButton.Size = new Size(112, 34);
            forbidButton.TabIndex = 1;
            forbidButton.Text = "interzice";
            forbidButton.UseVisualStyleBackColor = true;
            forbidButton.Click += forbidButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(64, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(581, 31);
            textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(forbidButton);
            Controls.Add(allowButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button allowButton;
        private Button forbidButton;
        private TextBox textBox1;
    }
}
