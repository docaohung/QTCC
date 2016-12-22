namespace QTCC_QuanLyBenhVien.Model.DTO
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BenhNhan")]
    public partial class BenhNhan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BenhNhan()
        {
            LichSuKhamBenhs = new HashSet<LichSuKhamBenh>();
        }

        [Key]
        [StringLength(50)]
        [Display(Name = @"Mã y tế", Description = @"Mã y tế")]
        public string MaYTe { get; set; }

        [Required]
        [Display(Name = @"Họ tên", Description = @"Họ tên")]
        public string HoTen { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = @"Năm sinh", Description = @"Năm sinh")]
        public string NamSinh { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = @"Giới tính", Description = @"Giới tính")]
        public string GioiTinh { get; set; }

        [Required]
        [Display(Name = @"Địa chỉ", Description = @"Địa chỉ")]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = @"Nghề nghiệp", Description = @"Nghề nghiệp")]
        public string NgheNghiep { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = @"Số điện thoại", Description = @"Số điện thoại")]
        public string SoDT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuKhamBenh> LichSuKhamBenhs { get; set; }
    }
}
