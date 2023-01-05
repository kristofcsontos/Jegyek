using System.ComponentModel.DataAnnotations;

namespace Jegyek.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Display(Name = "Tantárgy")]
        public string Name { get; set; }
        [Required]

        [Display(Name = "Kredit")]
        [Range(0, Double.PositiveInfinity)]
        public int Credit { get; set; }
        [Required]
        [Range(2, 5)]
        [Display(Name = "Jegy")]
        public int Grade { get; set; }
        [Required]
        [Display(Name = "Félév")]
        public int Semester { get; set; }
    } 
}
