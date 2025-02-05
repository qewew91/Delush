namespace showHide
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
            show = new Button();
            hide = new Button();
            showHide = new Button();
            SuspendLayout();
            // 
            // show
            // 
            show.Location = new Point(81, 517);
            show.Name = "show";
            show.Size = new Size(112, 34);
            show.TabIndex = 0;
            show.Text = "Show";
            show.UseVisualStyleBackColor = true;
            show.Click += button1_Click;
            // 
            // hide
            // 
            hide.Location = new Point(330, 517);
            hide.Name = "hide";
            hide.Size = new Size(112, 34);
            hide.TabIndex = 1;
            hide.Text = "Hide";
            hide.UseVisualStyleBackColor = true;
            hide.Click += hide_Click;
            // 
            // showHide
            // 
            showHide.Location = new Point(765, 517);
            showHide.Name = "showHide";
            showHide.Size = new Size(112, 34);
            showHide.TabIndex = 2;
            showHide.Text = "Show/Hide";
            showHide.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 621);
            Controls.Add(showHide);
            Controls.Add(hide);
            Controls.Add(show);
            Name = "Form1";
            Text = "Show/Hide";
            ResumeLayout(false);
        }

        #endregion

        private Button show;
        private Button hide;
        private Button showHide;
    }
}
