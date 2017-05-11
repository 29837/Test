using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
       
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name  = " Customer 1"},
                new Customer { Name  = " Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }


        //Get: movies
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Gender).ToList();
            return View(movies);
        }

        //Get: movies/details/{id}
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(g => g.Gender).SingleOrDefault(m => m.Id == id);
            if (movie == null)
                return HttpNotFound("The movie was not found in the database");
            return View(movie);
        }

        /****Good to know*****
        // 
        //public ActionResult Edit(int id)
        //{
        //       return Content("Id: " + id);
        //}

        ////movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        ///**************************Using Attribut routing and Constraints*******************************

        //[Route("movies/released/{year:regex(\\d{4})}/{month:range(1, 12)}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}
         * */
    }
}