namespace hellofourm
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
            click = new Button();
            label = new Label();
            writeURname = new Label();
            namePlace = new TextBox();
            helloname = new Label();
            SuspendLayout();
            // 
            // click
            // 
            click.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            click.BackColor = Color.Aqua;
            click.Cursor = Cursors.Hand;
            click.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            click.ForeColor = SystemColors.ActiveCaptionText;
            click.Location = new Point(492, 332);
            click.Name = "click";
            click.Size = new Size(267, 100);
            click.TabIndex = 0;
            click.Text = "بعدين كبوس هون";
            click.UseVisualStyleBackColor = false;
            click.Click += button1_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Aqua;
            label.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ActiveCaptionText;
            label.Location = new Point(457, 9);
            label.Name = "label";
            label.Size = new Size(302, 81);
            label.TabIndex = 1;
            label.Text = "برنامج غبي";
            label.Click += label1_Click;
            // 
            // writeURname
            // 
            writeURname.AutoSize = true;
            writeURname.BackColor = Color.Aqua;
            writeURname.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            writeURname.ForeColor = SystemColors.ActiveCaptionText;
            writeURname.Location = new Point(857, 181);
            writeURname.Name = "writeURname";
            writeURname.Size = new Size(317, 54);
            writeURname.TabIndex = 2;
            writeURname.Text = ":كتوب اسمك هون";
            // 
            // namePlace
            // 
            namePlace.Anchor = AnchorStyles.Top;
            namePlace.BorderStyle = BorderStyle.None;
            namePlace.CausesValidation = false;
            namePlace.Location = new Point(445, 194);
            namePlace.Name = "namePlace";
            namePlace.ScrollBars = ScrollBars.Vertical;
            namePlace.Size = new Size(354, 20);
            namePlace.TabIndex = 6;
            namePlace.Text = "هون";
            namePlace.TextAlign = HorizontalAlignment.Center;
            namePlace.TextChanged += textBox1_TextChanged;
            // 
            // helloname
            // 
            helloname.AutoSize = true;
            helloname.BackColor = Color.Aqua;
            helloname.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            helloname.ForeColor = SystemColors.ActiveCaptionText;
            helloname.Location = new Point(478, 478);
            helloname.Name = "helloname";
            helloname.Size = new Size(0, 62);
            helloname.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(helloname);
            Controls.Add(namePlace);
            Controls.Add(writeURname);
            Controls.Add(label);
            Controls.Add(click);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button click;
        private Label label;
        private Label writeURname;
        private TextBox namePlace;
        private Label helloname;
    }
}
