using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using HospitalManagement.EL;

namespace HospitalManagement.DAL
{
    class HospitalDAO
    {

        //Lay Data hien Thi ra gridView
        //public static List<ClothesDTO> loadAll()
        public DataTable loadAll()
        {


            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            DataTable dt = new DataTable();
            String query = "Select * from Patient";
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
        //Them (Insert)
        public bool Insert(HospitalDTO  hos)
        {
            bool result = false;

            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            //String query1 = "Select count (Ten) from Clothes where Ten= @Ten";
            //SqlCommand cmd1 = new SqlCommand(query1, con);
            //cmd1.Parameters.Add(new SqlParameter("@Ten", clo.Ten));
            //int count = (int)cmd1.ExecuteScalar();
            //if (count > 0)
            //{
            //    result = false;
            //}
            //else
            //{

            String query = "INSERT INTO Patient(Name,Birth,Address,MedicalHistory,SecondExamine ) VALUES(@Name,@Birth,@Address,@MedicalHistory,@SecondExamine)";
            SqlCommand cmd = new SqlCommand(query, con);
           // cmd.Parameters.Add(new SqlParameter("@ID", hos.ID));
            cmd.Parameters.Add(new SqlParameter("@Name", hos.Name));
            cmd.Parameters.Add(new SqlParameter("@Birth", hos.Birth));
            cmd.Parameters.Add(new SqlParameter("@Address", hos.Address));
            cmd.Parameters.Add(new SqlParameter("@MedicalHistory", hos.MedicalHistory));
            cmd.Parameters.Add(new SqlParameter("@SecondExamine", hos.SecondExamine));
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0) result = true;
            //}
            con.Close();
            return result;
        }
        //public bool Delete(HospitalDTO hos)
        //{
        //    bool result = false;
        //    String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
        //    SqlConnection con = new SqlConnection(connect);
        //    con.Open();
        //    String query = "DELETE  From Patient Where ID = @ID";
        //    SqlCommand cmd = new SqlCommand(query, con);
        //    cmd.Parameters.Add(new SqlParameter("@ID", hos.ID));
        //    //   int rows = 
        //    cmd.ExecuteNonQuery();
        //    //if (rows > 0)
        //    result = true;
        //    con.Close();
        //    return result;
        //}


        //Chinh Sua(Update)
        public bool Update(HospitalDTO hos)
        {
            bool result = false;



            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();

            String query = "Update Patient Set  Name = @Name, Birth = @Birth, Address = @Address, MedicalHistory = @MedicalHistory, SecondExamine = @SecondExamine Where ID = @ID ";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@ID", hos.ID));
            cmd.Parameters.Add(new SqlParameter("@Name", hos.Name));
            cmd.Parameters.Add(new SqlParameter("@Birth", hos.Birth));
            cmd.Parameters.Add(new SqlParameter("@Address", hos.Address));
            cmd.Parameters.Add(new SqlParameter("@MedicalHistory", hos.MedicalHistory));
            cmd.Parameters.Add(new SqlParameter("@SecondExamine", hos.SecondExamine));

            int rows = cmd.ExecuteNonQuery();
            if (rows > 0) result = true;
            con.Close();
            return result;
        }

        //Tim Kiem
        public List<HospitalDTO> findName(String name)
        {


            String connect = ConfigurationManager.ConnectionStrings["data"].ConnectionString;
            SqlConnection con = new SqlConnection(connect);
            con.Open();
            //find with keyword
            String query = "Select * From Patient Where Name like N'%" + name + "%'";
            // String query = "Select * From Clothes Where Ten = N'" + name + "'"; // find with exactly name
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<HospitalDTO> ls = new List<HospitalDTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HospitalDTO hos = new HospitalDTO();
                hos.ID = int.Parse(dt.Rows[i]["ID"].ToString());
                hos.Name = dt.Rows[i]["Name"].ToString();
                hos.Birth = dt.Rows[i]["Birth"].ToString();
                hos.Address = dt.Rows[i]["Address"].ToString();
                hos.MedicalHistory = dt.Rows[i]["MedicalHistory"].ToString();
                hos.SecondExamine = dt.Rows[i]["SecondExamine"].ToString();
                
                ls.Add(hos);

            }


            con.Close();
            return ls;





        }
    }
}
