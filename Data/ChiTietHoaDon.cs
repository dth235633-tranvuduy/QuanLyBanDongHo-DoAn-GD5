using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LTQL_QLBHDongHo.Data;

namespace LTQL_QLBHDongHo.Data
{
    public class HoaDonChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; } // Thuộc hóa đơn nào?
        public int SanPhamID { get; set; } // Bán cái đồng hồ nào?
        public short SoLuongBan { get; set; } // Bán bao nhiêu cái?
        public int DonGiaBan { get; set; } // Giá bán lúc đó (vì giá có thể thay đổi theo thời gian)

        // Liên kết ngược lại để biết chi tiết này thuộc hóa đơn nào và sản phẩm nào
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }
}