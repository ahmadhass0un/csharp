namespace OpenFileDialog
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
            labelName = new Label();
            textBoxName = new TextBox();
            textBoxPath = new TextBox();
            labelPath = new Label();
            textBoxExtFile = new TextBox();
            labelEXt = new Label();
            buttonOpenFile = new Button();
            OFD = new System.Windows.Forms.OpenFileDialog();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(131, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(116, 46);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(320, 68);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(549, 51);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(320, 155);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(549, 51);
            textBoxPath.TabIndex = 3;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(131, 155);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(93, 46);
            labelPath.TabIndex = 2;
            labelPath.Text = "Path:";
            // 
            // textBoxExtFile
            // 
            textBoxExtFile.Location = new Point(320, 242);
            textBoxExtFile.Name = "textBoxExtFile";
            textBoxExtFile.Size = new Size(549, 51);
            textBoxExtFile.TabIndex = 5;
            // 
            // labelEXt
            // 
            labelEXt.AutoSize = true;
            labelEXt.Location = new Point(131, 242);
            labelEXt.Name = "labelEXt";
            labelEXt.Size = new Size(126, 46);
            labelEXt.TabIndex = 4;
            labelEXt.Text = "Ext file:";
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Location = new Point(364, 366);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(272, 90);
            buttonOpenFile.TabIndex = 6;
            buttonOpenFile.Text = "Open File";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // OFD
            // 
            OFD.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 560);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBoxExtFile);
            Controls.Add(labelEXt);
            Controls.Add(textBoxPath);
            Controls.Add(labelPath);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private TextBox textBoxPath;
        private Label labelPath;
        private TextBox textBoxExtFile;
        private Label labelEXt;
        private Button buttonOpenFile;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}
