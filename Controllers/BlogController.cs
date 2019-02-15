using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace portfolio.Controllers
{

    public class BlogController : Controller
    {
        // GET: /<controller> 
        public IActionResult Index()
        {
            var model = new portfolio.Models.Blog();
            model.name = "aaron";

            return View(model);
        }

        public IActionResult Create(string blog)
        {
            var model = new portfolio.Models.Blog();
            model.post = blog;

            return View("Index", model);
        }
    }
}
