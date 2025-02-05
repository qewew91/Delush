namespace Transforma
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
            textBox = new TextBox();
            lowerCaseButton = new Button();
            upperCaseButton = new Button();
            normalButton = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(25, 56);
            textBox.Name = "textBox";
            textBox.Size = new Size(747, 31);
            textBox.TabIndex = 0;
            // 
            // lowerCaseButton
            // 
            lowerCaseButton.Location = new Point(56, 255);
            lowerCaseButton.Name = "lowerCaseButton";
            lowerCaseButton.Size = new Size(112, 34);
            lowerCaseButton.TabIndex = 1;
            lowerCaseButton.Text = "minuscule";
            lowerCaseButton.UseVisualStyleBackColor = true;
            lowerCaseButton.Click += lowerCaseButton_Click;
            // 
            // upperCaseButton
            // 
            upperCaseButton.Location = new Point(331, 255);
            upperCaseButton.Name = "upperCaseButton";
            upperCaseButton.Size = new Size(112, 34);
            upperCaseButton.TabIndex = 2;
            upperCaseButton.Text = "majuscule";
            upperCaseButton.UseVisualStyleBackColor = true;
            upperCaseButton.Click += upperCaseButton_Click;
            // 
            // normalButton
            // 
            normalButton.Location = new Point(613, 255);
            normalButton.Name = "normalButton";
            normalButton.Size = new Size(112, 34);
            normalButton.TabIndex = 3;
            normalButton.Text = "normal";
            normalButton.UseVisualStyleBackColor = true;
            normalButton.Click += normalButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(normalButton);
            Controls.Add(upperCaseButton);
            Controls.Add(lowerCaseButton);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Transforma";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button lowerCaseButton;
        private Button upperCaseButton;
        private Button normalButton;
    }
}
