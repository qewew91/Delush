namespace IncrementareDecrementare
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
            incrementButton = new Button();
            decrementButton = new Button();
            SuspendLayout();
            // 
            // incrementButton
            // 
            incrementButton.Location = new Point(90, 262);
            incrementButton.Name = "incrementButton";
            incrementButton.Size = new Size(193, 34);
            incrementButton.TabIndex = 0;
            incrementButton.Text = "incrementare";
            incrementButton.UseVisualStyleBackColor = true;
            incrementButton.Click += incrementButton_Click;
            // 
            // decrementButton
            // 
            decrementButton.Location = new Point(453, 262);
            decrementButton.Name = "decrementButton";
            decrementButton.Size = new Size(273, 34);
            decrementButton.TabIndex = 1;
            decrementButton.Text = "decrementare";
            decrementButton.UseVisualStyleBackColor = true;
            decrementButton.Click += decrementButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(decrementButton);
            Controls.Add(incrementButton);
            Name = "Form1";
            Text = "0";
            ResumeLayout(false);
        }

        #endregion

        private Button incrementButton;
        private Button decrementButton;
    }
}
