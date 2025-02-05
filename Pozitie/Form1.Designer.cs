namespace Pozitie
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
            leftUpperCornerButton = new Button();
            rightUpperCornerButton = new Button();
            centerButton = new Button();
            rightLowerCornerButton = new Button();
            leftLowerCornerButton = new Button();
            moveButton = new Button();
            SuspendLayout();
            // 
            // leftUpperCornerButton
            // 
            leftUpperCornerButton.Location = new Point(70, 210);
            leftUpperCornerButton.Name = "leftUpperCornerButton";
            leftUpperCornerButton.Size = new Size(112, 34);
            leftUpperCornerButton.TabIndex = 0;
            leftUpperCornerButton.Text = "stanga sus";
            leftUpperCornerButton.UseVisualStyleBackColor = true;
            leftUpperCornerButton.Click += leftUpperCornerButton_Click;
            // 
            // rightUpperCornerButton
            // 
            rightUpperCornerButton.Location = new Point(315, 210);
            rightUpperCornerButton.Name = "rightUpperCornerButton";
            rightUpperCornerButton.Size = new Size(112, 34);
            rightUpperCornerButton.TabIndex = 1;
            rightUpperCornerButton.Text = "dreapta sus";
            rightUpperCornerButton.UseVisualStyleBackColor = true;
            rightUpperCornerButton.Click += rightUpperCornerButton_Click;
            // 
            // centerButton
            // 
            centerButton.Location = new Point(556, 210);
            centerButton.Name = "centerButton";
            centerButton.Size = new Size(112, 34);
            centerButton.TabIndex = 2;
            centerButton.Text = "centru";
            centerButton.UseVisualStyleBackColor = true;
            centerButton.Click += centerButton_Click;
            // 
            // rightLowerCornerButton
            // 
            rightLowerCornerButton.Location = new Point(789, 210);
            rightLowerCornerButton.Name = "rightLowerCornerButton";
            rightLowerCornerButton.Size = new Size(112, 34);
            rightLowerCornerButton.TabIndex = 3;
            rightLowerCornerButton.Text = "dreapta jos";
            rightLowerCornerButton.UseVisualStyleBackColor = true;
            rightLowerCornerButton.Click += rightLowerCornerButton_Click;
            // 
            // leftLowerCornerButton
            // 
            leftLowerCornerButton.Location = new Point(1067, 210);
            leftLowerCornerButton.Name = "leftLowerCornerButton";
            leftLowerCornerButton.Size = new Size(112, 34);
            leftLowerCornerButton.TabIndex = 4;
            leftLowerCornerButton.Text = "stanga jos";
            leftLowerCornerButton.UseVisualStyleBackColor = true;
            leftLowerCornerButton.Click += leftLowerCornerButton_Click;
            // 
            // moveButton
            // 
            moveButton.Location = new Point(556, 325);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(112, 34);
            moveButton.TabIndex = 5;
            moveButton.Text = "deplasare";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += moveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 450);
            Controls.Add(moveButton);
            Controls.Add(leftLowerCornerButton);
            Controls.Add(rightLowerCornerButton);
            Controls.Add(centerButton);
            Controls.Add(rightUpperCornerButton);
            Controls.Add(leftUpperCornerButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button leftUpperCornerButton;
        private Button rightUpperCornerButton;
        private Button centerButton;
        private Button rightLowerCornerButton;
        private Button leftLowerCornerButton;
        private Button moveButton;
    }
}
