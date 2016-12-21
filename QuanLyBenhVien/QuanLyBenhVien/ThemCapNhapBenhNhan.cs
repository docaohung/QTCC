using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QTCC_QuanLyBenhVien.Model.DAO;
using QTCC_QuanLyBenhVien.Model.DTO;

namespace QTCC_QuanLyBenhVien
{
    public partial class ThemCapNhapBenhNhan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly int _mode;
        private BenhNhan _BenhNhan;
        private readonly BenhNhanDAO _bnDao = new BenhNhanDAO();
        public ThemCapNhapBenhNhan()
        {
            InitializeComponent();
            txtMayte.Text = _bnDao.AutoIncreaseMaYte();
            BindToComboboxGt();
        }

        public void BindToComboboxGt(string gender=null)
        {
            var list = new List<string> {@"Nam", @"Nữ"};
            txtGioiTinh.DataSource = list;
            if (!string.IsNullOrEmpty(gender))
            {
               txtGioiTinh.SelectedIndex = txtGioiTinh.FindStringExact(gender);
            }
        }
        public void BindToVar()
        {
            _BenhNhan = new BenhNhan();
            _BenhNhan.MaYTe = txtMayte.Text;
            _BenhNhan.HoTen = txtHoTen.Text;
            _BenhNhan.DiaChi = txtDiaChi.Text;
            _BenhNhan.NamSinh = txtNgaySinh.Text;
            _BenhNhan.GioiTinh = txtGioiTinh.Text;
            _BenhNhan.NgheNghiep = txtNgheNghiep.Text;
            _BenhNhan.SoDT = txtSoDienthoai.Text;
        }

        public void BindToTextBox()
        {
            txtMayte.Text = _BenhNhan.MaYTe;
            txtHoTen.Text = _BenhNhan.HoTen;
            txtDiaChi.Text = _BenhNhan.DiaChi;
            txtNgaySinh.Text = _BenhNhan.NamSinh;
            //txtNgaySinh.DateTime = DateTime.ParseExact(_bn.NamSinh,dd/YYYY", CultureInfo.CurrentCulture);
            BindToComboboxGt(_BenhNhan.GioiTinh);
            txtNgheNghiep.Text = _BenhNhan.NgheNghiep;
            txtSoDienthoai.Text = _BenhNhan.SoDT;
        }

        public ThemCapNhapBenhNhan(string id,int mode)
        {
            InitializeComponent();
            _BenhNhan = _bnDao.GetBenhNhanById(id);
            _mode = mode;
            BindToTextBox();
        }

        public ThemCapNhapBenhNhan(BenhNhan bn, int mode)
        {
            InitializeComponent();
            _BenhNhan = bn;
            _mode = mode;
            BindToTextBox();
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (_mode == 1)
            {
                BindToVar();
                var result = _bnDao.UpdateBenhnhan(_BenhNhan);
                if (result)
                {
                    //MessageBox.Show("Cập nhật thành công");
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(DanhSachBenhNhan))
                        {
                            form.WindowState = FormWindowState.Normal;
                            form.Activate();
                            Close();
                            return;
                        }
                    }
                    var f = new DanhSachBenhNhan();
                    f.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại! thử lại");
                }
            }
            else
            {
                BindToVar();
                var result = _bnDao.ThemBenhNhan(_BenhNhan);
                if (result)
                {
                    //MessageBox.Show("Thêm thành công");
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form.GetType() == typeof(DanhSachBenhNhan))
                        {
                            form.WindowState = FormWindowState.Normal;
                            form.Activate();
                            Close();
                            return;
                        }
                    }
                    var f = new DanhSachBenhNhan();
                    f.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! thử lại");
                }
            }
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            var close = MessageBox.Show(@"Bạn có đồng ý tắt form?", @"Thông báo", MessageBoxButtons.YesNo);
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

        private void btnThemHoSo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên không được bỏ trống!");
            }
        }

        private void txtNgaySinh_EditValueChanged(object sender, System.EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                errorProvider1.SetError(txtDiaChi, "Địa chỉ không được bỏ trống!");
            }
        }

        private void txtNgheNghiep_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNgheNghiep.Text))
            {
                errorProvider1.SetError(txtNgheNghiep, "Nghề nghiệp không được bỏ trống");
            }
        }

        private void txtSoDienthoai_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSoDienthoai.Text))
            {
                errorProvider1.SetError(txtSoDienthoai, "Số điện thoại không được bỏ trống!");
            }
        }
    }
}