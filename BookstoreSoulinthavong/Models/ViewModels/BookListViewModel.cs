using BookstoreSoulinthavong.Models.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreSoulinthavong.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public RouteDictionary CurrentRoute { get; set; }
        public int TotalPages { get; set; }

        // data for filter drop-downs - one hardcoded
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public Dictionary<string, string> Prices =>
            new Dictionary<string, string> {
                { "under12", "Under $12" },
                { "12to27", "$12 to $27" },
                { "over27", "Over $27" }
            };

        // data for pagesize drop-down - hardcoded
        public int[] PageSizes => new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    }
}
