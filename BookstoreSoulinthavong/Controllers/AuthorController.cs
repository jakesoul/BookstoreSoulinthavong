using BookstoreSoulinthavong.Models;
using BookstoreSoulinthavong.Models.DataLayer;
using BookstoreSoulinthavong.Models.DataLayer.Repositories;
using BookstoreSoulinthavong.Models.ExtensionMethods;
using BookstoreSoulinthavong.Models.Grid;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookstoreSoulinthavong.Controllers
{
    public class AuthorController : Controller
    {
        private Repository<Models.Author> data { get; set; }
        public AuthorController(BookstoreContext ctx) => data = new Repository<Models.Author>(ctx);

        public IActionResult Index() => RedirectToAction("List");


        public ViewResult List(GridDTO vals)
        {

            string defaultSort = nameof(Models.Author.FirstName);
            var builder = new GridBuilder(HttpContext.Session, vals, defaultSort);
            builder.SaveRouteSegments();


            var options = new QueryOptions<Models.Author>
            {
                Includes = "BookAuthors.Book",
                PageNumber = builder.CurrentRoute.PageNumber,
                PageSize = builder.CurrentRoute.PageSize,
                OrderByDirection = builder.CurrentRoute.SortDirection
            };
            if (builder.CurrentRoute.SortField.EqualsNoCase(defaultSort))
                options.OrderBy = a => a.FirstName;
            else
                options.OrderBy = a => a.LastName;


            var vm = new AuthorListViewModel
            {
                Authors = data.List(options),
                CurrentRoute = builder.CurrentRoute,
                TotalPages = builder.GetTotalPages(data.Count)
            };


            return View(vm);
        }

        public IActionResult Details(int id)
        {
            var author = data.Get(new QueryOptions<Models.Author>
            {
                Includes = "BookAuthors.Book",
                Where = a => a.AuthorId == id
            });
            return View(author);
        }
    }
}
