using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Blue.Models;

namespace The_Blue.Controllers
{
    public class ComicBookscontroller : Controller
    {
        public ActionResult  Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p> Spider-Man este un licen care a fost muscat de un <span>paianjen la scoala </span></p>",
                Artists = new Artist[]
                {
                    new Artist() {Name = "Dan Slot" , Role = "Scripts"},
                    new Artist() {Name = "Humberto Ramos" , Role = "Penciles"},
                    new Artist() {Name = "Victor Olazaba" , Role = "Inks"},
                    new Artist() {Name = "Edgar Delgado" , Role = "Colors"},
                    new Artist() {Name = "Chris Eliopoulos" , Role = "Letters"},
                }
            };
            
            return View(comicBook);
        }
    }
}