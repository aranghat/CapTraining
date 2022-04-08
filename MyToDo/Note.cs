using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo
{
    public class Note
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string NoteText { get; set; }

        
    }
}
