using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoMvc.Models
{
    public class GiaiPhuongTrinh
    {
        public double GiaiPHuongTrinhBacNhat(double a, double b)
        {
            double x;
            x = -b / a; 
            return x;
            
        }
    }
}