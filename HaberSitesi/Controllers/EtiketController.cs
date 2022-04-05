
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberSitesi.Controllers
{
    public class EtiketController : Controller
    {
                                                                                                                                       
        public ActionResult Index(int id)
        {
            return View(id);
        }

          public ActionResult EtiketWidget(int id)
          {
               return View(id);
          }



     }
}