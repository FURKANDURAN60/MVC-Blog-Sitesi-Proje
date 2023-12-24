using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        DataContext db = new DataContext();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.onaylanmis = db.Makaleler.Where(i=>i.Onay==true).Count();
            ViewBag.onaylanmamis = db.Makaleler.Where(i => i.Onay == false).Count();
            ViewBag.sayi = db.Makaleler.Count();
            return View();
        }
        public ActionResult YazarListesi()
        {
            var makale = db.Makaleler.ToList();
            return View(makale);
        }
        public ActionResult OnayListesi()
        {
            var makale = db.Makaleler.Where(i => i.Onay == true).ToList();
            return View(makale);
        }

        public ActionResult OnaysizListesi()
        {
            var makale = db.Makaleler.Where(i => i.Onay == false).ToList();
            return View(makale);
        }
    }
}
