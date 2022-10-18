using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTraining.UserControls.Company
{
    public partial class AddAdminCompany : UserControl
    {
        public AddAdminCompany()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            textBoxPassword.Clear();
            textBoxUsername.Clear();
            this.Hide();
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {

        }
    }
}
