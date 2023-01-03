using System.ComponentModel.DataAnnotations;

namespace Jegyek.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public int Grade { get; set; }
    }
}
