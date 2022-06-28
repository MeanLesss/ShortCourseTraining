using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortCourseTraining.Model
{
    public class Subject
    {
        [Required]
        public string SubjectName { get; set; }
        public DateTime SubjectDuration { get; set; }
        public string TeacherName { get; set; }

    }
}
