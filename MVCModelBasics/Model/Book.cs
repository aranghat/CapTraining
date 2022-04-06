using System;
using System.ComponentModel.DataAnnotations;

namespace MVCModelBasics.Model
{
    public class Book : IEquatable<Book>
    {
        [Required(ErrorMessage = "ID cannot be blank")]
        public int Id { get; set; } 

        [Required(ErrorMessage = "Book title cannot be blank")]
        [StringLength(50,MinimumLength = 2
            ,ErrorMessage = "The title should be between 2- 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author cannot be blank")]
        [RegularExpression("^[a-zA-Z]+$",ErrorMessage = "Author can have only alphabets")]
        public string Author { get; set; }

        public string CoverImage { get; set; }

        public bool Equals(Book other)
        {
            return this.Title.Equals(other.Title
                , StringComparison.OrdinalIgnoreCase);
        }
    }
}
