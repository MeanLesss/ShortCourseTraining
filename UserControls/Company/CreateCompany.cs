using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShortCourseTraining.UserControls.Company;

namespace ShortCourseTraining.UserControls
{
    public partial class CreateCompany : UserControl
    {
        private Panel _panel = null;
        public CreateCompany(Panel welcomPanel)
        {
            InitializeComponent();
            _panel = welcomPanel;
        }

        private void PictureBoxComLogo_Click(object sender, EventArgs e)
        {

        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            PictureBoxComLogo.ResetImeMode();
            textBoxCompanyName.Clear();
            _panel.Controls.Remove(this);
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            AddAdminCompany addAdmin = new AddAdminCompany();
            _panel.Controls.Add(addAdmin);
            addAdmin.Show();
            addAdmin.BringToFront();
        }
    }
}
