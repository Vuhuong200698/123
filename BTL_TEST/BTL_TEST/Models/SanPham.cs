using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_TEST.Models
{
    public class SanPham
    {
        [Key]
        [StringLength(20)]
        [DisplayName("Mã Sản Phẩm")]
        public string MaSanPham { get; set; }
        [StringLength(50)]
        [DisplayName("Tên Sản Phẩm")]
        public string TenSanPham { get; set; }
        // MANhaCungCap la khoa phu
        [DisplayName("Mã Nhà Cung Cấp")]
        public int MaNhaCungCap { get; set; }

        [ForeignKey("MaNhaCungCap")]
        public virtual NhaCungCap NhaCungCap { get; set; }

    }
}