using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QTCC_QuanLyBenhVien.Model.DTO;

namespace QTCC_QuanLyBenhVien.Model.DAO
{
    public class BenhNhanDAO
    {
        private readonly QLBenhVienDBContext _db;

        public BenhNhanDAO()
        {
            _db = new QLBenhVienDBContext();
        }

        public string AutoIncreaseMaYte()
        {
            string Id = "MYT";
            long subId = 2130000;
            long count = _db.BenhNhans.Count(x => x.MaYTe.Contains(Id));
            count = count + subId;
            BenhNhan benhnhan = new BenhNhan();
            benhnhan = _db.BenhNhans.SingleOrDefault(x => x.MaYTe.Equals(Id + count));
            while (benhnhan != null)
            {
                count += 1;
                benhnhan = _db.BenhNhans.SingleOrDefault(x => x.MaYTe.Equals(Id + count));
            }
            return Id + count;
        }

        public List<BenhNhan> GetAllBenhnhan()
        {
            return _db.BenhNhans.OrderByDescending(x => x.MaYTe).ToList();
        }

        public BenhNhan GetBenhNhanById(string id)
        {
            return _db.BenhNhans.SingleOrDefault(x => x.MaYTe==id);
        }

        public bool ThemBenhNhan(BenhNhan benhnhan)
        {
            if (GetBenhNhanById(benhnhan.MaYTe) == null)
            {
                try
                {
                    _db.BenhNhans.Add(benhnhan);
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

        public bool UpdateBenhnhan(BenhNhan benhnhan)
        {
            var bn = GetBenhNhanById(benhnhan.MaYTe);
            if ( bn!= null)
            {
                try
                {
                    bn.MaYTe = benhnhan.MaYTe;
                    bn.DiaChi = benhnhan.DiaChi;
                    bn.GioiTinh = benhnhan.GioiTinh;
                    bn.HoTen = benhnhan.HoTen;
                    bn.NamSinh = benhnhan.NamSinh;
                    bn.NgheNghiep = benhnhan.NgheNghiep;
                    bn.SoDT = benhnhan.SoDT;
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

        public bool DeleteBenhNhan(string id)
        {
            var bn = GetBenhNhanById(id);
            if (bn != null)
            {
                if (_db.LichSuKhamBenhs.Count(x => x.MaYTe==id) > 0)
                {
                    try
                    {
                        _db.BenhNhans.Remove(bn);
                        List<LichSuKhamBenh> ls = _db.LichSuKhamBenhs.Where(x => x.MaYTe == id).ToList();
                        _db.LichSuKhamBenhs.RemoveRange(ls);
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
                    try
                    {
                        _db.BenhNhans.Remove(bn);
                        _db.SaveChanges();
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
