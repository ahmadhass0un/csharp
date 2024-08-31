namespace ColorDialogs
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
            color = new ColorDialog();
            buttonSelectColor = new Button();
            labelColor = new Label();
            labelRGB = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSelectColor
            // 
            buttonSelectColor.Location = new Point(283, 12);
            buttonSelectColor.Name = "buttonSelectColor";
            buttonSelectColor.Size = new Size(232, 74);
            buttonSelectColor.TabIndex = 0;
            buttonSelectColor.Text = "Select Color";
            buttonSelectColor.UseVisualStyleBackColor = true;
            buttonSelectColor.Click += buttonSelectColor_Click;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(422, 110);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(0, 46);
            labelColor.TabIndex = 1;
            // 
            // labelRGB
            // 
            labelRGB.AutoSize = true;
            labelRGB.Location = new Point(422, 180);
            labelRGB.Name = "labelRGB";
            labelRGB.Size = new Size(0, 46);
            labelRGB.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 315);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 110);
            label1.Name = "label1";
            label1.Size = new Size(108, 46);
            label1.TabIndex = 4;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 180);
            label2.Name = "label2";
            label2.Size = new Size(89, 46);
            label2.TabIndex = 5;
            label2.Text = "RGB:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 382);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(labelRGB);
            Controls.Add(labelColor);
            Controls.Add(buttonSelectColor);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog color;
        private Button buttonSelectColor;
        private Label labelColor;
        private Label labelRGB;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
