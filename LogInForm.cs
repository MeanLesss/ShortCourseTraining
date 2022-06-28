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

namespace ShortCourseTraining
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        OleDbConnection conn = null;
        string cs = "";
        DataSet ds = null;
        OleDbDataAdapter da = null;
        OleDbCommandBuilder cmdBuilder = null;
        private void LogInForm_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection();
            cs = ConfigurationManager.ConnectionStrings["ShortCourseDB"].ConnectionString;
            conn.ConnectionString = cs;

            try
            {
                conn.Open();
                MessageBox.Show("okay : " + conn.Database.ToString());
                conn.Close();

                ds = new DataSet();

                da = new OleDbDataAdapter("select * from companies", conn);
                //cmdBuilder = new OleDbCommandBuilder(da);
                da.Fill(ds, "Companies");
                dataGridView1.DataSource = ds.Tables["Companies"];
                //close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }
    }
}
