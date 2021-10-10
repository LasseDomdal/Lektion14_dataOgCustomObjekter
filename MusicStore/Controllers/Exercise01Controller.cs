using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class Exercise01Controller : Controller
    {
        // GET: Exercise01
        public ActionResult Index()
        {

            Book book1 = new Book("Kafka on the shore", 149, "kafka_on_the_shore.png", "Haruki Murakami", "Shinchoscha", 2002, "1-84343-110-6");

            ViewBag.Book = book1;

            MusicCd cd1 = new MusicCd("Gumbo", 300, "Gumbo.jpg", "Pede b & Tue Track", "Sony Music", 2021);
            cd1.AddTrack("Roux");
            cd1.AddTrack("Dum og Dummere");
            cd1.AddTrack("Kender en");
            cd1.AddTrack("Store Pede");
            cd1.AddTrack("CtrlAltDel");
            cd1.AddTrack("Ketchuhl");
            cd1.AddTrack("Nyreslag");
            cd1.AddTrack("Må jeg være fri");
            cd1.AddTrack("Min by");
            cd1.AddTrack("Gi' mit styrke");
            cd1.AddTrack("Ornli'");


            ViewBag.MusicCd = cd1;

            return View();
        }
    }
}