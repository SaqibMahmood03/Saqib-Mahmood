using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesCollege.Models
{
    public class College
    {
        public int ID { get; set; }
        [Display(Name = "College Name")]
        public string CollegeName { get; set; }
        [Display(Name = "Establishment Date")]

        [DataType(DataType.Date)]
        public DateTime EstablishmentDate { get; set; }
        public string Country { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Number of Students")]
        public decimal NumberOfStudents { get; set; }
    }
}