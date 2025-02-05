namespace Logare
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
            nameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            resultTextBox = new TextBox();
            validationButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(115, 161);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 31);
            nameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(350, 161);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(150, 31);
            passwordTextBox.TabIndex = 1;
            // 
            // resultTextBox
            // 
            resultTextBox.Location = new Point(576, 161);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.ReadOnly = true;
            resultTextBox.Size = new Size(435, 31);
            resultTextBox.TabIndex = 2;
            // 
            // validationButton
            // 
            validationButton.Location = new Point(115, 314);
            validationButton.Name = "validationButton";
            validationButton.Size = new Size(112, 34);
            validationButton.TabIndex = 3;
            validationButton.Text = "Validare";
            validationButton.UseVisualStyleBackColor = true;
            validationButton.Click += validationButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 604);
            Controls.Add(validationButton);
            Controls.Add(resultTextBox);
            Controls.Add(passwordTextBox);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox passwordTextBox;
        private TextBox resultTextBox;
        private Button validationButton;
    }
}
