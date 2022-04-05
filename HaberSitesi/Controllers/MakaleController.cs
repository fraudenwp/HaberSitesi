
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogSitesi.Controllers
{
    [Authorize]
    public class MakaleController : Controller
    {
        // GET: Makale
        
       
          public ActionResult Detay()
          {
               return View();
          }
          public ActionResult MakaleEkle()
          {
               return View();
          }


     }
}