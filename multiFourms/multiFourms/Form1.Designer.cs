namespace multiFourms
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
            label1 = new Label();
            frm2BTN = new Button();
            frm3BTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(469, 25);
            label1.Name = "label1";
            label1.Size = new Size(106, 38);
            label1.TabIndex = 0;
            label1.Text = "form 1";
            // 
            // frm2BTN
            // 
            frm2BTN.Location = new Point(386, 148);
            frm2BTN.Name = "frm2BTN";
            frm2BTN.Size = new Size(256, 125);
            frm2BTN.TabIndex = 1;
            frm2BTN.Text = "go to form 2";
            frm2BTN.UseVisualStyleBackColor = true;
            frm2BTN.Click += button1_Click;
            // 
            // frm3BTN
            // 
            frm3BTN.Location = new Point(386, 315);
            frm3BTN.Name = "frm3BTN";
            frm3BTN.Size = new Size(256, 125);
            frm3BTN.TabIndex = 2;
            frm3BTN.Text = "go to form 3";
            frm3BTN.UseVisualStyleBackColor = true;
            frm3BTN.Click += frm3BTN_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 538);
            Controls.Add(frm3BTN);
            Controls.Add(frm2BTN);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button frm2BTN;
        private Button frm3BTN;
    }
}
