using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBenhVien.EF;
using QuanLyBenhVien.DAL;

namespace QuanLyBenhVien.BLL
{
    class BenhVienBLO
    {
        public DataTable LoadAll()
        {
            return new BenhVienDAO().LoadAll();
        }
        public bool Insert(BenhVienDTO bv)
        {
            if (bv.MaYTe.Equals("") || bv.HoTen.Equals("") || bv.NamSinh.Equals("") || bv.GioiTinh.Equals("") || bv.NgheNghiep.Equals("") || bv.DiaChi.Equals("") || bv.SoDT.Equals("") || bv.ChuanDoan.Equals("")||bv.TenThuoc.Equals("")||bv.LoiDan.Equals("")||bv.NgayTaiKham.Equals(""))
                return false;
            bool result = new BenhVienDAO().Insert(bv);
            return result;

         }
        public bool Edit(BenhVienDTO bv)
        {
            if (bv.MaYTe.Equals("") || bv.HoTen.Equals("") || bv.NamSinh.Equals("") || bv.GioiTinh.Equals("") || bv.NgheNghiep.Equals("") || bv.DiaChi.Equals("") || bv.SoDT.Equals("") || bv.ChuanDoan.Equals("") || bv.TenThuoc.Equals("") || bv.LoiDan.Equals("") || bv.NgayTaiKham.Equals(""))
                return false;
            bool result = new BenhVienDAO().Edit(bv);
            return result;

        }
        public bool Delete(BenhVienDTO bv)
        {
            if (bv.MaYTe.Equals("") || bv.HoTen.Equals("") || bv.NamSinh.Equals("") || bv.GioiTinh.Equals("") || bv.NgheNghiep.Equals("") || bv.DiaChi.Equals("") || bv.SoDT.Equals("") || bv.ChuanDoan.Equals("") || bv.TenThuoc.Equals("") || bv.LoiDan.Equals("") || bv.NgayTaiKham.Equals(""))
                return false;
            bool result = new BenhVienDAO().Delete(bv);
            return result;

        }
        public List<BenhVienDTO> SearchName(String name)
        {
            return new BenhVienDAO().SearchName(name);
        }

    }
}
