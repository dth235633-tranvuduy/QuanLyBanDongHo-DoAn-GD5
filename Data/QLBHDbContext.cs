using System.Configuration; // Cần cài NuGet System.Configuration.ConfigurationManager
using LTQL_QLBHDongHo.Data;
using Microsoft.EntityFrameworkCore;


namespace LTQL_QLBHDongHo.Data
{
    public class QLBHDbContext : DbContext
    {
        public DbSet<LoaiDongHo> LoaiDongHo { get; set; }
        public DbSet<HangSanXuat> HangSanXuat { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<ThongSoKyThuat> ThongSoKyThuat { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<PhanQuyen> PhanQuyen { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Khớp với name="ChuoiKetNoi" trong App.config của bạn
                string conn = ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ConnectionString;
                optionsBuilder.UseSqlServer(conn);
            }
        }
    }
}