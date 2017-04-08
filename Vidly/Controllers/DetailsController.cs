using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        // GET: Customers/Details/id
        [Route("Customer/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Name  = "John Smith", Id = 0},
                new Customer { Name  = "Mary Williams", Id = 1}
            };
            var customer = customers.ElementAt(id);
            return View(customer);
        }
    }
}