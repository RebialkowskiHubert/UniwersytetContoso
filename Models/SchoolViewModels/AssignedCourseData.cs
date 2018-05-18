using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class AssignedCourseData
    {
        [Display(Name = "ID kursu")]
        public int CourseID { get; set; }

        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Przydzielony")]
        public bool Assigned { get; set; }
    }
}
