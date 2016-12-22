using System.Windows.Forms;
using QTCC_QuanLyBenhVien.Model.DAO;
using QTCC_QuanLyBenhVien.Model.DTO;

namespace QTCC_QuanLyBenhVien
{
    public partial class ThemCapNhatBenhAn : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly int _mode;
        private readonly BenhNhan _bn;
        private readonly LichSuKhamBenh _ls = new LichSuKhamBenh();
        private readonly BenhNhanDAO _bnDao = new BenhNhanDAO();
        private readonly LichSuKhamBenhDAO _lsDao = new LichSuKhamBenhDAO();
        public ThemCapNhatBenhAn(string id)
        {
            InitializeComponent();
            _bn = _bnDao.GetBenhNhanById(id);
            BindTotextBox();
        }
        public ThemCapNhatBenhAn(LichSuKhamBenh ls,int mode)
        {
            InitializeComponent();
            _mode = mode;
            _ls = ls;
            _bn = _bnDao.GetBenhNhanById(_ls.MaYTe);
            BindTotextBox();
        }

        public void BindToVar()
        {
            _ls.MaYTe = txtMaYTe.Text;
            _ls.ChuanDoan = txtChanDoan.Text;
            _ls.LoiDan = txtLoiDan.Text;
            _ls.NgayTaiKham = txtNgayTaiKham.Text;
            _ls.TenThuoc = txtTenThuoc.Text;
        }

        public void BindTotextBox()
        {
            if (_mode == 1)
            {
                //label
                txtTenBN.Text = _bn.HoTen;
                txtGioiTinh.Text = _bn.GioiTinh;
                txtMaYTe.Text = _bn.MaYTe;
                txtNgaySinh.Text = _bn.NamSinh;
                //textbox
                txtChanDoan.Text = _ls.ChuanDoan;
                txtLoiDan.Text = _ls.LoiDan;
                txtNgayTaiKham.Text = _ls.NgayTaiKham;
                txtTenThuoc.Text = _ls.TenThuoc;
            }
            else
            {
                txtTenBN.Text = _bn.HoTen;
                txtGioiTinh.Text = _bn.GioiTinh;
                txtMaYTe.Text = _bn.MaYTe;
                txtNgaySinh.Text = _bn.NamSinh;
            }
        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_mode == 1)
            {
                BindToVar();
                var result = _lsDao.UpdateBenhAn(_ls);
                {
                    if (result)
                    {
                        //MessageBox.Show(@"Cập nhật thành công!");
                        Close();
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(HoSoKhamBenh))
                            {
                                form.WindowState = FormWindowState.Normal;
                                form.Activate();
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"Cập nhật thất bại thử lại!");
                    }
                }
            }
            else
            {
                BindToVar();
                var result = _lsDao.ThemBenhAn(_ls);
                {
                    if (result)
                    {
                        //MessageBox.Show(@"Thêm thành công!");
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(HoSoKhamBenh))
                            {
                                form.WindowState = FormWindowState.Normal;
                                form.Activate();
                                return;
                            }
                        }
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(@"Thêm thất bại thử lại!");
                    }
                }
            }
        }

        private void txtChanDoan_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChanDoan.Text))
            {
                errorProvider1.SetError(txtChanDoan,"Vui lòng nhập chẩn đoán!");
            }
        }

        private void txtTenThuoc_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenThuoc.Text))
            {
                errorProvider1.SetError(txtTenThuoc, "Vui lòng nhập tên thuốc!");
            }
        }

        private void txtLoiDan_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLoiDan.Text))
            {
                errorProvider1.SetError(txtLoiDan, "Vui lòng nhập lời dặn!");
            }
        }

        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var close = MessageBox.Show(@"Bạn có đồng ý thoát chương trình?", @"Tắt ứng dụng", MessageBoxButtons.YesNo);
            if (close != DialogResult.Yes)
            {
                //MessageBox.Show(@"The application has been closed successfully.", @"Application Closed!", MessageBoxButtons.OK);
                Activate();
            }
            else
            {
                Close();
            }
        }

        private void ThemCapNhatBenhAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}