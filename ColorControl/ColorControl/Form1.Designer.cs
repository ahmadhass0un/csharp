namespace ColorControl
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numericUpDownAlpha = new NumericUpDown();
            numericUpDownGreen = new NumericUpDown();
            numericUpDownBlue = new NumericUpDown();
            numericUpDownRed = new NumericUpDown();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlpha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(290, 485);
            button1.Name = "button1";
            button1.Size = new Size(404, 51);
            button1.TabIndex = 0;
            button1.Text = "Set Color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 296);
            label1.Name = "label1";
            label1.Size = new Size(77, 46);
            label1.TabIndex = 6;
            label1.Text = "Red";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 296);
            label2.Name = "label2";
            label2.Size = new Size(110, 46);
            label2.TabIndex = 7;
            label2.Text = "Green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 296);
            label3.Name = "label3";
            label3.Size = new Size(84, 46);
            label3.TabIndex = 8;
            label3.Text = "Blue";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(807, 296);
            label4.Name = "label4";
            label4.Size = new Size(106, 46);
            label4.TabIndex = 9;
            label4.Text = "Alpha";
            // 
            // numericUpDownAlpha
            // 
            numericUpDownAlpha.Location = new Point(792, 379);
            numericUpDownAlpha.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownAlpha.Name = "numericUpDownAlpha";
            numericUpDownAlpha.Size = new Size(138, 51);
            numericUpDownAlpha.TabIndex = 1;
            numericUpDownAlpha.Value = new decimal(new int[] { 255, 0, 0, 0 });
            // 
            // numericUpDownGreen
            // 
            numericUpDownGreen.Location = new Point(320, 379);
            numericUpDownGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownGreen.Name = "numericUpDownGreen";
            numericUpDownGreen.Size = new Size(138, 51);
            numericUpDownGreen.TabIndex = 11;
            // 
            // numericUpDownBlue
            // 
            numericUpDownBlue.Location = new Point(556, 379);
            numericUpDownBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownBlue.Name = "numericUpDownBlue";
            numericUpDownBlue.Size = new Size(138, 51);
            numericUpDownBlue.TabIndex = 12;
            // 
            // numericUpDownRed
            // 
            numericUpDownRed.Location = new Point(86, 379);
            numericUpDownRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDownRed.Name = "numericUpDownRed";
            numericUpDownRed.Size = new Size(138, 51);
            numericUpDownRed.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(418, 33);
            label5.Name = "label5";
            label5.Size = new Size(195, 46);
            label5.TabIndex = 14;
            label5.Text = "Color Mixer";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(337, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 166);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 576);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(numericUpDownRed);
            Controls.Add(numericUpDownBlue);
            Controls.Add(numericUpDownGreen);
            Controls.Add(numericUpDownAlpha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownAlpha).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownAlpha;
        private NumericUpDown numericUpDownGreen;
        private NumericUpDown numericUpDownBlue;
        private NumericUpDown numericUpDownRed;
        private Label label5;
        private PictureBox pictureBox1;
    }
}
