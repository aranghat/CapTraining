using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo
{
    public class ToDoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100,MinimumLength = 10)]
        public string Title { get; set; }

        public DateTime DueDate { get; set; }

        public User User { get; set; }

        public List<Note> Notes { get; set; }

        public bool IsCompleted { get; set; }   

    }
}
