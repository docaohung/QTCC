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
                ChiTiet_Load(sender, e);
            }
            catch( Exception )
            {
              
            }
        }

        private void abtnSua_Click(object sender, EventArgs e)
        {
            
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
       
        private void ChiTiet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg;          
            dg = MessageBox.Show("Bạn Có Chắc Là Muốn Thoát?","Có",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
            if(dg == DialogResult.Yes){
            }
            else{
                e.Cancel = true;
            }
        }
       
        private void abtnReLoad_Click(object sender, EventArgs e)
        {
            ChiTiet_Load(sender, e);
        }
    }
}
