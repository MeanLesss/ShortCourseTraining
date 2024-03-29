﻿namespace ShortCourseTraining.UserControls.DisplayControls
{
    partial class Add_Student
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
            this.comboBoxCourse = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.iconPictureBoxStudent = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxContactAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxFamily = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.iconButtonAddStdent = new FontAwesome.Sharp.IconButton();
            this.textBoxBirthPlace = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButtonCancel = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCourse
            // 
            this.comboBoxCourse.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCourse.FormattingEnabled = true;
            this.comboBoxCourse.Items.AddRange(new object[] {
            "C#",
            "C++",
            "HTML",
            "KOTLIN",
            "PYTHON",
            "JAVASCRIPT"});
            this.comboBoxCourse.Location = new System.Drawing.Point(1070, 506);
            this.comboBoxCourse.Name = "comboBoxCourse";
            this.comboBoxCourse.Size = new System.Drawing.Size(369, 31);
            this.comboBoxCourse.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(819, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(205, 23);
            this.label10.TabIndex = 76;
            this.label10.Text = "Selected Course";
            // 
            // iconPictureBoxStudent
            // 
            this.iconPictureBoxStudent.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBoxStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBoxStudent.ForeColor = System.Drawing.Color.Chocolate;
            this.iconPictureBoxStudent.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.iconPictureBoxStudent.IconColor = System.Drawing.Color.Chocolate;
            this.iconPictureBoxStudent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBoxStudent.IconSize = 254;
            this.iconPictureBoxStudent.Location = new System.Drawing.Point(1016, 117);
            this.iconPictureBoxStudent.Name = "iconPictureBoxStudent";
            this.iconPictureBoxStudent.Size = new System.Drawing.Size(254, 286);
            this.iconPictureBoxStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBoxStudent.TabIndex = 75;
            this.iconPictureBoxStudent.TabStop = false;
            this.iconPictureBoxStudent.Click += new System.EventHandler(this.iconPictureBoxStudent_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(1070, 446);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(369, 29);
            this.textBoxEmail.TabIndex = 74;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(819, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 23);
            this.label12.TabIndex = 73;
            this.label12.Text = "Email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(363, 596);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(369, 29);
            this.textBoxPhone.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 599);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 71;
            this.label11.Text = "Phone";
            // 
            // textBoxContactAddress
            // 
            this.textBoxContactAddress.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContactAddress.Location = new System.Drawing.Point(363, 492);
            this.textBoxContactAddress.Name = "textBoxContactAddress";
            this.textBoxContactAddress.Size = new System.Drawing.Size(369, 29);
            this.textBoxContactAddress.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(112, 495);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(205, 23);
            this.label9.TabIndex = 69;
            this.label9.Text = "Contact Address";
            // 
            // textBoxFamily
            // 
            this.textBoxFamily.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFamily.Location = new System.Drawing.Point(363, 546);
            this.textBoxFamily.Name = "textBoxFamily";
            this.textBoxFamily.Size = new System.Drawing.Size(369, 29);
            this.textBoxFamily.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(112, 549);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Family status";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.Location = new System.Drawing.Point(363, 437);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(369, 29);
            this.textBoxAddress.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 23);
            this.label6.TabIndex = 65;
            this.label6.Text = "Address";
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Location = new System.Drawing.Point(363, 331);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(369, 29);
            this.dateTimePickerDOB.TabIndex = 64;
            this.dateTimePickerDOB.Value = new System.DateTime(2022, 7, 4, 0, 32, 30, 0);
            // 
            // iconButtonAddStdent
            // 
            this.iconButtonAddStdent.BackColor = System.Drawing.Color.Chocolate;
            this.iconButtonAddStdent.FlatAppearance.BorderSize = 0;
            this.iconButtonAddStdent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddStdent.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddStdent.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.iconButtonAddStdent.IconColor = System.Drawing.Color.Black;
            this.iconButtonAddStdent.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddStdent.IconSize = 38;
            this.iconButtonAddStdent.Location = new System.Drawing.Point(881, 749);
            this.iconButtonAddStdent.Name = "iconButtonAddStdent";
            this.iconButtonAddStdent.Size = new System.Drawing.Size(188, 40);
            this.iconButtonAddStdent.TabIndex = 63;
            this.iconButtonAddStdent.Text = "Add ";
            this.iconButtonAddStdent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButtonAddStdent.UseVisualStyleBackColor = false;
            this.iconButtonAddStdent.Click += new System.EventHandler(this.iconButtonAddStdent_Click);
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBirthPlace.Location = new System.Drawing.Point(363, 382);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(369, 29);
            this.textBoxBirthPlace.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 61;
            this.label8.Text = "Birth place";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 23);
            this.label5.TabIndex = 60;
            this.label5.Text = "Date of Birth";
            // 
            // textBoxStudentName
            // 
            this.textBoxStudentName.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentName.Location = new System.Drawing.Point(363, 117);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(369, 29);
            this.textBoxStudentName.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 50);
            this.label3.TabIndex = 56;
            this.label3.Text = "Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(132, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 50);
            this.label2.TabIndex = 55;
            this.label2.Text = "Student";
            // 
            // iconButtonCancel
            // 
            this.iconButtonCancel.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButtonCancel.IconColor = System.Drawing.Color.Black;
            this.iconButtonCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCancel.IconSize = 38;
            this.iconButtonCancel.Location = new System.Drawing.Point(544, 749);
            this.iconButtonCancel.Name = "iconButtonCancel";
            this.iconButtonCancel.Size = new System.Drawing.Size(188, 40);
            this.iconButtonCancel.TabIndex = 54;
            this.iconButtonCancel.Text = "Cancel";
            this.iconButtonCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCancel.UseVisualStyleBackColor = true;
            this.iconButtonCancel.Click += new System.EventHandler(this.iconButtonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "Student name";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(363, 220);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.Size = new System.Drawing.Size(369, 29);
            this.textBoxConfirmPass.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(112, 223);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(218, 23);
            this.label13.TabIndex = 80;
            this.label13.Text = "Confirm Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(363, 165);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(369, 29);
            this.textBoxPassword.TabIndex = 79;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(112, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 23);
            this.label14.TabIndex = 78;
            this.label14.Text = "Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(819, 549);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 23);
            this.label15.TabIndex = 82;
            this.label15.Text = "Description";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescription.Location = new System.Drawing.Point(1070, 546);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(369, 79);
            this.textBoxDescription.TabIndex = 83;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(112, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 86;
            this.label16.Text = "Gender :";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("OCR A Extended", 14.25F);
            this.radioButtonFemale.Location = new System.Drawing.Point(529, 276);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(93, 24);
            this.radioButtonFemale.TabIndex = 85;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("OCR A Extended", 14.25F);
            this.radioButtonMale.Location = new System.Drawing.Point(363, 276);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(71, 24);
            this.radioButtonMale.TabIndex = 84;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxConfirmPass);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.comboBoxCourse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.iconPictureBoxStudent);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxContactAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxFamily);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.iconButtonAddStdent);
            this.Controls.Add(this.textBoxBirthPlace);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButtonCancel);
            this.Controls.Add(this.label1);
            this.Name = "Add_Student";
            this.Size = new System.Drawing.Size(1523, 946);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBoxStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCourse;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox iconPictureBoxStudent;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxContactAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxFamily;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private FontAwesome.Sharp.IconButton iconButtonAddStdent;
        private System.Windows.Forms.TextBox textBoxBirthPlace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButtonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
    }
}
