namespace ShortCourseTraining.UserControls.User
{
    partial class StudentDashBoard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOption = new System.Windows.Forms.Panel();
            this.panelBanner = new System.Windows.Forms.Panel();
            this.labelSTID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControls = new System.Windows.Forms.Panel();
            this.iconButtonLogOut = new FontAwesome.Sharp.IconButton();
            this.iconButtonDashboard = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButtonInfo = new FontAwesome.Sharp.IconButton();
            this.iconButtonSecurity = new FontAwesome.Sharp.IconButton();
            this.roundPictureBoxStudent = new ShortCourseTraining.Model.RoundPictureBox();
            this.panelOption.SuspendLayout();
            this.panelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.BackColor = System.Drawing.Color.FloralWhite;
            this.panelOption.Controls.Add(this.iconButtonSecurity);
            this.panelOption.Controls.Add(this.iconButtonInfo);
            this.panelOption.Controls.Add(this.iconButton1);
            this.panelOption.Controls.Add(this.iconButtonDashboard);
            this.panelOption.Controls.Add(this.iconButtonLogOut);
            this.panelOption.Controls.Add(this.panelBanner);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(313, 454);
            this.panelOption.TabIndex = 0;
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelBanner.Controls.Add(this.labelSTID);
            this.panelBanner.Controls.Add(this.label3);
            this.panelBanner.Controls.Add(this.labelUsername);
            this.panelBanner.Controls.Add(this.label1);
            this.panelBanner.Controls.Add(this.roundPictureBoxStudent);
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(313, 100);
            this.panelBanner.TabIndex = 0;
            // 
            // labelSTID
            // 
            this.labelSTID.AutoSize = true;
            this.labelSTID.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTID.Location = new System.Drawing.Point(151, 79);
            this.labelSTID.Name = "labelSTID";
            this.labelSTID.Size = new System.Drawing.Size(31, 13);
            this.labelSTID.TabIndex = 4;
            this.labelSTID.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID :";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(135, 32);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(62, 23);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // panelControls
            // 
            this.panelControls.AutoScroll = true;
            this.panelControls.BackColor = System.Drawing.Color.FloralWhite;
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(313, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(687, 454);
            this.panelControls.TabIndex = 1;
            // 
            // iconButtonLogOut
            // 
            this.iconButtonLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonLogOut.FlatAppearance.BorderSize = 0;
            this.iconButtonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLogOut.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButtonLogOut.IconColor = System.Drawing.Color.Black;
            this.iconButtonLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLogOut.IconSize = 38;
            this.iconButtonLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonLogOut.Location = new System.Drawing.Point(0, 407);
            this.iconButtonLogOut.Name = "iconButtonLogOut";
            this.iconButtonLogOut.Size = new System.Drawing.Size(313, 47);
            this.iconButtonLogOut.TabIndex = 1;
            this.iconButtonLogOut.Text = "Log out";
            this.iconButtonLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLogOut.UseVisualStyleBackColor = false;
            this.iconButtonLogOut.Click += new System.EventHandler(this.iconButtonLogOut_Click);
            // 
            // iconButtonDashboard
            // 
            this.iconButtonDashboard.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconButtonDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonDashboard.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDashboard.IconChar = FontAwesome.Sharp.IconChar.Chalkboard;
            this.iconButtonDashboard.IconColor = System.Drawing.Color.Black;
            this.iconButtonDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDashboard.IconSize = 28;
            this.iconButtonDashboard.Location = new System.Drawing.Point(0, 100);
            this.iconButtonDashboard.Name = "iconButtonDashboard";
            this.iconButtonDashboard.Size = new System.Drawing.Size(313, 48);
            this.iconButtonDashboard.TabIndex = 3;
            this.iconButtonDashboard.Text = "Dashboard";
            this.iconButtonDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDashboard.UseVisualStyleBackColor = false;
            this.iconButtonDashboard.Click += new System.EventHandler(this.iconButtonDashboard_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 28;
            this.iconButton1.Location = new System.Drawing.Point(0, 148);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(313, 48);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "User info";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButtonInfo
            // 
            this.iconButtonInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.iconButtonInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonInfo.FlatAppearance.BorderSize = 0;
            this.iconButtonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonInfo.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.iconButtonInfo.IconColor = System.Drawing.Color.Black;
            this.iconButtonInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonInfo.IconSize = 28;
            this.iconButtonInfo.Location = new System.Drawing.Point(0, 196);
            this.iconButtonInfo.Name = "iconButtonInfo";
            this.iconButtonInfo.Size = new System.Drawing.Size(313, 48);
            this.iconButtonInfo.TabIndex = 5;
            this.iconButtonInfo.Text = "Info";
            this.iconButtonInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonInfo.UseVisualStyleBackColor = false;
            this.iconButtonInfo.Visible = false;
            this.iconButtonInfo.Click += new System.EventHandler(this.iconButtonInfo_Click);
            // 
            // iconButtonSecurity
            // 
            this.iconButtonSecurity.BackColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButtonSecurity.FlatAppearance.BorderSize = 0;
            this.iconButtonSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSecurity.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSecurity.IconChar = FontAwesome.Sharp.IconChar.ShieldAlt;
            this.iconButtonSecurity.IconColor = System.Drawing.Color.Black;
            this.iconButtonSecurity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSecurity.IconSize = 28;
            this.iconButtonSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButtonSecurity.Location = new System.Drawing.Point(0, 244);
            this.iconButtonSecurity.Name = "iconButtonSecurity";
            this.iconButtonSecurity.Size = new System.Drawing.Size(313, 48);
            this.iconButtonSecurity.TabIndex = 6;
            this.iconButtonSecurity.Text = "Security";
            this.iconButtonSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSecurity.UseVisualStyleBackColor = false;
            this.iconButtonSecurity.Visible = false;
            this.iconButtonSecurity.Click += new System.EventHandler(this.iconButtonSecurity_Click);
            // 
            // roundPictureBoxStudent
            // 
            this.roundPictureBoxStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.roundPictureBoxStudent.Image = global::ShortCourseTraining.Properties.Resources.Border2;
            this.roundPictureBoxStudent.Location = new System.Drawing.Point(0, 0);
            this.roundPictureBoxStudent.Name = "roundPictureBoxStudent";
            this.roundPictureBoxStudent.Size = new System.Drawing.Size(100, 100);
            this.roundPictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxStudent.TabIndex = 0;
            this.roundPictureBoxStudent.TabStop = false;
            // 
            // StudentDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelOption);
            this.Name = "StudentDashBoard";
            this.Size = new System.Drawing.Size(1000, 454);
            this.Load += new System.EventHandler(this.StudentDashBoard_Load);
            this.panelOption.ResumeLayout(false);
            this.panelBanner.ResumeLayout(false);
            this.panelBanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelBanner;
        private Model.RoundPictureBox roundPictureBoxStudent;
        private System.Windows.Forms.Label labelSTID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButtonLogOut;
        private FontAwesome.Sharp.IconButton iconButtonDashboard;
        private FontAwesome.Sharp.IconButton iconButtonSecurity;
        private FontAwesome.Sharp.IconButton iconButtonInfo;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
