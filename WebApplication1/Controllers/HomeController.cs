using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var makale = db.Makaleler.Where(i => i.Onay == true).Select(i=>new MakaleModel()
            {
                Id = i.Id ,
                Baslik = i.Baslik ,
                KullaniciAd = i.KullaniciAd,
                Resim = i.Resim,
                YayinTarih = i.YayinTarih,
                Onay = i.Onay,
                Goruntulenme = i.Goruntulenme,
                Yorum = i.Yorum,
                Aciklama = i.Aciklama.Length>60?i.Aciklama.Substring(0,60)+("[...]"):i.Aciklama      
                
                
            }).ToList();
            return View(makale);
        }

        public ActionResult MakaleListesi(int ? id)
        {
            var makale = db.Makaleler.Where(i=>i.Onay==true).AsQueryable();
            if(id!=null)
            {
                makale = makale.Where(i => i.KategoriId == id);
            }
            return View(makale.ToList()); 
        }

        public ActionResult Ara(string deger)
        {
            var ara = db.Makaleler.Where(i => i.Onay == true && i.Aciklama.Contains(deger)).ToList();
            return View(ara);
        }

        public PartialViewResult EnCokOkunan()
        {
            var encok = db.Makaleler.Where(i => i.Onay == true).OrderByDescending(i => i.Goruntulenme).Take(5).ToList();
            return PartialView(encok);
        }

        public ActionResult Detay(int id)
        {
            var makale = db.Makaleler.Find(id);
            ViewBag.makale = makale;

            var sayi = db.Makaleler.ToList().Find(x => x.Id == id);
            sayi.Goruntulenme += 1;
            db.SaveChanges();
            return View();
        }
        
    }
}