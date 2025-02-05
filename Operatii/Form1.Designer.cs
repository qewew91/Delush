namespace Operatii
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
            defaultButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // defaultButton
            // 
            defaultButton.Location = new Point(243, 329);
            defaultButton.Name = "defaultButton";
            defaultButton.Size = new Size(369, 34);
            defaultButton.TabIndex = 0;
            defaultButton.Text = "Default";
            defaultButton.UseVisualStyleBackColor = true;
            defaultButton.Click += defaultButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(769, 334);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(112, 34);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 563);
            Controls.Add(cancelButton);
            Controls.Add(defaultButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button defaultButton;
        private Button cancelButton;
    }
}
