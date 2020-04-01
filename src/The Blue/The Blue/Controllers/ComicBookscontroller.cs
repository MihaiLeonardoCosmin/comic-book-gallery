using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Blue.Data;
using The_Blue.Models;

namespace The_Blue.Controllers
{
    public class ComicBookscontroller : Controller
    {
        private ComicBookRepository _comicBookRepository = null;
        
        public ComicBookscontroller()
        {
            _comicBookRepository = new ComicBookRepository();
        }
          
        public ActionResult  Detail(int? id)
        {
            if(id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook((int)id) ;
            
            return View(comicBook);
        }
    }
}