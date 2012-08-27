using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sharpex.Models;

namespace Sharpex.Controllers
{
    public class MoviesController : Controller
    {
        //
        // GET: /Movies/
        MoviesEntities db = new MoviesEntities();

        public ActionResult Index()
        {
            var movies = from m in db.Movies
                         where m.ReleaseDate > new DateTime(1984, 6, 1)
                         select m;

            return View(movies.ToList());

        }

    }
}