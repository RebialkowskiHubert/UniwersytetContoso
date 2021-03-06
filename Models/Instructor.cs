﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Instructor : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Data wynajmu")]
        public DateTime HireDate { get; set; }

        public ICollection<CourseAssignment> CourseAssignment { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}
