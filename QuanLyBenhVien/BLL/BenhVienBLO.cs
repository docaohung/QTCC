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
        public DataTable LoadAllData()
        {
            return new BenhVienDAO().LoadAll();

        }
    }
}
