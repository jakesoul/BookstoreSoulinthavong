namespace BookstoreSoulinthavong.Controllers
{
    internal class BookQueryOptions
    {
        public string Includes { get; set; }
        public string OrderByDirection { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}