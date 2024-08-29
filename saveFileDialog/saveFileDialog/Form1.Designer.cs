namespace saveFileDialog
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
            buttonSave = new Button();
            label1 = new Label();
            textBoxText = new TextBox();
            textBoxFileName = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(438, 501);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(249, 51);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(243, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 54);
            label1.TabIndex = 1;
            label1.Text = "File name:\r\n";
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(5, 79);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(1117, 405);
            textBoxText.TabIndex = 2;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFileName.Location = new Point(451, 16);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(431, 47);
            textBoxFileName.TabIndex = 3;
            textBoxFileName.Text = "Untitled";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(22F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 564);
            Controls.Add(textBoxFileName);
            Controls.Add(textBoxText);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label label1;
        private TextBox textBoxText;
        private TextBox textBoxFileName;
    }
}
