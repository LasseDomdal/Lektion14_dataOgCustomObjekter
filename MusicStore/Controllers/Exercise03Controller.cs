using System;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class Exercise03Controller : Controller
    {
        // GET
        public ActionResult Index()
        {

            Track t1 = new Track("Guld og diamanter", "Hans Phillip", "2:51");
            Track t2 = new Track("Fucking nummer", "Hans Phillip", "5:03");
            Track t3 = new Track("Neonlys", "Hans Phillip", "3:07");
            
            
            MusicCd cd3 = new MusicCd(
                "Neonlys",
                300,
                "Neonlys.jpg",
                "Ukendt kunstner",
                "seludgivet",
                2013
                );
            cd3.AddTrack(t1);
            cd3.AddTrack(t2);
            cd3.AddTrack(t3);


            ViewBag.MusicCd = cd3;
            return View();
        }
    }
}