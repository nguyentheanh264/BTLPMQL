using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTLPMQL.Models
{
    [Table("DonHangs")]
    public class DonHang
    {
        [Key]
        public int MaDonHang { get; set; }
        public string TenSanPham { get; set; }
        public int Gia { get; set; }
        public int ThoiGianMuaHang { get; set; }
        public int TongThanhToan { get; set; }
    }
}