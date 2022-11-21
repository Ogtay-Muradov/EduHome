using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Name field can not be empty!")]
        public string Name { get; set; } 
        public string Description { get; set; }
        public bool IsDeactive { get; set; }

    }
}
