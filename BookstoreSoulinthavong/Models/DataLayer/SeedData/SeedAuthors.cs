using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreSoulinthavong.Models
{
    internal class SeedAuthors : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> entity)
        {
            entity.HasData(
                new Author { AuthorId = 1, FirstName = "Jake", LastName = "Soul" },
                new Author { AuthorId = 2, FirstName = "Joel", LastName = "Mango" },
                new Author { AuthorId = 3, FirstName = "Penelope", LastName = "Lopez" },
                new Author { AuthorId = 4, FirstName = "Iridian", LastName = "Marq" }
            );
        }
    }
}