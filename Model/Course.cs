using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTraining.Model
{
    public class Course
    {
        [Required]
        Subject _subject = new Subject(); 
        [Required]
        public int ID { get; set; }
        public string SubjectTitle { get; set; }
        public string CourseName { get;set; }        
        public DateTime CourseDuration{ get; set; }
        public int CourseHours{ get; set; }
    }
}
