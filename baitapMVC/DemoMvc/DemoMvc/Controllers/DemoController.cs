using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoMvc.Models;

namespace DemoMvc.Controllers
{
    public class DemoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        {
            return View();
        }
        public ActionResult GiaiPhuongTrinhB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPhuongTrinhB1(double SoA,double SoB)
        {

            Double x = gpt.GiaiPhuongTrinhBac1(SoA, SoB);
            ViewBag.nghiemPT = x;
            return View();
        }

    }
}