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
            if(DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");


        }
    }
}