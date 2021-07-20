using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BookstoreSoulinthavong.Models.DataLayer
{
    public partial class Author
    {
        public Author()
        {
            BookAuthors = new HashSet<BookAuthor>();
        }

        [Key]
        public int AuthorId { get; set; }
        [Required]
        [StringLength(200)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(200)]
        public string LastName { get; set; }

        [InverseProperty(nameof(BookAuthor.Author))]
        public virtual ICollection<BookAuthor> BookAuthors { get; set; }
    }
}
