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
        public ActionResult Giaiptb1(string a, string b)
        {
            try
            {
                double soA = Convert.ToDouble(a);
                double soB = Convert.ToDouble(b);
                Double x = gpt.giaipt(soA, soB);
                ViewBag.nghiemPT = x;
            }
            catch (Exception)
            {
                ViewBag.nghiemPT = "Kiểu dữ liệu đầu vào không đúng";
            }
            return View();
        }
    }
}