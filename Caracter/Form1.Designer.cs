namespace Caracter
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
            excludeATextBox = new TextBox();
            doubleATextBox = new TextBox();
            tripleATextBox = new TextBox();
            SuspendLayout();
            // 
            // excludeATextBox
            // 
            excludeATextBox.Location = new Point(54, 68);
            excludeATextBox.Name = "excludeATextBox";
            excludeATextBox.Size = new Size(600, 31);
            excludeATextBox.TabIndex = 0;
            excludeATextBox.TextChanged += excludeATextBox_TextChanged;
            // 
            // doubleATextBox
            // 
            doubleATextBox.Location = new Point(54, 131);
            doubleATextBox.Name = "doubleATextBox";
            doubleATextBox.Size = new Size(600, 31);
            doubleATextBox.TabIndex = 1;
            // 
            // tripleATextBox
            // 
            tripleATextBox.Location = new Point(54, 198);
            tripleATextBox.Name = "tripleATextBox";
            tripleATextBox.Size = new Size(600, 31);
            tripleATextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tripleATextBox);
            Controls.Add(doubleATextBox);
            Controls.Add(excludeATextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox excludeATextBox;
        private TextBox doubleATextBox;
        private TextBox tripleATextBox;
    }
}
