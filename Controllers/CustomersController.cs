using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplication.ViewModels;
using TestApplication.Models;

namespace TestApplication.Controllers
{
    public class CustomersController : Controller
    {
        private RandomMovieViewModel _viewModel;
        public CustomersController()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"}
            };
            _viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };
        }
        // GET: Customers
        public ActionResult Index()
        {
            return View(_viewModel);
        }

        public ActionResult Details(int id)
        {
            
            return View(_viewModel);
        }
    }
}