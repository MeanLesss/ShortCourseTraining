namespace ShortCourseTraining
{
    partial class WelcomeForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonCompany = new FontAwesome.Sharp.IconButton();
            this.ButtonUser = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonClose = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCompany
            // 
            this.ButtonCompany.BackColor = System.Drawing.Color.Chocolate;
            this.ButtonCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCompany.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCompany.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ButtonCompany.IconColor = System.Drawing.Color.Black;
            this.ButtonCompany.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonCompany.IconSize = 80;
            this.ButtonCompany.Location = new System.Drawing.Point(121, 190);
            this.ButtonCompany.Name = "ButtonCompany";
            this.ButtonCompany.Size = new System.Drawing.Size(312, 190);
            this.ButtonCompany.TabIndex = 0;
            this.ButtonCompany.Text = "Company";
            this.ButtonCompany.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonCompany.UseVisualStyleBackColor = false;
            this.ButtonCompany.Click += new System.EventHandler(this.ButtonCompany_Click);
            // 
            // ButtonUser
            // 
            this.ButtonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonUser.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUser.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ButtonUser.IconColor = System.Drawing.Color.Chocolate;
            this.ButtonUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonUser.IconSize = 80;
            this.ButtonUser.Location = new System.Drawing.Point(573, 190);
            this.ButtonUser.Name = "ButtonUser";
            this.ButtonUser.Size = new System.Drawing.Size(312, 190);
            this.ButtonUser.TabIndex = 2;
            this.ButtonUser.Text = "User";
            this.ButtonUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("The Richland", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(296, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 99);
            this.label1.TabIndex = 3;
            this.label1.Text = "Short ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("The Richland", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(499, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 99);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course";
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.ButtonClose.IconColor = System.Drawing.Color.Chocolate;
            this.ButtonClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonClose.IconSize = 30;
            this.ButtonClose.Location = new System.Drawing.Point(950, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(50, 40);
            this.ButtonClose.TabIndex = 5;
            this.ButtonClose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ButtonClose.UseVisualStyleBackColor = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(905, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 40);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.label3);
            this.panelWelcome.Controls.Add(this.label1);
            this.panelWelcome.Controls.Add(this.ButtonCompany);
            this.panelWelcome.Controls.Add(this.ButtonUser);
            this.panelWelcome.Controls.Add(this.label2);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelWelcome.Location = new System.Drawing.Point(0, 46);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1000, 454);
            this.panelWelcome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(397, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Log in as ";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.ButtonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Short Course";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WelcomeForm_MouseMove);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton ButtonCompany;
        private FontAwesome.Sharp.IconButton ButtonUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ButtonClose;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Label label3;
    }
}

