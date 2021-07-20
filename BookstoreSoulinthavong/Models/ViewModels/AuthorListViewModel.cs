using BookstoreSoulinthavong.Models.DataLayer;
using BookstoreSoulinthavong.Models.Grid;
using System.Collections.Generic;

namespace BookstoreSoulinthavong.Controllers
{
    public class AuthorListViewModel
    {
        public IEnumerable<Author> Authors { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }
    }
}