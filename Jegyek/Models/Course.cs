using System.ComponentModel.DataAnnotations;

namespace Jegyek.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Display(Name = "Tantárgy")]
        public string Name { get; set; }
        [Display(Name = "Kredit")]
        public int Credit { get; set; }
        [Display(Name = "Jegy")]
        public int Grade { get; set; }
    }
}
