namespace Mouse
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
            crCrossButton = new Button();
            crHelpButton = new Button();
            crNoDropButton = new Button();
            SuspendLayout();
            // 
            // crCrossButton
            // 
            crCrossButton.Location = new Point(118, 539);
            crCrossButton.Name = "crCrossButton";
            crCrossButton.Size = new Size(112, 34);
            crCrossButton.TabIndex = 0;
            crCrossButton.Text = "crCross";
            crCrossButton.UseVisualStyleBackColor = true;
            crCrossButton.Click += crCrossButton_Click;
            // 
            // crHelpButton
            // 
            crHelpButton.Location = new Point(576, 539);
            crHelpButton.Name = "crHelpButton";
            crHelpButton.Size = new Size(112, 34);
            crHelpButton.TabIndex = 1;
            crHelpButton.Text = "crHelp";
            crHelpButton.UseVisualStyleBackColor = true;
            crHelpButton.Click += crHelpButton_Click;
            // 
            // crNoDropButton
            // 
            crNoDropButton.Location = new Point(1030, 539);
            crNoDropButton.Name = "crNoDropButton";
            crNoDropButton.Size = new Size(112, 34);
            crNoDropButton.TabIndex = 2;
            crNoDropButton.Text = "crNoDrop";
            crNoDropButton.UseVisualStyleBackColor = true;
            crNoDropButton.Click += crNoDropButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1490, 714);
            Controls.Add(crNoDropButton);
            Controls.Add(crHelpButton);
            Controls.Add(crCrossButton);
            Name = "Form1";
            Text = "Mouse";
            ResumeLayout(false);
        }

        #endregion

        private Button crCrossButton;
        private Button crHelpButton;
        private Button crNoDropButton;
    }
}
