using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreSoulinthavong.Models
{
    internal class SeedGenres : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                new Genre { GenreId = "food", Name = "Food" },
                new Genre { GenreId = "how-to-do", Name = "How-To-Do" },
                new Genre { GenreId = "fiction", Name = "Fiction" }
            );
        }
    }
}