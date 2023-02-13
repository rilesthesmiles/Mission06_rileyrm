using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission06_rileyrm.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_rileyrm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieForumContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieForumContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Podcast()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForum()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForum(MovieForumResponse ar)
        {
            if (ModelState.IsValid)
            {
                blahContext.Add(ar);
                blahContext.SaveChanges();
                return View("Confirmation", ar);

            }
            else
            {
                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
