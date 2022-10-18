namespace ShortCourseTraining.UserControls.Company
{
    partial class AddAdminCompany
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
            this.ButtonSignUp = new FontAwesome.Sharp.IconButton();
            this.ButtonLogIn = new FontAwesome.Sharp.IconButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonBack = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.Color.White;
            this.ButtonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.ForeColor = System.Drawing.Color.Black;
            this.ButtonSignUp.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ButtonSignUp.IconColor = System.Drawing.Color.Chocolate;
            this.ButtonSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSignUp.IconSize = 40;
            this.ButtonSignUp.Location = new System.Drawing.Point(339, 305);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(138, 48);
            this.ButtonSignUp.TabIndex = 18;
            this.ButtonSignUp.Text = "Cancel";
            this.ButtonSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // ButtonLogIn
            // 
            this.ButtonLogIn.BackColor = System.Drawing.Color.Chocolate;
            this.ButtonLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogIn.FlatAppearance.BorderSize = 0;
            this.ButtonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogIn.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogIn.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ButtonLogIn.IconColor = System.Drawing.Color.Black;
            this.ButtonLogIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonLogIn.IconSize = 40;
            this.ButtonLogIn.Location = new System.Drawing.Point(538, 305);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(138, 48);
            this.ButtonLogIn.TabIndex = 17;
            this.ButtonLogIn.Text = "Create";
            this.ButtonLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ButtonLogIn.UseVisualStyleBackColor = false;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(339, 237);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(337, 35);
            this.textBoxPassword.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Password :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AcceptsReturn = true;
            this.textBoxUsername.AcceptsTab = true;
            this.textBoxUsername.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(339, 174);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(337, 35);
            this.textBoxUsername.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(396, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 66);
            this.label2.TabIndex = 12;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Log In";
            // 
            // ButtonBack
            // 
            this.ButtonBack.BackColor = System.Drawing.SystemColors.Control;
            this.ButtonBack.FlatAppearance.BorderSize = 0;
            this.ButtonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBack.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.ButtonBack.IconColor = System.Drawing.Color.Chocolate;
            this.ButtonBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonBack.IconSize = 40;
            this.ButtonBack.Location = new System.Drawing.Point(0, 0);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(54, 48);
            this.ButtonBack.TabIndex = 19;
            this.ButtonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(68, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(878, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "This log in admin will be in this company note only admin can log in and create";
            // 
            // AddAdminCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAdminCompany";
            this.Size = new System.Drawing.Size(1000, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton ButtonSignUp;
        private FontAwesome.Sharp.IconButton ButtonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ButtonBack;
        private System.Windows.Forms.Label label5;
    }
}
