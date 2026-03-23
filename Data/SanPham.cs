using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LTQL_QLBHDongHo.Data
{
    public class SanPham
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string TenSanPham { get; set; } = string.Empty;

        public int DonGia { get; set; }

        public int SoLuong { get; set; }

        [StringLength(500)]
        public string? HinhAnh { get; set; }

        public string? MoTa { get; set; }

        [Required]
        public int HangSanXuatID { get; set; }

        [Required]
        public int LoaiDongHoID { get; set; }

        // --- Liên kết ngoại (Navigation Properties) ---

        [ForeignKey("HangSanXuatID")]
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;

        [ForeignKey("LoaiDongHoID")]
        public virtual LoaiDongHo LoaiDongHo { get; set; } = null!;

        // Danh sách các thông số kỹ thuật (Dùng cho logic "Xem chi tiết" của bạn)
        public virtual ObservableCollectionListSource<ThongSoKyThuat> ThongSoKyThuat { get; } = new();

        // Danh sách các dòng hóa đơn liên quan
        public virtual ObservableCollectionListSource<HoaDonChiTiet> HoaDonChiTiet { get; } = new();
    }
}
