namespace RemoveControls
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
            labelHeader = new Label();
            labelname = new Label();
            labelNumber = new Label();
            labelAddress = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            SuspendLayout();
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.Location = new Point(460, 42);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(129, 46);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Header";
            // 
            // labelname
            // 
            labelname.AutoSize = true;
            labelname.Location = new Point(220, 169);
            labelname.Name = "labelname";
            labelname.Size = new Size(109, 46);
            labelname.TabIndex = 1;
            labelname.Text = "Name";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(220, 234);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(143, 46);
            labelNumber.TabIndex = 2;
            labelNumber.Text = "Number";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(220, 306);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(140, 46);
            labelAddress.TabIndex = 3;
            labelAddress.Text = "Address";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(375, 164);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(349, 51);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(375, 234);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(349, 51);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(375, 306);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(349, 51);
            textBox3.TabIndex = 6;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(280, 422);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(199, 63);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(574, 422);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(199, 63);
            buttonRemove.TabIndex = 8;
            buttonRemove.Text = "Remove";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1048, 582);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelAddress);
            Controls.Add(labelNumber);
            Controls.Add(labelname);
            Controls.Add(labelHeader);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelHeader;
        private Label labelname;
        private Label labelNumber;
        private Label labelAddress;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonAdd;
        private Button buttonRemove;
    }
}
