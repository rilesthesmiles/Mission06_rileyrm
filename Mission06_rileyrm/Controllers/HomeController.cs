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

        //Movie forum functionality here

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
                ViewBag.Categories = mrContext.categories.ToList();
                return View(ar);
            }
        }

        //View the movies

        [HttpGet]
        public IActionResult ViewMovies()
        {
            var applications = mrContext.responses
                .Include(x => x.Category)
                .OrderBy(x => x.Title)
                .ToList();
            return View(applications);
        }
        

        //These are the edit functions

        [HttpGet]
        public IActionResult Edit(int movieforumid)
        {
            ViewBag.Categories = mrContext.categories.ToList();

            var application = mrContext.responses.Single(x => x.MovieForumID == movieforumid);

            return View("MovieForum", application);
        }

        [HttpPost]
        public IActionResult Edit(MovieForumResponse blah)
        {
            mrContext.Update(blah);
            mrContext.SaveChanges();

            return RedirectToAction("ViewMovies");

            
        }


        // These are the delete functions

        [HttpGet]
        public IActionResult Delete(int movieforumid)
        {
            var application = mrContext.responses.Single(x => x.MovieForumID == movieforumid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(MovieForumResponse blah)
        {
            mrContext.responses.Remove(blah);
            mrContext.SaveChanges();


            return RedirectToAction("ViewMovies");
        }

        
    }
}
