using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootstrappingMVC.Models;

namespace BootstrappingMVC.Controllers
{
    public class SimpleController : Controller
    {
        // GET: Simple
        public ActionResult Index()
        {
            var person = new Person
            {
                FirstName = "James",
                LastName = "Buchanon",
                BirthDate = new DateTime(1990, 6, 1),
                LikesMusic = true,
                Skills = new List<string>() { "Math", "Science", "History"}
            };

            return View(person);
        }
    }
}