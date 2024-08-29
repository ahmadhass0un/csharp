namespace checkboxes
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
            stupidCheckbox = new CheckBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // stupidCheckbox
            // 
            stupidCheckbox.AutoSize = true;
            stupidCheckbox.Location = new Point(559, 147);
            stupidCheckbox.Margin = new Padding(9, 8, 9, 8);
            stupidCheckbox.Name = "stupidCheckbox";
            stupidCheckbox.Size = new Size(158, 58);
            stupidCheckbox.TabIndex = 0;
            stupidCheckbox.Text = "أنا غبي";
            stupidCheckbox.ThreeState = true;
            stupidCheckbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 42);
            label1.Name = "label1";
            label1.Size = new Size(206, 54);
            label1.TabIndex = 1;
            label1.Text = "اختبار الغباء";
            // 
            // button1
            // 
            button1.Location = new Point(544, 286);
            button1.Name = "button1";
            button1.Size = new Size(182, 81);
            button1.TabIndex = 2;
            button1.Text = "ارسال";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(24F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 560);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(stupidCheckbox);
            Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(9, 8, 9, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox stupidCheckbox;
        private Label label1;
        private Button button1;
    }
}
