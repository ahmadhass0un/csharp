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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(290, 464);
            button1.Name = "button1";
            button1.Size = new Size(404, 51);
            button1.TabIndex = 0;
            button1.Text = "Set Color";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(290, 392);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(404, 51);
            textBox1.TabIndex = 1;
            textBox1.Text = "Test";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(313, 263);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(404, 51);
            textBox2.TabIndex = 2;
            textBox2.Text = "Test";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(321, 271);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(404, 51);
            textBox3.TabIndex = 3;
            textBox3.Text = "Test";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(63, 271);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(179, 51);
            textBox4.TabIndex = 4;
            textBox4.Text = "Test";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 576);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 7, 7, 7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
