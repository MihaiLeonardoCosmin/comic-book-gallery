using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace The_Blue.Controllers
{
    public class ComicBookscontroller : Controller
    {
        public ActionResult  Detail()
        {
            ViewBag.SeriesTitle = "The Amazing Spider-Man";
            ViewBag.IssuNumber = 700;
            ViewBag.Description = "<p> Spider-Man este un licen care a fost muscat de un <span>paianjen la scoala </span></p>";
            ViewBag.Artists = new string[]
            {
                "Scripts:Dan Slot",
                "Penciles:Humberto Ramos",
                "Inks:Victor Olazaba",
                "Colors:Edgar Delgado",
                "Letters:Chris Eliopoulos"
            };
            return View();
        }
    }
}