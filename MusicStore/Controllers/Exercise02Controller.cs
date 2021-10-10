using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class Exercise02Controller : Controller
    {
        // GET
        public ActionResult Index()
        {

            Book book2 = new Book("Norwegian wood", 230, "Haruki Murakami", 1987);

            ViewBag.Book = book2;

            MusicCd cd2 = new MusicCd("Rockstar", 5000, "Malk De Koijn", 2002);
            
            ViewBag.MusicCd = cd2;
            return View();
        }
    }
}