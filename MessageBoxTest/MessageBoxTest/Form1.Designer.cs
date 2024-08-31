namespace MessageBoxTest
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
            buttonMB = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonMB
            // 
            buttonMB.Location = new Point(337, 115);
            buttonMB.Name = "buttonMB";
            buttonMB.Size = new Size(294, 80);
            buttonMB.TabIndex = 0;
            buttonMB.Text = "MessageBox";
            buttonMB.UseVisualStyleBackColor = true;
            buttonMB.Click += buttonMB_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 233);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 484);
            Controls.Add(label1);
            Controls.Add(buttonMB);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonMB;
        private Label label1;
    }
}
