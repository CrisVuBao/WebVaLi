﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Web_MVC_Core.Models
{
    public partial class THoaDonBan
    {
        public THoaDonBan()
        {
            TChiTietHdbs = new HashSet<TChiTietHdb>();
        }

        public string MaHoaDon { get; set; }
        public DateTime? NgayHoaDon { get; set; }
        public string MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }
        public decimal? TongTienHd { get; set; }
        public double? GiamGiaHd { get; set; }
        public byte? PhuongThucThanhToan { get; set; }
        public string MaSoThue { get; set; }
        public string ThongTinThue { get; set; }
        public string GhiChu { get; set; }

        public virtual TKhachHang MaKhachHangNavigation { get; set; }
        public virtual TNhanVien MaNhanVienNavigation { get; set; }
        public virtual ICollection<TChiTietHdb> TChiTietHdbs { get; set; }
    }
}