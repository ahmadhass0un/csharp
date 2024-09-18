namespace RaidoBoxOnPanel
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
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            button1 = new Button();
            SuspendLayout();
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(363, 145);
            radioButtonMale.Margin = new Padding(7);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(115, 50);
            radioButtonMale.TabIndex = 0;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(541, 145);
            radioButtonFemale.Margin = new Padding(7);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(148, 50);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(390, 243);
            button1.Name = "button1";
            button1.Size = new Size(252, 84);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 437);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Button button1;
    }
}
