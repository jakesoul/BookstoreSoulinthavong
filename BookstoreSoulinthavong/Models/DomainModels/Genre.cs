using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookstoreSoulinthavong.Models
{
    public class Genre
    {
        [MaxLength(10)]
        [Required(ErrorMessage = "Please enter a genre id.")]
        [Remote("CheckGenre", "Validation", "")]
        public string GenreId { get; set; }

        [StringLength(25)]
        [Required(ErrorMessage = "Please enter a genre name.")]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}