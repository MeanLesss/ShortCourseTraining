using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;

namespace ShortCourseTraining
{
    public partial class WelcomeForm : Form
    {
        OleDbConnection  conn = null;
        string cs = "";
        DataSet ds = null;  
        OleDbDataAdapter da = null;
        OleDbCommandBuilder cmdBuilder = null;
        
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                da.Fill(ds,"Companies");
               // dataGridViewTest.DataSource = ds.Tables["Companies"];
                //close the connection
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void WelcomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //ClassLibrary1.Draggable.Move(this);
            }
        }

        private void ButtonCompany_Click(object sender, EventArgs e)
        {
            /* LogInForm logInForm = new LogInForm();
             logInForm.Show();*/
            CompanyLoginFormUC companyLoginFormUC = new CompanyLoginFormUC(panelWelcome);
            panelWelcome.Controls.Add(companyLoginFormUC);
            companyLoginFormUC.Show();
            companyLoginFormUC.BringToFront();
            
        }
    }
}
