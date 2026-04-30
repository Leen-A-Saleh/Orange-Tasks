using System.ComponentModel.DataAnnotations;

namespace StudentsCRUD.Models
{
    public enum StudentsGender { M,F}
    public class Student
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 3)]
        public string Name { get; set; }
        public StudentsGender Gender { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
