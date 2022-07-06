using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShortCourseTraining.Model;

namespace ShortCourseTraining.UserControls.DisplayControls.Cards
{
    public partial class StaticCountCard : UserControl
    {
        private string _title;
        private string _count;
        public string Title { get; set; }
        public string Count { get; set; }
        public StaticCountCard()
        {
            InitializeComponent();
        }
        public StaticCountCard(string title,int count)
        {
            InitializeComponent();
            _title = title;
            _count = count.ToString();
        }

        private void StaticCountCard_Load(object sender, EventArgs e)
        {
            var ptr = NativeMethod.CreateRoundRectRgn(1, 1, this.Width, this.Height, 40, 40);
            this.Region = Region.FromHrgn(ptr);
            NativeMethod.DeleteObject(ptr);
            labelTitle.Text = _title;
            labelCount.Text = _count;
        }
    }
}
