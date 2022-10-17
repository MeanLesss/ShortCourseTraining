using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShortCourseTraining.Database;

namespace ShortCourseTraining.UserControls.DisplayControls
{
    using ShortCourseTraining.Model;

    public partial class Add_Student : UserControl
    {
        public Add_Student()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void iconButtonAddStdent_Click(object sender, EventArgs e)
        {
            DatabaseManager database = new DatabaseManager();

            //for company is use as an update query when there is a company that need to assign to
            if (textBoxPassword.Text == textBoxConfirmPass.Text)
            {
                User user = new User
                {
                    Username = textBoxStudentName.Text,
                    ComID = 0,
                    Password = textBoxConfirmPass.Text,
                    Description = textBoxDescription.Text,
                    PhoneNumber = textBoxPhone.Text,
                    Email = textBoxEmail.Text,
                    Photo = iconPictureBoxStudent.Image,
                    CreatedDate = DateTime.Now.Date,
                    Status = true
                };
                if (radioButtonMale.Checked)
                {
                    radioButtonFemale.Checked = false;
                    user.Gender = "Male";
                }

                if (radioButtonFemale.Checked)
                {
                    radioButtonMale.Checked = false;
                    user.Gender = "Female";
                }

                if (iconPictureBoxStudent.Image == null)
                {
                    user.Photo = null;
                }

                database.SignUpStudent(user);

                MessageBox.Show("Student account Created");
            }
            else
            {
                MessageBox.Show("Password doesn't match");
            }
        }

        private void iconPictureBoxStudent_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
