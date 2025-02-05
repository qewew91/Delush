namespace Culoare
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
            redButton = new Button();
            greenButton = new Button();
            yellowButton = new Button();
            blackButton = new Button();
            whiteButton = new Button();
            SuspendLayout();
            // 
            // redButton
            // 
            redButton.Location = new Point(107, 305);
            redButton.Name = "redButton";
            redButton.Size = new Size(112, 34);
            redButton.TabIndex = 0;
            redButton.Text = "rosu";
            redButton.UseVisualStyleBackColor = true;
            redButton.Click += redButton_Click;
            // 
            // greenButton
            // 
            greenButton.Location = new Point(364, 305);
            greenButton.Name = "greenButton";
            greenButton.Size = new Size(112, 34);
            greenButton.TabIndex = 1;
            greenButton.Text = "verde";
            greenButton.UseVisualStyleBackColor = true;
            greenButton.Click += greenButton_Click;
            // 
            // yellowButton
            // 
            yellowButton.Location = new Point(635, 305);
            yellowButton.Name = "yellowButton";
            yellowButton.Size = new Size(112, 34);
            yellowButton.TabIndex = 2;
            yellowButton.Text = "galben";
            yellowButton.UseVisualStyleBackColor = true;
            yellowButton.Click += yellowButton_Click;
            // 
            // blackButton
            // 
            blackButton.Location = new Point(889, 305);
            blackButton.Name = "blackButton";
            blackButton.Size = new Size(112, 34);
            blackButton.TabIndex = 3;
            blackButton.Text = "negru";
            blackButton.UseVisualStyleBackColor = true;
            blackButton.Click += blackButton_Click;
            // 
            // whiteButton
            // 
            whiteButton.Location = new Point(1155, 305);
            whiteButton.Name = "whiteButton";
            whiteButton.Size = new Size(112, 34);
            whiteButton.TabIndex = 4;
            whiteButton.Text = "alb";
            whiteButton.UseVisualStyleBackColor = true;
            whiteButton.Click += whiteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 635);
            Controls.Add(whiteButton);
            Controls.Add(blackButton);
            Controls.Add(yellowButton);
            Controls.Add(greenButton);
            Controls.Add(redButton);
            Name = "Form1";
            Text = "Culoare";
            ResumeLayout(false);
        }

        #endregion

        private Button redButton;
        private Button greenButton;
        private Button yellowButton;
        private Button blackButton;
        private Button whiteButton;
    }
}
