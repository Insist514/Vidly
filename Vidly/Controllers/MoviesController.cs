using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            //private readonly Movie[] Movies;
            Movie movie = new Movie() { Id = 1, Name = "Elden Ring" };
            //List<Movie> movies = new List<Movie>()
            //{
            //    new Movie(){ Id = 1, Name = "Elden Ring"},
            //    new Movie(){ Id = 2, Name = "Sec"},
            //    new Movie(){ Id = 3, Name = "Thrid" }
            //};
            //return new ViewResult();
            return View(movie);

            //return new PartialViewResult();
            //return PartialView(movie);

            //return new ContentResult();
            //return Content("Hello World");

            //return new RedirectResult("https://www.google.com");
            //return Redirect("https://www.google.com");

            //return new RedirectToRouteResult();
            //actionName, ControllerName, Object Route Values (queryParamString)
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

            //return new JsonResult();
            //return Json(movie);

            //return new FileContentResult();
            //return File();


            //return new HttpNotFoundResult();
            //return HttpNotFound();

            //return new EmptyResult();
        }

        public ActionResult Edit(int id, string name)
        {
            return Content("Id = " + id + "<br> name = " + name);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("Current pageIndex = {0} and sort by = {1}", pageIndex, sortBy));
        }
    }
}