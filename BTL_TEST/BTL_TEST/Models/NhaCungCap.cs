using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTL_TEST.Models
{
    public class NhaCungCap
    {
        [Key]
        [DisplayName("Mã Nhà Cung Cấp")]
        public int MaNhaCungCap { get; set; }
        [StringLength(50)]
        [DisplayName("Tên Nhà Cung Cấp")]
        public string TenNhaCungCap { get; set; }
        // 1 nha cung cap co nhieu san pham
        public ICollection<SanPham> SanPhams { get; set; }
    }
}