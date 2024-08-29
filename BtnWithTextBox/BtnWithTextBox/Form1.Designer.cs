namespace BtnWithTextBox
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
            textBox = new TextBox();
            button = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(121, 80);
            textBox.Name = "textBox";
            textBox.Size = new Size(774, 43);
            textBox.TabIndex = 0;
            // 
            // button
            // 
            button.Location = new Point(291, 177);
            button.Name = "button";
            button.Size = new Size(434, 74);
            button.TabIndex = 1;
            button.Text = "show the hidden stuff";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            button.MouseLeave += button_MouseLeave;
            button.MouseHover += button_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 464);
            Controls.Add(button);
            Controls.Add(textBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button button;
    }
}
