namespace DataManagementApp
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
            components = new System.ComponentModel.Container();
            title = new Label();
            textBoxID = new TextBox();
            labelID = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            buttonAddNew = new Button();
            buttonExit = new Button();
            buttonShowAll = new Button();
            buttonFind = new Button();
            toolTipmain = new ToolTip(components);
            buttonSelectPhoto = new Button();
            buttonShowAllWithImages = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Navy;
            title.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(528, 26);
            title.Margin = new Padding(2, 0, 2, 0);
            title.Name = "title";
            title.Size = new Size(252, 54);
            title.TabIndex = 0;
            title.Text = "Person Data";
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            textBoxID.Location = new Point(264, 100);
            textBoxID.Margin = new Padding(2, 3, 2, 3);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(598, 45);
            textBoxID.TabIndex = 1;
            toolTipmain.SetToolTip(textBoxID, "Enter person ID");
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            labelID.Location = new Point(140, 102);
            labelID.Margin = new Padding(2, 0, 2, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(61, 39);
            labelID.TabIndex = 2;
            labelID.Text = "ID:";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            labelName.Location = new Point(85, 185);
            labelName.Margin = new Padding(2, 0, 2, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(117, 39);
            labelName.TabIndex = 4;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            textBoxName.Location = new Point(264, 183);
            textBoxName.Margin = new Padding(2, 3, 2, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(598, 45);
            textBoxName.TabIndex = 3;
            toolTipmain.SetToolTip(textBoxName, "Enter person name");
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            labelAddress.Location = new Point(55, 266);
            labelAddress.Margin = new Padding(2, 0, 2, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(151, 39);
            labelAddress.TabIndex = 6;
            labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Microsoft Sans Serif", 19.8000011F);
            textBoxAddress.Location = new Point(264, 266);
            textBoxAddress.Margin = new Padding(2, 3, 2, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(598, 45);
            textBoxAddress.TabIndex = 5;
            toolTipmain.SetToolTip(textBoxAddress, "Enter person address");
            // 
            // buttonAddNew
            // 
            buttonAddNew.BackColor = Color.CadetBlue;
            buttonAddNew.Cursor = Cursors.Hand;
            buttonAddNew.FlatStyle = FlatStyle.Popup;
            buttonAddNew.ForeColor = Color.White;
            buttonAddNew.Location = new Point(40, 353);
            buttonAddNew.Margin = new Padding(2, 3, 2, 3);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(190, 62);
            buttonAddNew.TabIndex = 7;
            buttonAddNew.Text = "Add New";
            toolTipmain.SetToolTip(buttonAddNew, "Add new person");
            buttonAddNew.UseVisualStyleBackColor = false;
            buttonAddNew.Click += buttonAddNew_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.CadetBlue;
            buttonExit.Cursor = Cursors.Hand;
            buttonExit.FlatStyle = FlatStyle.Popup;
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(741, 353);
            buttonExit.Margin = new Padding(2, 3, 2, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(190, 62);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Exit";
            toolTipmain.SetToolTip(buttonExit, "Exit the program");
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonShowAll
            // 
            buttonShowAll.BackColor = Color.CadetBlue;
            buttonShowAll.Cursor = Cursors.Hand;
            buttonShowAll.FlatStyle = FlatStyle.Popup;
            buttonShowAll.ForeColor = Color.White;
            buttonShowAll.Location = new Point(509, 353);
            buttonShowAll.Margin = new Padding(2, 3, 2, 3);
            buttonShowAll.Name = "buttonShowAll";
            buttonShowAll.Size = new Size(190, 62);
            buttonShowAll.TabIndex = 9;
            buttonShowAll.Text = "Show All";
            toolTipmain.SetToolTip(buttonShowAll, "Show all data");
            buttonShowAll.UseVisualStyleBackColor = false;
            buttonShowAll.Click += buttonShowAll_Click;
            // 
            // buttonFind
            // 
            buttonFind.BackColor = Color.CadetBlue;
            buttonFind.Cursor = Cursors.Hand;
            buttonFind.FlatStyle = FlatStyle.Popup;
            buttonFind.ForeColor = Color.White;
            buttonFind.Location = new Point(273, 353);
            buttonFind.Margin = new Padding(2, 3, 2, 3);
            buttonFind.Name = "buttonFind";
            buttonFind.Size = new Size(190, 62);
            buttonFind.TabIndex = 10;
            buttonFind.Text = "Find";
            toolTipmain.SetToolTip(buttonFind, "Find user by ID");
            buttonFind.UseVisualStyleBackColor = false;
            buttonFind.Click += buttonFind_Click;
            // 
            // toolTipmain
            // 
            toolTipmain.IsBalloon = true;
            toolTipmain.ToolTipIcon = ToolTipIcon.Info;
            // 
            // buttonSelectPhoto
            // 
            buttonSelectPhoto.BackColor = Color.CadetBlue;
            buttonSelectPhoto.Cursor = Cursors.Hand;
            buttonSelectPhoto.FlatStyle = FlatStyle.Popup;
            buttonSelectPhoto.ForeColor = Color.White;
            buttonSelectPhoto.Location = new Point(968, 422);
            buttonSelectPhoto.Margin = new Padding(2, 3, 2, 3);
            buttonSelectPhoto.Name = "buttonSelectPhoto";
            buttonSelectPhoto.Size = new Size(285, 62);
            buttonSelectPhoto.TabIndex = 12;
            buttonSelectPhoto.Text = "Select photo";
            toolTipmain.SetToolTip(buttonSelectPhoto, "Select person photo");
            buttonSelectPhoto.UseVisualStyleBackColor = false;
            buttonSelectPhoto.Click += buttonSelectPhoto_Click;
            // 
            // buttonShowAllWithImages
            // 
            buttonShowAllWithImages.BackColor = Color.CadetBlue;
            buttonShowAllWithImages.Cursor = Cursors.Hand;
            buttonShowAllWithImages.FlatStyle = FlatStyle.Popup;
            buttonShowAllWithImages.ForeColor = Color.White;
            buttonShowAllWithImages.Location = new Point(40, 445);
            buttonShowAllWithImages.Margin = new Padding(2, 3, 2, 3);
            buttonShowAllWithImages.Name = "buttonShowAllWithImages";
            buttonShowAllWithImages.Size = new Size(891, 62);
            buttonShowAllWithImages.TabIndex = 13;
            buttonShowAllWithImages.Text = "Show All with images";
            toolTipmain.SetToolTip(buttonShowAllWithImages, "Show All with images");
            buttonShowAllWithImages.UseVisualStyleBackColor = false;
            buttonShowAllWithImages.Click += buttonShowAllWithImages_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(968, 100);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 285);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(19F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 542);
            Controls.Add(buttonShowAllWithImages);
            Controls.Add(buttonSelectPhoto);
            Controls.Add(pictureBox1);
            Controls.Add(buttonFind);
            Controls.Add(buttonShowAll);
            Controls.Add(buttonExit);
            Controls.Add(buttonAddNew);
            Controls.Add(labelAddress);
            Controls.Add(textBoxAddress);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelID);
            Controls.Add(textBoxID);
            Controls.Add(title);
            Font = new Font("Microsoft Sans Serif", 19.8000011F);
            Margin = new Padding(7, 5, 7, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Data";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox textBoxID;
        private Label labelID;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Button buttonAddNew;
        private Button buttonExit;
        private Button buttonShowAll;
        private Button buttonFind;
        private ToolTip toolTipmain;
        private PictureBox pictureBox1;
        private Button buttonSelectPhoto;
        private Button buttonShowAllWithImages;
    }
}
