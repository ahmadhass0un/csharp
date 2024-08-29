namespace multiFourms
{
    partial class Form2
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
            btnFrm3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(463, 39);
            label1.Name = "label1";
            label1.Size = new Size(106, 38);
            label1.TabIndex = 1;
            label1.Text = "form 2";
            // 
            // btnClose
            // 
            btnClose.Location = new Point(423, 198);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(190, 85);
            btnClose.TabIndex = 2;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnFrm3
            // 
            btnFrm3.Location = new Point(423, 328);
            btnFrm3.Name = "btnFrm3";
            btnFrm3.Size = new Size(190, 85);
            btnFrm3.TabIndex = 3;
            btnFrm3.Text = "form 3";
            btnFrm3.UseVisualStyleBackColor = true;
            btnFrm3.Click += btnFrm3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(16F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 538);
            Controls.Add(btnFrm3);
            Controls.Add(btnClose);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnClose;
        private Button btnFrm3;
    }
}