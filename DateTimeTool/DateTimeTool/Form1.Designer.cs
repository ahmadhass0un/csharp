namespace DateTimeTool
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
            dateTimePicker1 = new DateTimePicker();
            buttonGO2 = new Button();
            button1 = new Button();
            label1 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(526, 51);
            dateTimePicker1.TabIndex = 0;
            // 
            // buttonGO2
            // 
            buttonGO2.Location = new Point(12, 341);
            buttonGO2.Name = "buttonGO2";
            buttonGO2.Size = new Size(246, 109);
            buttonGO2.TabIndex = 1;
            buttonGO2.Text = "Go 2";
            buttonGO2.UseVisualStyleBackColor = true;
            buttonGO2.Click += buttonGO2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 101);
            button1.Name = "button1";
            button1.Size = new Size(246, 109);
            button1.TabIndex = 2;
            button1.Text = "Go 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(390, 133);
            label1.Name = "label1";
            label1.Size = new Size(0, 46);
            label1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(12, 263);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(526, 51);
            dateTimePicker2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(390, 373);
            label2.Name = "label2";
            label2.Size = new Size(0, 46);
            label2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 590);
            Controls.Add(label2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(buttonGO2);
            Controls.Add(dateTimePicker1);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button buttonGO2;
        private Button button1;
        private Label label1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
    }
}
