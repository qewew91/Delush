﻿namespace DeplasareSageti
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
            moveLabel = new Label();
            SuspendLayout();
            // 
            // moveLabel
            // 
            moveLabel.AutoSize = true;
            moveLabel.Location = new Point(357, 218);
            moveLabel.Name = "moveLabel";
            moveLabel.Size = new Size(78, 25);
            moveLabel.TabIndex = 1;
            moveLabel.Text = "ma misc";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moveLabel);
            Name = "Form1";
            Text = "Deplasare";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label moveLabel;
    }
}
