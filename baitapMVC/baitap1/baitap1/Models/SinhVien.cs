using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace baitap1.Models
{
    public class SinhVien
    {
        [Key]
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
    }
}