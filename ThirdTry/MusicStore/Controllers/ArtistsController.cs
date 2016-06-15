using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class ArtistsController : Controller
    {
        MusicStoreDataContext context = new MusicStoreDataContext();
        //
        // GET: /Artists/

        public ActionResult Index()
        {
            var models = from r in context.Artists
                         orderby r.ArtistName descending
                         select r;
            return View(models);
        }

    }
}
