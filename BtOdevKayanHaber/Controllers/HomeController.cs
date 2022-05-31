using Microsoft.AspNetCore.Mvc;

namespace BtOdevKayanHaber.Controllers
{
    using Models;
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Haber> haberList = new List<Haber>();
            haberList.Add(new Haber { baslik = "Haber 1", yazi = "C# Programlama dilini öğrendik... Artık c# dilini biliyoruz.", tarih = DateTime.Now });
            haberList.Add(new Haber { baslik = "Haber 2", yazi = "Sql Server Öğrendik. Hepimiz birer DBA'yiz..", tarih = DateTime.Now });
            haberList.Add(new Haber { baslik = "Haber 3", yazi = "EF Core Örendik. Artık veritabanı ile sqli bağlıyoruz.", tarih = DateTime.Now });
            haberList.Add(new Haber { baslik = "Haber 4", yazi = "Ve nihayet webteyiz. Hatta Asp.Net Core öğreneceğiz.", tarih = DateTime.Now });
            haberList.Add(new Haber { baslik = "Haber 5", yazi = "Hoca dapperda anlatacakmış.", tarih = DateTime.Now });
            return View(haberList);
        }
    }
}
