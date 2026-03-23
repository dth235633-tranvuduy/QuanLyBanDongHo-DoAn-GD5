using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LTQL_QLBHDongHo.Data
{
    public class HoaDon
    {
        public int ID { get; set; }
        public int NhanVienID { get; set; } // Ai bán?
        public int KhachHangID { get; set; } // Ai mua?
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public string? GhiChuHoaDon { get; set; }

        // Liên kết: Một hóa đơn có nhiều dòng chi tiết
        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();

        // Liên kết ngược lại để lấy tên NV/KH
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }
}