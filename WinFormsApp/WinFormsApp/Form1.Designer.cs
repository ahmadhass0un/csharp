namespace WinFormsApp
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
            clickme = new Button();
            SuspendLayout();
            // 
            // clickme
            // 
            clickme.AllowDrop = true;
            clickme.AutoEllipsis = true;
            clickme.Cursor = Cursors.Hand;
            clickme.ForeColor = Color.Red;
            clickme.Location = new Point(259, 166);
            clickme.Name = "clickme";
            clickme.Size = new Size(205, 72);
            clickme.TabIndex = 0;
            clickme.Text = "click me!";
            clickme.UseVisualStyleBackColor = true;
            clickme.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clickme);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button clickme;
    }
}
