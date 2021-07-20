using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreSoulinthavong.Models
{
    public partial class Book
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "Please enter a title.")]
        [MaxLength(200)]
        public string Title { get; set; }

        [Range(0, 9999999, ErrorMessage = "Price must be more than 0.")]
        public double Price { get; set; }

        // foreign key property
        [Required(ErrorMessage = "Please select a genre.")]
        public string GenreId { get; set; }

        // navigation properties
        public Genre Genre { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
