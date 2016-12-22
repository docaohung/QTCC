using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBenhVien.EF;
using QuanLyBenhVien.BLL;

namespace QuanLyBenhVien
{
    public partial class ChiTiet : Form
    {
        public ChiTiet()
        {
            InitializeComponent();
        }

        private void ChiTiet_Load(object sender, EventArgs e)
        {
            gridViewChiTiet.DataSource = new BenhVienBLO().LoadAll();

        }

        private void abtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                BenhVienDTO bv = new BenhVienDTO(txtMaYTe.Text, txtHoTen.Text, txtNamSinh.Text, txtGioiTinh.Text, txtDiaChi.Text, txtNgheNghiep.Text, txtSoDT.Text, txtChuanDoan.Text, txtTenThuoc.Text, txtLoiDan.Text, txtNgayTaiKham.Text);
                if (new BenhVienBLO().Insert(bv))
                
                    MessageBox.Show(this, "Thành Công");              
                else
                    MessageBox.Show(this, "Không Thành Công , Mời Kiếm Tra Lại Các Thông Tin Đã Đầy Đủ Chưa \nLưu Ý: Bạn Không Được Nhập Trùng Mã Y Tế"); 
                ChiTiet_Load(sender, e);
            }
            catch( Exception )
            {
              //  if (txtMaYTe.Equals("") || txtHoTen.Equals("") || txtNamSinh.Equals("") || txtGioiTinh.Equals("") || txtNgheNghiep.Equals("") || txtDiaChi.Equals("") || txtSoDT.Equals("") || txtChuanDoan.Equals("")) 
                      //   MessageBox.Show(this, "Mời Nhập Đủ Thông Tin");
                
            }
        }

        private void abtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                BenhVienDTO bv = new BenhVienDTO(txtMaYTe.Text, txtHoTen.Text, txtNamSinh.Text, txtGioiTinh.Text, txtDiaChi.Text, txtNgheNghiep.Text, txtSoDT.Text, txtChuanDoan.Text, txtTenThuoc.Text, txtLoiDan.Text, txtNgayTaiKham.Text);
                if (new BenhVienBLO().Edit(bv))
                    MessageBox.Show(this, "Thành Công");
                else
                    MessageBox.Show(this, "Không Thành Công, Mời Kiểm Tra Lại Các Thông Tin Đã Đầy Đủ Chưa \nLưu Ý: Bạn Không Được Quyền Sửa Mã Y Tế");
                ChiTiet_Load(sender, e);
            }
            catch (Exception)
            {
            }
        }

        int dong;
        private void gridViewChiTiet_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            try
            {

                txtMaYTe.Text = gridViewChiTiet.Rows[dong].Cells[0].Value.ToString();
                txtHoTen.Text = gridViewChiTiet.Rows[dong].Cells[1].Value.ToString();
                txtNamSinh.Text = gridViewChiTiet.Rows[dong].Cells[2].Value.ToString();
                txtGioiTinh.Text = gridViewChiTiet.Rows[dong].Cells[3].Value.ToString();
                txtNgheNghiep.Text = gridViewChiTiet.Rows[dong].Cells[4].Value.ToString();
                txtDiaChi.Text = gridViewChiTiet.Rows[dong].Cells[5].Value.ToString();
                txtSoDT.Text = gridViewChiTiet.Rows[dong].Cells[6].Value.ToString();
                txtChuanDoan.Text = gridViewChiTiet.Rows[dong].Cells[7].Value.ToString();
                txtTenThuoc.Text = gridViewChiTiet.Rows[dong].Cells[8].Value.ToString();
                txtLoiDan.Text = gridViewChiTiet.Rows[dong].Cells[9].Value.ToString();
                txtNgayTaiKham.Text = gridViewChiTiet.Rows[dong].Cells[10].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void abtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dg;        
                BenhVienDTO bv = new BenhVienDTO(txtMaYTe.Text, txtHoTen.Text, txtNamSinh.Text, txtGioiTinh.Text, txtDiaChi.Text, txtNgheNghiep.Text, txtSoDT.Text, txtChuanDoan.Text, txtTenThuoc.Text, txtLoiDan.Text, txtNgayTaiKham.Text);
                dg = MessageBox.Show("Bạn Có Muốn Xóa Không", "Xóa",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
                if (dg == DialogResult.Yes)
                {
                    if (new BenhVienBLO().Delete(bv))
                        MessageBox.Show(this, "Thành Công");
                    else
                        MessageBox.Show(this, "Không Thành Công, Mời Chọn Một Dòng Để Xóa");
                    ChiTiet_Load(sender, e);
                }
                
            }
            catch (Exception)
            {
            }

        }

        private void abtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtTimKiem.Text;
                List<BenhVienDTO> ls = new BenhVienBLO().SearchName(name);
                if(ls.Count() != 0 && txtTimKiem.Text != "" )
                {
                    MessageBox.Show(this, "Tìm Thấy");
                    gridViewChiTiet.DataSource = ls;
                }
                else
                {
                    MessageBox.Show(this, "Bạn Chưa Nhập Tên Người Muốn Tìm");
                }

            }
            catch (Exception)
            {
                //if (txtTimKiem.Text == "")
                //    MessageBox.Show(this, "Bạn Chưa Nhập Tên Người Muốn Tìm");
                //else
                    MessageBox.Show(this, "Không Tìm Thấy");
            }
            

        }

        private void ChiTiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg;          
            dg = MessageBox.Show("Bạn Có Chắc Là Muốn Thoát?","Có",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if(dg == DialogResult.Yes)
            {

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void abtnClear_Click(object sender, EventArgs e)
        {
            txtMaYTe.Text = "";
            txtHoTen.Text = "";
            txtNamSinh.Text ="";
            txtGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtNgheNghiep.Text = "";
            txtSoDT.Text = "";
            txtChuanDoan.Text = "";
            txtTenThuoc.Text = "";
            txtLoiDan.Text = "";
            txtNgayTaiKham.Text = "";



        }

        private void abtnReLoad_Click(object sender, EventArgs e)
        {
            ChiTiet_Load(sender, e);
        }
    }
}
