using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreSoulinthavong.Models
{
    internal class SeedBooks : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> entity)
        {
            entity.HasData(
                new Book { BookId = 1, Title = "Potato", GenreId = "food", Price = 7.00 },
                new Book { BookId = 2, Title = "Buratta Cheese Board", GenreId = "food", Price = 59 },
                new Book { BookId = 3, Title = "How to solve a 4x4 Rubik's Cube", GenreId = "how-to-do", Price = 11.99 },
                new Book { BookId = 4, Title = "Master of Dragons: Leon Deng", GenreId = "fiction", Price = 24.99 }
            );
        }
    }
}