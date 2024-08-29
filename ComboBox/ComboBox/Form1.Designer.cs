namespace ComboBox
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
            comboBox = new System.Windows.Forms.ComboBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // comboBox
            // 
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "aleppo", "idlib", "dara" });
            comboBox.Location = new Point(109, 58);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(683, 45);
            comboBox.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(285, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(331, 77);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "button1";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 420);
            Controls.Add(btnAdd);
            Controls.Add(comboBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private Button btnAdd;
    }
}
