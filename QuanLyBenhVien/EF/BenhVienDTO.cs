using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBenhVien.EF
{
    class BenhVienDTO
    {
        private int maYTe;
        private String hoTen;
        private String namSinh;
        private String gioiTinh;
        private String diaChi;
        private String ngheNghiep;
        private String soDT;
        private String doiTuong;
        private String chuanDoan;
        private String tenThuoc;
        private String loiDan;
        private String ngayTaiKham;


        public BenhVienDTO() { }
        public BenhVienDTO(int maYTe, String hoTen, String namSinh, String gioiTinh, String diaChi, String ngheNghiep,
                            String soDT, String doiTuong, String chuanDoan, String tenThuoc, String loiDan, String ngayTaiKham)
        {
            this.maYTe = maYTe;
            this.hoTen = hoTen;
            this.namSinh = namSinh;
            this.gioiTinh = gioiTinh;
            this.diaChi = diaChi;
            this.ngheNghiep = ngheNghiep;
            this.soDT = soDT;
            this.doiTuong = doiTuong;
            this.chuanDoan = chuanDoan;
            this.tenThuoc = tenThuoc;
            this.loiDan = loiDan;
            this.ngayTaiKham = ngayTaiKham;
        }
        public int MaYTe
        {
            get { return this.maYTe; }
            set { this.maYTe = value; }
        }
        public String HoTen
        {
            get { return this.hoTen; }
            set { this.hoTen = value; }
        }

        public String NamSinh
        {
            get { return this.namSinh; }
            set { this.namSinh = value; }
        }
        public String GioiTinh
        {
            get { return this.gioiTinh; }
            set { this.gioiTinh = value; }
        }
        public String DiaChi
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
        public String NgheNghiep
        {
            get { return this.ngheNghiep; }
            set { this.ngheNghiep = value; }
        }

        public String SoDT
        {
            get { return this.soDT; }
            set { this.soDT = value; }
        }
        public String DoiTuong
        {
            get { return this.doiTuong; }
            set { this.doiTuong = value; }
        }

        public String ChuanDoan
        {
            get { return this.chuanDoan; }
            set { this.chuanDoan = value; }
        }
        public String TenThuoc
        {
            get { return this.tenThuoc; }
            set { this.tenThuoc = value; }
        }
        public String LoiDan
        {
            get { return this.diaChi; }
            set { this.diaChi = value; }
        }
        public String NgayTaiKham
        {
            get { return this.ngayTaiKham; }
            set { this.ngayTaiKham = value; }
        }
    }
}
