namespace QTCC_QuanLyBenhVien.Model.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuKhamBenh")]
    public partial class LichSuKhamBenh
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = @"Mã y tế", Description = @"Mã y tế")]
        public string MaYTe { get; set; }

        [Required]
        [Display(Name = @"Chuẩn đoán", Description = @"Chuẩn đoán")]
        public string ChuanDoan { get; set; }

        [Required]
        [Display(Name = @"Tên thuốc", Description = @"Tên thuốc")]
        public string TenThuoc { get; set; }

        [Required]
        [Display(Name = @"Lời dặn", Description = @"Lời dặn")]
        public string LoiDan { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = @"Ngày tái khám", Description = @"Ngày tái khám")]
        public string NgayTaiKham { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }
    }
}
