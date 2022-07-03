namespace ShortCourseTraining.UserControls.DisplayControls
{
    partial class AddCourses
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.textBoxCoDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.listBoxAddedSubject = new System.Windows.Forms.ListBox();
            this.iconButtonAddSubject = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course name";
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(473, 851);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(182, 40);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chocolate;
            this.label2.Location = new System.Drawing.Point(136, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Course";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("OCR A Extended", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course Duration";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCourseName.Location = new System.Drawing.Point(286, 124);
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(369, 29);
            this.textBoxCourseName.TabIndex = 7;
            // 
            // textBoxCoDuration
            // 
            this.textBoxCoDuration.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCoDuration.Location = new System.Drawing.Point(286, 208);
            this.textBoxCoDuration.Name = "textBoxCoDuration";
            this.textBoxCoDuration.Size = new System.Drawing.Size(369, 29);
            this.textBoxCoDuration.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subjects";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Items.AddRange(new object[] {
            "C#",
            "C++",
            "Python",
            "HTML",
            "CSS",
            "KOTLIN",
            "FLUTTER",
            "JAVASCRIPT"});
            this.comboBoxSubject.Location = new System.Drawing.Point(286, 285);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(369, 31);
            this.comboBoxSubject.TabIndex = 10;
            // 
            // listBoxAddedSubject
            // 
            this.listBoxAddedSubject.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAddedSubject.FormattingEnabled = true;
            this.listBoxAddedSubject.ItemHeight = 20;
            this.listBoxAddedSubject.Location = new System.Drawing.Point(286, 336);
            this.listBoxAddedSubject.Name = "listBoxAddedSubject";
            this.listBoxAddedSubject.Size = new System.Drawing.Size(281, 104);
            this.listBoxAddedSubject.TabIndex = 11;
            // 
            // iconButtonAddSubject
            // 
            this.iconButtonAddSubject.FlatAppearance.BorderSize = 0;
            this.iconButtonAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddSubject.ForeColor = System.Drawing.Color.Chocolate;
            this.iconButtonAddSubject.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonAddSubject.IconColor = System.Drawing.Color.Chocolate;
            this.iconButtonAddSubject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddSubject.IconSize = 28;
            this.iconButtonAddSubject.Location = new System.Drawing.Point(661, 287);
            this.iconButtonAddSubject.Name = "iconButtonAddSubject";
            this.iconButtonAddSubject.Size = new System.Drawing.Size(37, 31);
            this.iconButtonAddSubject.TabIndex = 12;
            this.iconButtonAddSubject.UseVisualStyleBackColor = true;
            this.iconButtonAddSubject.Click += new System.EventHandler(this.iconButtonAddSubject_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Chocolate;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(573, 409);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(82, 31);
            this.iconButton2.TabIndex = 13;
            this.iconButton2.Text = "Remove";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // AddCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButtonAddSubject);
            this.Controls.Add(this.listBoxAddedSubject);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCoDuration);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.label1);
            this.Name = "AddCourses";
            this.Size = new System.Drawing.Size(1523, 946);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.TextBox textBoxCoDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ListBox listBoxAddedSubject;
        private FontAwesome.Sharp.IconButton iconButtonAddSubject;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
