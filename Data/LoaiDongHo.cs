using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LTQL_QLBHDongHo.Data
{
    public class LoaiDongHo
    {
        public int ID { get; set; }

        public string TenLoai { get; set; } = string.Empty; // Thêm gán giá trị mặc định để hết gạch chân xanh

        // Quan hệ 1 - Nhiều: 1 loại có nhiều sản phẩm
        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}