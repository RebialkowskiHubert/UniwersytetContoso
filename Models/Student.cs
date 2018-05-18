using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data przyjęcia")]
        public DateTime EnrollmentDate { get; set; }

        [Display(Name = "Zapisy")]
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
