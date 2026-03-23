using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace LTQL_QLBHDongHo.Data
{
    public class HangSanXuat
    {
        public int ID { get; set; }
        public string TenHangSanXuat { get; set; } // VD: Casio, Rolex...
        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}