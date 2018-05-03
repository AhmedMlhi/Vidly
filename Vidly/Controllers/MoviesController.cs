﻿using System;
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
            var movie = new Movie() { Name = "Shrek!!" };



            return View(movie);
          
        }

        public ActionResult Edit()
        { return Content("Id " + 3); }


        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));


        }
        [Route("Movies/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int? year, int? month)
        { return Content(year + "/" + month); }
    }   
}

