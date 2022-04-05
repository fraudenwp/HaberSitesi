
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HaberSitesi.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult GirisYap()
        {
            return View();
        }

    }
}