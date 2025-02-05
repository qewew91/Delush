namespace Editare
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
            digitTextBox = new TextBox();
            letterTextBox = new TextBox();
            SuspendLayout();
            // 
            // digitTextBox
            // 
            digitTextBox.Location = new Point(42, 94);
            digitTextBox.Name = "digitTextBox";
            digitTextBox.Size = new Size(701, 31);
            digitTextBox.TabIndex = 0;
            digitTextBox.KeyPress += digitTextBox_KeyPress;
            // 
            // letterTextBox
            // 
            letterTextBox.Location = new Point(42, 243);
            letterTextBox.Name = "letterTextBox";
            letterTextBox.Size = new Size(701, 31);
            letterTextBox.TabIndex = 1;
            letterTextBox.KeyPress += letterTextBox_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(letterTextBox);
            Controls.Add(digitTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox digitTextBox;
        private TextBox letterTextBox;
    }
}
