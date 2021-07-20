using BookstoreSoulinthavong.Models.DTO;
using BookstoreSoulinthavong.Models.ExtensionMethods;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreSoulinthavong.Models.Grid
{
    public class BooksGridBuilder : GridBuilder
    {
        public BooksGridBuilder(ISession sess) : base(sess) { }

        public BooksGridBuilder(ISession sess, BooksGridDTO values,
            string defaultSortField) : base(sess, values, defaultSortField)
        {
            bool isInitial = values.Genre.IndexOf(FilterPrefix.Genre) == -1;
            routes.AuthorFilter = (isInitial) ? FilterPrefix.Author + values.Author : values.Author;
            routes.GenreFilter = (isInitial) ? FilterPrefix.Genre + values.Genre : values.Genre;
            routes.PriceFilter = (isInitial) ? FilterPrefix.Price + values.Price : values.Price;

            SaveRouteSegments();
        }

        public void LoadFilterSegments(string[] filter, Author author)
        {
            if (author == null)
            {
                routes.AuthorFilter = FilterPrefix.Author + filter[0];
            }
            else
            {
                routes.AuthorFilter = FilterPrefix.Author + filter[0]
                    + "-" + author.FullName.Slug();
            }
            routes.GenreFilter = FilterPrefix.Genre + filter[1];
            routes.PriceFilter = FilterPrefix.Price + filter[2];
        }
        public void ClearFilterSegments() => routes.ClearFilters();


        string def = BooksGridDTO.DefaultFilter;   // get default filter value from static DTO property
        public bool IsFilterByAuthor => routes.AuthorFilter != def;
        public bool IsFilterByGenre => routes.GenreFilter != def;
        public bool IsFilterByPrice => routes.PriceFilter != def;

        public bool IsSortByGenre =>
            routes.SortField.EqualsNoCase(nameof(Genre));
        public bool IsSortByPrice =>
            routes.SortField.EqualsNoCase(nameof(Book.Price));
    }
}