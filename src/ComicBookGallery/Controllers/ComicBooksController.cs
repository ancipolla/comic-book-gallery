using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "Captain Marvel",
                IssueNumber = 1,
                DescriptionHtml = "<p>Carol Danvers has a new codename and is determined to prove herself the best of the best! She's forging a new future for herself as Captain Marvel, but finds that she still can't walk away from a challenge from her past! It's a firefight in the sky as the Banshee Squadron debut - but who are the Prowlers, and where has Carol seen them before? Witness her in blazing battlefield action that just may change the course of history! Then, the Avengers' new Captain Marvel meets their old one - Monica Rambeau! But what's Monica's problem? Can they resolve it before a threat from the ocean depths attacks?</p>",
                Creators = new Creator[]
                {
                    new Creator(){Name = "DeConnick", Role = "Writer"},
                    new Creator(){Name = "Sebela", Role = ""},
                    new Creator(){Name = "Soy", Role = ""},
                    new Creator(){Name = "Rios", Role = ""},
                    new Creator(){Name = "Anorade", Role = ""},
                    
                }
            };

            return View(comicBook);
            
        }
    }
}