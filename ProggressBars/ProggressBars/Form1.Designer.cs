namespace ProggressBars
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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(258, 166);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(520, 29);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(684, 229);
            button1.Name = "button1";
            button1.Size = new Size(94, 71);
            button1.TabIndex = 1;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(258, 229);
            button2.Name = "button2";
            button2.Size = new Size(94, 71);
            button2.TabIndex = 2;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(258, 118);
            progressBar2.MarqueeAnimationSpeed = 50;
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(520, 29);
            progressBar2.Style = ProgressBarStyle.Marquee;
            progressBar2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 550);
            Controls.Add(progressBar2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private ProgressBar progressBar2;
    }
}
