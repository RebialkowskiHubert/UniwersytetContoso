using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //ma nie być autoincrement
        [Display(Name = "Numer")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Range(0, 5)]
        [Display(Name = "Liczba kredytów")]
        public int Credits { get; set; }

        [Display(Name = "Departament")]
        public int DepartmentID { get; set; }

        [Display(Name = "Departament")]
        public Department Department { get; set; }

        [Display(Name = "Zapisy")]
        public ICollection<Enrollment> Enrollments { get; set; }

        [Display(Name = "Zadania kursu")]
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}
