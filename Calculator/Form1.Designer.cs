namespace Calculator
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
            calculateButton = new Button();
            firstOperandTextBox = new TextBox();
            operationTextBox = new TextBox();
            secondOperandTextBox = new TextBox();
            resultLabel = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(338, 135);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(112, 34);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "calculeaza";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // firstOperandTextBox
            // 
            firstOperandTextBox.Location = new Point(12, 32);
            firstOperandTextBox.Name = "firstOperandTextBox";
            firstOperandTextBox.Size = new Size(349, 31);
            firstOperandTextBox.TabIndex = 1;
            // 
            // operationTextBox
            // 
            operationTextBox.Location = new Point(367, 32);
            operationTextBox.Name = "operationTextBox";
            operationTextBox.Size = new Size(54, 31);
            operationTextBox.TabIndex = 2;
            // 
            // secondOperandTextBox
            // 
            secondOperandTextBox.Location = new Point(427, 32);
            secondOperandTextBox.Name = "secondOperandTextBox";
            secondOperandTextBox.Size = new Size(361, 31);
            secondOperandTextBox.TabIndex = 3;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(12, 268);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 25);
            resultLabel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultLabel);
            Controls.Add(secondOperandTextBox);
            Controls.Add(operationTextBox);
            Controls.Add(firstOperandTextBox);
            Controls.Add(calculateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox firstOperandTextBox;
        private TextBox operationTextBox;
        private TextBox secondOperandTextBox;
        private Label resultLabel;
    }
}
