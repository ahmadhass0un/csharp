namespace multiFourms
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnClose = new Button();
            frm2BTN = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(482, 34);
            label1.Name = "label1";
            label1.Size = new Size(86, 31);
            label1.TabIndex = 1;
            label1.Text = "form 3";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(412, 182);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(256, 125);
            btnClose.TabIndex = 3;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frm2BTN
            // 
            frm2BTN.Location = new Point(412, 334);
            frm2BTN.Name = "frm2BTN";
            frm2BTN.Size = new Size(256, 125);
            frm2BTN.TabIndex = 4;
            frm2BTN.Text = "go to form 2";
            frm2BTN.UseVisualStyleBackColor = true;
            frm2BTN.Click += frm2BTN_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 538);
            Controls.Add(frm2BTN);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Button frm2BTN;
    }
}