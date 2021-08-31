using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap1.Models;

namespace baitap1.Controllers
{
   
    public class GiaiPTController : Controller
    {
        // GET: GiaiPT
        GiaiPhuongTrinhb1 gpt = new GiaiPhuongTrinhb1();
        public ActionResult Index()
        {
            return View();
        }
      
       
        public ActionResult Giaiptb1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giaiptb1(double a, double b)
        {

            Double x = gpt.giaipt(a, b);
            ViewBag.nghiemPT = x;
            return View();


        }
    }
}