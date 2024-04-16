using System.ComponentModel.DataAnnotations;

namespace LabCourse1.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
