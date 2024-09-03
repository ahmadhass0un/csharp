namespace ListBoxes
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
            listCity = new ListBox();
            textBox1 = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonRemoveAll = new Button();
            buttonShowSelected = new Button();
            SuspendLayout();
            // 
            // listCity
            // 
            listCity.FormattingEnabled = true;
            listCity.ItemHeight = 45;
            listCity.Items.AddRange(new object[] { "Aleppo", "Idlib", "Hama", "Hasaka", "Damascus" });
            listCity.Location = new Point(69, 65);
            listCity.Name = "listCity";
            listCity.Size = new Size(259, 454);
            listCity.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 65);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(361, 51);
            textBox1.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(402, 168);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(269, 83);
            buttonAdd.TabIndex = 2;
            buttonAdd.Text = "Add City";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += button1_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(402, 261);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(269, 83);
            buttonRemove.TabIndex = 3;
            buttonRemove.Text = "Remove City";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonRemoveAll
            // 
            buttonRemoveAll.Location = new Point(402, 354);
            buttonRemoveAll.Name = "buttonRemoveAll";
            buttonRemoveAll.Size = new Size(269, 83);
            buttonRemoveAll.TabIndex = 4;
            buttonRemoveAll.Text = "Remove All";
            buttonRemoveAll.UseVisualStyleBackColor = true;
            buttonRemoveAll.Click += buttonRemoveAll_Click;
            // 
            // buttonShowSelected
            // 
            buttonShowSelected.Location = new Point(402, 450);
            buttonShowSelected.Name = "buttonShowSelected";
            buttonShowSelected.Size = new Size(269, 83);
            buttonShowSelected.TabIndex = 5;
            buttonShowSelected.Text = "Show Selected";
            buttonShowSelected.UseVisualStyleBackColor = true;
            buttonShowSelected.Click += buttonShowSelected_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 587);
            Controls.Add(buttonShowSelected);
            Controls.Add(buttonRemoveAll);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBox1);
            Controls.Add(listCity);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCity;
        private TextBox textBox1;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonRemoveAll;
        private Button buttonShowSelected;
    }
}
