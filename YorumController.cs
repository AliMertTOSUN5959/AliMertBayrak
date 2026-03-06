using Microsoft.AspNetCore.Mvc;
using AliMertBayrak.Models;
using System.Linq;



namespace AliMertBayrak.Controllers
{
    public class YorumController : Controller
    {
        private readonly BayrakContext _context;

        public YorumController(BayrakContext context)
        {
            _context = context;
        }

        // FORM SAYFASI
        public IActionResult Ekle()
        {
            return View();
        }

        // KAYDETME
        [HttpPost]
        public IActionResult Ekle(Yorum yorum)
        {
            if (ModelState.IsValid)
            {
                _context.Yorumlar.Add(yorum);
                _context.SaveChanges();

                return RedirectToAction("Liste");
            }

            return View(yorum);
        }

        // LİSTELEME
        public IActionResult Liste()
        {
            var yorumlar = _context.Yorumlar
                                   .OrderByDescending(x => x.Tarih)
                                   .ToList();

            return View(yorumlar);
        }
    }
}
