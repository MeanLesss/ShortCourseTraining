using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTraining.UserControls.DisplayControls
{
    using ShortCourseTraining.Database;
    using ShortCourseTraining.Model;
    public partial class AddTeacher : UserControl
    {
        User _user;
        public AddTeacher(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void iconPictureBoxTeacher_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "image file(*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png";
            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var file = new FileInfo(of.FileName);
                Image photo = Image.FromFile(of.FileName);
                //product.Photo = photo;
                iconPictureBoxTeacher.Image = photo;
            }
        }

        private void AddTeacher_Load(object sender, EventArgs e)
        {

        }
        [Obsolete]
        private void iconButtonAddTeacher_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirmPass.Text)
            {
                var user = new User
                {
                    ComID = _user.ComID,
                    Username = textBoxTeacherName.Text,
                    Password = textBoxPassword.Text,
                    Gender = comboBoxSex.Text,
                    BirthPlace = textBoxBirthPlace.Text,
                    Address = textBoxAddress.Text,
                    ContactAddress = textBoxContactAddress.Text,
                    FamilyStatus = textBoxFamily.Text,
                    PhoneNumber = textBoxPhone.Text,
                    Email = textBoxEmail.Text,
                    TeachingSubject = comboBoxSubject.Text,
                    Photo = iconPictureBoxTeacher.Image
                };
                new DatabaseManager().SignUpTeacher(user);
            }
            MessageBox.Show("Teacher created!");
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
