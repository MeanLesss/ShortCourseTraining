
namespace ShortCourseTraining
{
    partial class CompanyLoginFormUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonLogIn = new FontAwesome.Sharp.IconButton();
            this.ButtonSignUp = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelCreateComapny = new System.Windows.Forms.LinkLabel();
            this.ButtonBack = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(386, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 66);
            this.label2.TabIndex = 3;
            this.label2.Text = "Admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(213, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AcceptsReturn = true;
            this.textBoxUsername.AcceptsTab = true;
            this.textBoxUsername.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.Location = new System.Drawing.Point(338, 138);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(337, 35);
            this.textBoxUsername.TabIndex = 5;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(338, 201);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(337, 35);
            this.textBoxPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(213, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password :";
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
            this.ButtonLogIn.Location = new System.Drawing.Point(537, 264);
            this.ButtonLogIn.Name = "ButtonLogIn";
            this.ButtonLogIn.Size = new System.Drawing.Size(138, 48);
            this.ButtonLogIn.TabIndex = 9;
            this.ButtonLogIn.Text = "Log in";
            this.ButtonLogIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonLogIn.UseVisualStyleBackColor = false;
            this.ButtonLogIn.Click += new System.EventHandler(this.ButtonLogIn_Click);
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.Color.White;
            this.ButtonSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.ForeColor = System.Drawing.Color.Black;
            this.ButtonSignUp.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ButtonSignUp.IconColor = System.Drawing.Color.Chocolate;
            this.ButtonSignUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonSignUp.IconSize = 40;
            this.ButtonSignUp.Location = new System.Drawing.Point(338, 264);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(138, 48);
            this.ButtonSignUp.TabIndex = 10;
            this.ButtonSignUp.Text = "Sign up";
            this.ButtonSignUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Have a company yet? :";
            // 
            // linkLabelCreateComapny
            // 
            this.linkLabelCreateComapny.AutoSize = true;
            this.linkLabelCreateComapny.Font = new System.Drawing.Font("OCR A Extended", 14.25F);
            this.linkLabelCreateComapny.LinkColor = System.Drawing.Color.Chocolate;
            this.linkLabelCreateComapny.Location = new System.Drawing.Point(538, 357);
            this.linkLabelCreateComapny.Name = "linkLabelCreateComapny";
            this.linkLabelCreateComapny.Size = new System.Drawing.Size(163, 20);
            this.linkLabelCreateComapny.TabIndex = 12;
            this.linkLabelCreateComapny.TabStop = true;
            this.linkLabelCreateComapny.Text = "Create Company";
            this.linkLabelCreateComapny.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreateCompany_LinkClicked);
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
            this.ButtonBack.Location = new System.Drawing.Point(3, 3);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(54, 48);
            this.ButtonBack.TabIndex = 13;
            this.ButtonBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonBack.UseVisualStyleBackColor = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(292, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Create Admin first before create comapny";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(248, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(570, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Or go to create campany let user log in admin first";
            // 
            // CompanyLoginFormUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ButtonBack);
            this.Controls.Add(this.linkLabelCreateComapny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.ButtonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompanyLoginFormUC";
            this.Size = new System.Drawing.Size(1000, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton ButtonLogIn;
        private FontAwesome.Sharp.IconButton ButtonSignUp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelCreateComapny;
        private FontAwesome.Sharp.IconButton ButtonBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
