using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace BookstoreSoulinthavong.Models.DataLayer
{
    [Index(nameof(AuthorId), Name = "IX_BookAuthors_AuthorId")]
    public partial class BookAuthor
    {
        [Key]
        public int BookId { get; set; }
        [Key]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("BookAuthors")]
        public virtual Author Author { get; set; }
        [ForeignKey(nameof(BookId))]
        [InverseProperty("BookAuthors")]
        public virtual Book Book { get; set; }
    }
}
