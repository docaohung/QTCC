using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.EF
{
    class BenhVienDTO
    {
        private String mayte;
        private String hoten;
        private String namsinh;
        private String gioitinh;
        private String diachi;
        private String nghenghiep;
        private String sodt;
        private String chuandoan;
        private String tenthuoc;
        private String loidan;
        private String ngaytaikham;


        public BenhVienDTO()
        {

        }
        public BenhVienDTO(String mayte, String hoten, String namsinh, String gioitinh, String diachi,
            String nghenghiep,String sodt, String chuandoan, String tenthuoc, String loidan, String ngaytaikham)
        {
            this.mayte = mayte;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.diachi = diachi;
            this.nghenghiep = nghenghiep;
            this.sodt = sodt;
            this.chuandoan = chuandoan;
            this.tenthuoc = tenthuoc;
            this.loidan = loidan;
            this.ngaytaikham = ngaytaikham;
                
        }
        public String MaYTe
        {
            get { return this.mayte; }
            set { this.mayte = value; }
        }
        public String HoTen
        {
            get { return this.hoten; }
            set { this.hoten = value; }
        }
        public String NamSinh
        {
            get { return this.namsinh; }
            set { this.namsinh = value; }
        }
        public String GioiTinh
        {
            get { return this.gioitinh; }
            set { this.gioitinh = value; }
        }
        public String DiaChi
        {
            get { return this.diachi; }
            set { this.diachi = value; }
        }
        public String NgheNghiep
        {
            get { return this.nghenghiep;}
            set { this.nghenghiep = value; }
        }
        public String SoDT
        {
            get { return this.sodt; }
            set { this.sodt = value; }
        }
        public String ChuanDoan
        {
            get { return this.chuandoan; }
            set { this.chuandoan = value; }
        }
        public String TenThuoc
        {
            get { return this.tenthuoc; }
            set { this.tenthuoc = value; }
        }
        public String LoiDan
        {
            get { return this.loidan; }
            set { this.loidan = value; }
        }
        public String NgayTaiKham
        {
            get { return this.ngaytaikham; }
            set { this.ngaytaikham = value; }
        }
        
        
        
    }
}
