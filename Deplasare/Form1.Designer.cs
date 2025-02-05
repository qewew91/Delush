namespace Deplasare
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
            rightButton = new Button();
            upButton = new Button();
            downButton = new Button();
            leftButton = new Button();
            SuspendLayout();
            // 
            // rightButton
            // 
            rightButton.Location = new Point(666, 317);
            rightButton.Name = "rightButton";
            rightButton.Size = new Size(112, 34);
            rightButton.TabIndex = 0;
            rightButton.Text = "dreapta";
            rightButton.UseVisualStyleBackColor = true;
            rightButton.Click += rightButton_Click;
            // 
            // upButton
            // 
            upButton.Location = new Point(330, 317);
            upButton.Name = "upButton";
            upButton.Size = new Size(112, 34);
            upButton.TabIndex = 1;
            upButton.Text = "sus";
            upButton.UseVisualStyleBackColor = true;
            upButton.Click += upButton_Click;
            // 
            // downButton
            // 
            downButton.Location = new Point(490, 317);
            downButton.Name = "downButton";
            downButton.Size = new Size(112, 34);
            downButton.TabIndex = 2;
            downButton.Text = "jos";
            downButton.UseVisualStyleBackColor = true;
            downButton.Click += downButton_Click;
            // 
            // leftButton
            // 
            leftButton.Location = new Point(177, 317);
            leftButton.Name = "leftButton";
            leftButton.Size = new Size(112, 34);
            leftButton.TabIndex = 3;
            leftButton.Text = "stanga";
            leftButton.UseVisualStyleBackColor = true;
            leftButton.Click += leftButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 625);
            Controls.Add(leftButton);
            Controls.Add(downButton);
            Controls.Add(upButton);
            Controls.Add(rightButton);
            Name = "Form1";
            Text = "Deplasare";
            ResumeLayout(false);
        }

        #endregion

        private Button rightButton;
        private Button upButton;
        private Button downButton;
        private Button leftButton;
    }
}
