using System;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        [Display(Name = "Data przyjęcia")]
        public DateTime? EnrollmentDate { get; set; }

        [Display(Name = "Liczba studentów")]
        public int StudentCount { get; set; }
    }
}
