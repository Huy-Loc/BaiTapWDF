using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace baitap1.Models
{
    public class LapTrinhQuanLyDBcontext: DbContext
    {
        public LapTrinhQuanLyDBcontext() : base("LapTrinhQuanLyDBcontext")
        {
        }
        //ánh xạ các đôí tượng vào trong database
        public DbSet<Student> Students { get; set; }
        public DbSet<SinhVien> SinhViens { get; set; }
       
    }
}
//LAPTOP - 6S4HBANT\SQLEXPRESS