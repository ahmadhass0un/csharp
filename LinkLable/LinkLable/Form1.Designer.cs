namespace LinkLable
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
            linkLabelGoogle = new LinkLabel();
            linkTHM = new LinkLabel();
            linkLabelHackTheBox = new LinkLabel();
            SuspendLayout();
            // 
            // linkLabelGoogle
            // 
            linkLabelGoogle.AutoSize = true;
            linkLabelGoogle.Location = new Point(517, 203);
            linkLabelGoogle.Name = "linkLabelGoogle";
            linkLabelGoogle.Size = new Size(141, 50);
            linkLabelGoogle.TabIndex = 0;
            linkLabelGoogle.TabStop = true;
            linkLabelGoogle.Text = "Google";
            linkLabelGoogle.LinkClicked += linkLabelGoogle_LinkClicked;
            // 
            // linkTHM
            // 
            linkTHM.AutoSize = true;
            linkTHM.Location = new Point(487, 275);
            linkTHM.Name = "linkTHM";
            linkTHM.Size = new Size(201, 50);
            linkTHM.TabIndex = 1;
            linkTHM.TabStop = true;
            linkTHM.Text = "TryHackMe";
            linkTHM.LinkClicked += linkTHM_LinkClicked;
            // 
            // linkLabelHackTheBox
            // 
            linkLabelHackTheBox.AutoSize = true;
            linkLabelHackTheBox.Location = new Point(477, 353);
            linkLabelHackTheBox.Name = "linkLabelHackTheBox";
            linkLabelHackTheBox.Size = new Size(221, 50);
            linkLabelHackTheBox.TabIndex = 2;
            linkLabelHackTheBox.TabStop = true;
            linkLabelHackTheBox.Text = "HackTheBox";
            linkLabelHackTheBox.LinkClicked += linkLabelHackTheBox_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 50F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1175, 601);
            Controls.Add(linkLabelHackTheBox);
            Controls.Add(linkTHM);
            Controls.Add(linkLabelGoogle);
            Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabelGoogle;
        private LinkLabel linkTHM;
        private LinkLabel linkLabelHackTheBox;
    }
}
