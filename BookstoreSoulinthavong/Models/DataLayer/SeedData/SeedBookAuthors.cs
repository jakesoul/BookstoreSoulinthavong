using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreSoulinthavong.Models
{
    internal class SeedBookAuthors : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> entity)
        {
            entity.HasData(
                new BookAuthor { BookId = 1, AuthorId = 1 },
                new BookAuthor { BookId = 2, AuthorId = 2 },
                new BookAuthor { BookId = 3, AuthorId = 3 },
                new BookAuthor { BookId = 4, AuthorId = 4 }
            );
        }
    }
}