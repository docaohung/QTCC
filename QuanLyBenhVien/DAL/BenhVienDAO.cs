using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyBenhVien.EF;
using System.Configuration;

namespace QuanLyBenhVien.DAL
{
    class BenhVienDAO
    {
        public DataTable LoadAll()
        {


            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            DataTable dt = new DataTable();
            String query = "select b.MaYTe, b.HoTen, b.NamSinh, b.GioiTinh, b.DiaChi, b.NgheNghiep, l.SoDT, l.DoiTuong, l.ChuanDoan, l.TenThuoc, l.LoiDan, l.NgayTaiKham from BenhNhan b, LichSuKhamBenh l where b.MaYTe = l.MaYTe";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();
            return dt;

            /*
            List<ClothesDTO> ls = new List<ClothesDTO>();
            foreach (DataRow row in dt.Rows)
            {
                ClothesDTO cldto = new ClothesDTO();
                cldto.ID = int.Parse(row["ID"].ToString());
                cldto.Ten = row["Ten"].ToString();
                cldto.SoLuong = int.Parse(row["SoLuong"].ToString());
                cldto.Gia = int.Parse(row["Gia"].ToString());
                cldto.Size = row["Size"].ToString();
                cldto.Mau = row["Mau"].ToString();
                cldto.GioiTinh = row["GioiTinh"].ToString();
                ls.Add(cldto);
            }

            return ls;
             */
        }
    }
}
