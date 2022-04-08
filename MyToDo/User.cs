using System;
using System.ComponentModel.DataAnnotations;

namespace MyToDo
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50,MinimumLength =2,ErrorMessage = "The Name must be between 2-50 characters")]
        [RegularExpression("^[a-zA-Z ]+$")]
        public string Name { get; set; }

        [Required]
        [StringLength(250,MinimumLength = 10)]
        public string Email { get; set; }

        [Required]
        [StringLength(50,MinimumLength = 3)]
        public string Password { get; set; }
    }
}
