using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestApplication.Models;

namespace TestApplication.ViewModels
{
    public class RandomMovieViewModel
    {
        public List<Movie> Movies { get; set; }
        public List<Customer> Customers { get; set; }
    }
}