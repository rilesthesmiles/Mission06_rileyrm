using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        private MovieForumContext mrContext { get; set; }

        public HomeController( MovieForumContext someName)
        {
            mrContext = someName;
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

            ViewBag.Categories = mrContext.categories.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult MovieForum(MovieForumResponse ar)
        {
            if (ModelState.IsValid)
            {
                mrContext.Add(ar);
                mrContext.SaveChanges();
                return View("Confirmation", ar);

            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult ViewMovies()
        {
            var applications = mrContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(applications);
        }

        
    }
}
