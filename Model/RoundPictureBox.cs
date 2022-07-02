using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ShortCourseTraining.Model
{
    class RoundPictureBox : PictureBox
    {
        protected override void OnPaint(PaintEventArgs penArgs)
        {
            base.OnPaint(penArgs);
            using (GraphicsPath obj = new GraphicsPath())
            {
                obj.AddEllipse(0,0,this.Width - 1 ,this.Height - 1);
                Region = new Region(obj);
                penArgs.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                penArgs.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, this.Width - 1,
                    this.Height - 1);
            }
        }
    }
}
