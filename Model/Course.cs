using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTraining.Model
{
    internal class Course
    {
        Subject _subject = new Subject(); 
        public string CourseName { get;set; }        
        public DateTime CourseDuration{ get; set; }
    }
}
