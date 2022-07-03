using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTraining.UserControls.DisplayControls
{
    public partial class AddCourses : UserControl
    {
        public AddCourses()
        {
            InitializeComponent();
        }

        private void iconButtonAddSubject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxSubject.Text))
            {
                listBoxAddedSubject.Items.Add(comboBoxSubject.Text);
            }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            while (listBoxAddedSubject.SelectedItems.Count > 0)
            {
                listBoxAddedSubject.Items.Remove(listBoxAddedSubject.SelectedItems[0]);
            }
        }
    }
}
