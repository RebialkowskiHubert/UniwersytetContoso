using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Imię nie może być dłuższe niż 50 znaków.")]
        [Column("FirstName")]
        [Display(Name = "Imię")]
        public string FirstMidName { get; set; }

        [Display(Name = "Imię i nazwisko")]
        public string FullName
        {
            get
            {
                return FirstMidName + " " + LastName;
            }
        }
    }
}
