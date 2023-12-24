using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace WebApplication1.Models
{
    public class Datainitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategori = new List<Kategori>()
            {
                new Kategori(){KategoriAd = "PYTHON"},
                new Kategori(){KategoriAd = "ASP.NET"},
            };
            foreach (var item in kategori)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            var makale = new List<Makale>()
            {
                new Makale(){Baslik = "Python Dilindeki Temel Veri Türleri" ,Aciklama="Python dilindeki temel veri tipleri şunlardır: Tam sayıları temsil eden `int`, ondalık sayıları ifade eden `float`, karmaşık sayıları ifade eden `complex`, metinleri temsil eden `str`, değiştirilebilir sıralı elemanları içeren `list`, değiştirilemez sıralı elemanları içeren `tuple`, mantıksal değerleri temsil eden `bool`, benzersiz elemanları içeren sırasız bir veri tipi olan `set` ve anahtar-değer çiftlerini içeren `dict`. Bu veri tipleri, Python programlamasında temel yapı taşlarını oluşturur ve çeşitli programlama görevlerinde kullanılırlar.", Resim="python.jpg" , YayinTarih=Convert.ToDateTime("2023-11-19"),Goruntulenme=0,Onay=true,KategoriId=1,KullaniciAd="FURKANDRN60" },
                new Makale(){Baslik = "ASP.NET Hakkında Bazı Bilgiler" , Aciklama="ASP.NET, Microsoft tarafından geliştirilen bir web uygulama çerçevesidir. Hem Web Forms hem de MVC (Model-View-Controller) mimarisini destekler. Web Forms, olay tabanlı bir model sunarak hızlı web uygulamaları geliştirmeyi sağlar. MVC, daha modüler ve bakımı kolay bir yapı sunarak geliştiricilere esneklik ve kontrol sağlar. Ayrıca, ASP.NET Core, çapraz platform ve açık kaynaklı bir versiyonudur, Linux, macOS ve Windows gibi farklı platformlarda çalışabilir. ASP.NET, geniş bir kontrol kütüphanesi, güvenlik özellikleri ve entegrasyon yetenekleri ile büyük ölçekli kurumsal uygulamalardan küçük ölçekli projelere kadar geniş bir yelpazede kullanılır.", Resim="asp.jpg" , YayinTarih=Convert.ToDateTime("2023-11-20"),Goruntulenme=0,Onay=true,KategoriId=2,KullaniciAd="bicekemre" }

            };
            foreach (var item in makale)
            {
                context.Makaleler.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}