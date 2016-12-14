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
        public bool Edit(BenhVienDTO bv)
        {
            bool result = false;
            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            String query = "Update LichSuKhamBenh Set MaYTe = @MaYTe, ChuanDoan = @ChuanDoan,TenThuoc = @TenThuoc,LoiDan = @LoiDan, NgayTaiKham = @NgayTaiKham Where MaYTe = @MaYTe; Update BenhNhan Set MaYTe = @MaYTe, HoTen = @HoTen, NamSinh = @NamSinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, NgheNghiep = @NgheNghiep, SoDT = @SoDT Where MaYTe = @MaYTe";
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

        public List<BenhVienDTO> SearchName(String name)
        {
            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            String query = "select b.MaYTe,b.HoTen,b.NamSinh,b.GioiTinh,b.NgheNghiep,b.DiaChi,b.SoDT, l.ChuanDoan,l.TenThuoc,l.LoiDan,l.NgayTaiKham from BenhNhan b, LichSuKhamBenh l where b.MaYTe = l.MaYTe and b.HoTen like N'%" + name + "%'";
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BenhVienDTO> ls = new List<BenhVienDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BenhVienDTO bv = new BenhVienDTO();
                bv.MaYTe = dt.Rows[i]["MaYTe"].ToString();
                bv.HoTen = dt.Rows[i]["HoTen"].ToString();
                bv.NamSinh = dt.Rows[i]["NamSinh"].ToString();
                bv.GioiTinh = dt.Rows[i]["GioiTinh"].ToString();
                bv.NgheNghiep = dt.Rows[i]["NgheNghiep"].ToString();
                bv.DiaChi = dt.Rows[i]["DiaChi"].ToString();
                bv.SoDT = dt.Rows[i]["SoDT"].ToString();
                bv.ChuanDoan = dt.Rows[i]["ChuanDoan"].ToString();
                bv.TenThuoc = dt.Rows[i]["TenThuoc"].ToString();
                bv.LoiDan = dt.Rows[i]["LoiDan"].ToString();
                bv.NgayTaiKham = dt.Rows[i]["NgayTaiKham"].ToString();
                ls.Add(bv);
            }
            con.Close();
            return ls;
          
        }

    }
}
