namespace ListCheckBox
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
            CLBStuff = new CheckedListBox();
            button1 = new Button();
            button2 = new Button();
            labelStuff = new Label();
            title = new Label();
            inputBox = new TextBox();
            SuspendLayout();
            // 
            // CLBStuff
            // 
            CLBStuff.CheckOnClick = true;
            CLBStuff.FormattingEnabled = true;
            CLBStuff.Location = new Point(146, 90);
            CLBStuff.Margin = new Padding(5);
            CLBStuff.Name = "CLBStuff";
            CLBStuff.Size = new Size(280, 169);
            CLBStuff.TabIndex = 0;
            CLBStuff.SelectedIndexChanged += CLBStuff_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(146, 310);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(280, 45);
            button1.TabIndex = 1;
            button1.Text = "إظهار";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(745, 169);
            button2.Name = "button2";
            button2.Size = new Size(237, 47);
            button2.TabIndex = 2;
            button2.Text = "إضافة";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // labelStuff
            // 
            labelStuff.AutoSize = true;
            labelStuff.Location = new Point(897, 93);
            labelStuff.Name = "labelStuff";
            labelStuff.Size = new Size(85, 31);
            labelStuff.TabIndex = 3;
            labelStuff.Text = ":الغرض";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(442, 9);
            title.Name = "title";
            title.Size = new Size(168, 41);
            title.TabIndex = 4;
            title.Text = "جيبان غراض";
            // 
            // inputBox
            // 
            inputBox.Location = new Point(745, 90);
            inputBox.Name = "inputBox";
            inputBox.Size = new Size(125, 38);
            inputBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 430);
            Controls.Add(inputBox);
            Controls.Add(title);
            Controls.Add(labelStuff);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(CLBStuff);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox CLBStuff;
        private Button button1;
        private Button button2;
        private Label labelStuff;
        private Label title;
        private TextBox inputBox;
    }
}
