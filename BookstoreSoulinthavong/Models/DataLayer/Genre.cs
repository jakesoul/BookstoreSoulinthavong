using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BookstoreSoulinthavong.Models.DataLayer
{
    public partial class Genre
    {
        public Genre()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        [StringLength(10)]
        public string GenreId { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [InverseProperty(nameof(Book.Genre))]
        public virtual ICollection<Book> Books { get; set; }
    }
}
