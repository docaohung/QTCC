using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTCC_QuanLyBenhVien.Model.DTO;

namespace QTCC_QuanLyBenhVien.Model.DAO
{
    public class LichSuKhamBenhDAO
    {
        private readonly QLBenhVienDBContext _db;

        public LichSuKhamBenhDAO()
        {
            _db = new QLBenhVienDBContext();
        }

        public int CountBenhAn(string id)
        {
            return _db.LichSuKhamBenhs.Count(x => x.MaYTe == id);
        }

        public List<LichSuKhamBenh> GetAll()
        {
            return _db.LichSuKhamBenhs.ToList();
        }

        public List<LichSuKhamBenh> GetByMaYte(string id)
        {
            return _db.LichSuKhamBenhs.Where(x => x.MaYTe == id).ToList();
        }

        public LichSuKhamBenh GetBenhAnById(int id)
        {
            return _db.LichSuKhamBenhs.SingleOrDefault(x => x.ID == id);
        }

        public bool ThemBenhAn(LichSuKhamBenh ls)
        {
            if (ls!=null)
            {
                try
                {
                    _db.LichSuKhamBenhs.Add(ls);
                    _db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            return false;
        }

        public bool UpdateBenhAn(LichSuKhamBenh ls)
        {
            var ba = GetBenhAnById(ls.ID);
            if (ba != null && !string.IsNullOrEmpty(ls.ChuanDoan) && !string.IsNullOrEmpty(ls.LoiDan) && !string.IsNullOrEmpty(ls.NgayTaiKham) && !string.IsNullOrEmpty(ls.TenThuoc))
            {
                try
                {
                    ba.MaYTe = ls.MaYTe;
                    ba.ChuanDoan = ls.ChuanDoan;
                    ba.LoiDan = ls.LoiDan;
                    ba.NgayTaiKham = ls.NgayTaiKham;
                    ba.TenThuoc = ls.TenThuoc;
                    _db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool XoaBenhAn(LichSuKhamBenh ls)
        {
            try
            {
                _db.LichSuKhamBenhs.Remove(ls);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
