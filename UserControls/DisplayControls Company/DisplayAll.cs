using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCourseTraining.UserControls.DisplayControls
{
    public partial class DisplayAll : UserControl
    {

        OleDbConnection conn = null;
        string cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;
        DataSet _ds;
        int _type;
        public DisplayAll(DataSet ds,int typeCode)
        {
            InitializeComponent();
            _ds = ds;
            _type = typeCode;
        }

        private void textBoxSearch_Enter(object sender, EventArgs e)
        {
       
        }


        private void textBoxSearch_Leave(object sender, EventArgs e)
        {
           
        }

        private void AllCourses_Load(object sender, EventArgs e)
        {
           
                dataGridViewAll.DataSource = _ds.Tables[0];            

            
        }

        private void iconButtonSearch_Click(object sender, EventArgs e)
        {
            string query = "";
            if (_type == 0)//For courses search
            {
                query = @"Select * from Subjects";
            }
            if (_type == 1)//For teacher search
            {
                query = @"Select * from Users as u where u.Role_ID = 94";
            }
            if (_type == 2)//For subject search
            {

            }
            if (_type == 3)//For student search
            {
                query = @"Select * from Users as u where u.Role_ID = 88";
            }
            conn = new OleDbConnection(cs);
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _ds = ds;
            dataGridViewAll.DataSource = _ds.Tables[0];
        }
    }
}
