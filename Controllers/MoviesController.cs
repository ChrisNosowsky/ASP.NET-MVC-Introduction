using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplication.Models;
using TestApplication.ViewModels;

namespace TestApplication.Controllers
{
    public class MoviesController : Controller
    {
        private RandomMovieViewModel _viewModel;
        public MoviesController()
        {
            var movie = new List<Movie> 
            { 
                new Movie { Name = "Shrek" },
                new Movie { Name = "Wall-E" }
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            _viewModel = new RandomMovieViewModel
            {
                Movies = movie,
                Customers = customers
            };
        }
        // GET: Movies/Random
        public ActionResult Random()
        {
            return View(_viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return View(_viewModel);
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}