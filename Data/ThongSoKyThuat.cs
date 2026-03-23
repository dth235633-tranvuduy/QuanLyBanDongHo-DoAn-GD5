using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LTQL_QLBHDongHo.Data;

namespace LTQL_QLBHDongHo.Data
{
    public class ThongSoKyThuat
    {
        public int ID { get; set; }
        public int SanPhamID { get; set; }
        public string TenThongSo { get; set; } // VD: Loại máy, Chống nước...
        public string GiaTri { get; set; }     // VD: Cơ (Automatic), 5ATM...

        public virtual SanPham SanPham { get; set; } = null!;
    }
}