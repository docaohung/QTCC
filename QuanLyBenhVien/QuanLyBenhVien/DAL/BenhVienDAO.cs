using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using QuanLyBenhVien.EF;


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
            String query = "select b.MaYTe,b.HoTen,b.NamSinh,b.GioiTinh,b.NgheNghiep,b.DiaChi,b.SoDT, l.ChuanDoan,l.TenThuoc,l.LoiDan,l.NgayTaiKham from BenhNhan b, LichSuKhamBenh l where b.MaYTe = l.MaYTe";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            con.Close();
            return dt;
        }
        public bool Insert(BenhVienDTO bv)
        {
            bool result = false;
            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            String query = "INSERT INTO BenhNhan(MaYTe,HoTen,NamSinh,GioiTinh,DiaChi,NgheNghiep,SoDT) VALUES (@MaYTe,@HoTen,@NamSinh,@GioiTinh,@DiaChi,@NgheNghiep,@SoDT); INSERT INTO LichSuKhamBenh(MaYTe,ChuanDoan,TenThuoc,LoiDan,NgayTaiKham) VALUES (@MaYTe,@ChuanDoan,@TenThuoc,@LoiDan,@NgayTaiKham);";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@MaYTe", bv.MaYTe));
            cmd.Parameters.Add(new SqlParameter("@HoTen", bv.HoTen));
            cmd.Parameters.Add(new SqlParameter("@NamSinh", bv.NamSinh));
            cmd.Parameters.Add(new SqlParameter("@GioiTinh", bv.GioiTinh));
            cmd.Parameters.Add(new SqlParameter("@DiaChi", bv.DiaChi));
            cmd.Parameters.Add(new SqlParameter("@NgheNghiep", bv.NgheNghiep));
            cmd.Parameters.Add(new SqlParameter("@SoDT", bv.SoDT));
            cmd.Parameters.Add(new SqlParameter("@ChuanDoan", bv.ChuanDoan));
            cmd.Parameters.Add(new SqlParameter("@TenThuoc", bv.TenThuoc));
            cmd.Parameters.Add(new SqlParameter("@LoiDan", bv.LoiDan));
            cmd.Parameters.Add(new SqlParameter("@NgayTaiKham", bv.NgayTaiKham));
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0) result = true;
            con.Close();
            return result;
        }
        
        

        
    }
}
