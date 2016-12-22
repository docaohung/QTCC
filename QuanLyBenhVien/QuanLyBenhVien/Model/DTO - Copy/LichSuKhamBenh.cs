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
        public string MaYTe { get; set; }

        [Required]
        public string ChuanDoan { get; set; }

        [Required]
        public string TenThuoc { get; set; }

        [Required]
        public string LoiDan { get; set; }

        [Required]
        [StringLength(50)]
        public string NgayTaiKham { get; set; }

        public virtual BenhNhan BenhNhan { get; set; }
    }
}
