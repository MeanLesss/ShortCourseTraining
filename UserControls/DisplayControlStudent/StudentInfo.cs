using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTraining.UserControls.DisplayControlStudent
{
    public partial class StudentInfo : UserControl
    {
        private readonly Model.User _user;
        public StudentInfo(Model.User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            textBoxStudentName.Text = _user.Username;
            textBoxStudentSex.Text = _user.Gender;
            dateTimePickerDOB.Text = _user.DOB.ToString("d");
            textBoxBirthPlace.Text = _user.BirthPlace;
            textBoxAddress.Text = _user.Address;
            textBoxContactAddress.Text = _user.ContactAddress;
            textBoxFamily.Text = _user.FamilyStatus;
            textBoxPhone.Text = _user.PhoneNumber;
            textBoxEmail.Text = _user.Email;
            iconPictureBoxStudent.Image = _user.Photo;
        }

        private void iconButtonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void iconButtonAddStdent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This part not done!!");
        }
    }
}
