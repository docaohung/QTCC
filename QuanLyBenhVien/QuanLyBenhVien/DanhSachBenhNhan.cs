using System;
using System.ComponentModel;
using System.Windows.Forms;
using QTCC_QuanLyBenhVien.Model.DAO;
using QTCC_QuanLyBenhVien.Model.DTO;

namespace QTCC_QuanLyBenhVien
{
    public partial class DanhSachBenhNhan : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private string _id;
        private readonly BenhNhanDAO _bnDao = new BenhNhanDAO();
        private readonly QLBenhVienDBContext _dbContext = new QLBenhVienDBContext();
        private readonly LichSuKhamBenhDAO _lsDao = new LichSuKhamBenhDAO();
        public DanhSachBenhNhan()
        {
            InitializeComponent();
            RefreshGridControl();
            //_dbContext.BenhNhans.Load();
            //benhNhansBindingSource.DataSource = _dbContext.BenhNhans.Local.ToBindingList();
        }
        
        //Refresh lại GridControl
        public void RefreshGridControl()
        {
            int currentRow = gridView1.FocusedRowHandle;
            var blist = new BindingList<BenhNhan>(_bnDao.GetAllBenhnhan());
            var bsource = new BindingSource(blist, null);
            gridControl1.DataSource = bsource;
            gridView1.FocusedRowHandle = currentRow;
            //gridControl1.RefreshDataSource();
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            _dbContext.SaveChanges();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThemCapNhapBenhNhan))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }
            ThemCapNhapBenhNhan thembn = new ThemCapNhapBenhNhan();
            thembn.Show();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                _id = gridView1.GetRowCellValue(e.FocusedRowHandle, "MaYTe").ToString();
            }
            catch (Exception)
            {
                _id = null;
            }
        }

        private void btnCapnhat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(ThemCapNhapBenhNhan))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }
            var bn = _bnDao.GetBenhNhanById(_id);
            if (bn != null)
            {
                ThemCapNhapBenhNhan thembn = new ThemCapNhapBenhNhan(bn,1);
                thembn.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 bệnh nhân để cập nhật");
            }
        }

        private void btnDanhSachHoSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_lsDao.CountBenhAn(_id) > 0)
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof (HoSoKhamBenh))
                    {
                        form.WindowState = FormWindowState.Normal;
                        form.Activate();
                        return;
                    }
                }
                BenhNhan bn = _bnDao.GetBenhNhanById(_id);
                HoSoKhamBenh hoso = new HoSoKhamBenh(bn);
                hoso.Text = @"Bệnh nhân-" + bn.MaYTe + @"-" + bn.HoTen;
                hoso.Show();
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(ThemCapNhatBenhAn))
                    {
                        form.WindowState = FormWindowState.Normal;
                        form.Activate();
                        return;
                    }
                }
                ThemCapNhatBenhAn themba = new ThemCapNhatBenhAn(_id);
                themba.Show();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialogResult = MessageBox.Show(@"Bạn có chắc chắn xóa dòng này?", @"Xác nhận",
                    MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do somethingif (_lsDao.CountBenhAn(_id) > 0)
                {
                    var dialogResult2 = MessageBox.Show(@"Bạn có chắc chắn xóa : bệnh án của bệnh nhân và thông tin bệnh nhân?", @"Xác nhận",
                    MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.Yes)
                    {
                        var result = _bnDao.DeleteBenhNhan(_id);
                        if (result)
                        {
                            MessageBox.Show(@"Xóa thành công!");
                            RefreshGridControl();
                        }
                        else
                        {
                            MessageBox.Show(@"Xóa không thành công!");
                        }
                    }
                }
                
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void DanhSachBenhNhan_Activated(object sender, EventArgs e)
        {
            RefreshGridControl();
        }

        private void DanhSachBenhNhan_FormClosing(object sender, FormClosingEventArgs e)
        {
            var close = MessageBox.Show(@"Bạn có đồng ý thoát chương trình?", @"Thông báo", MessageBoxButtons.YesNo);
            if (close != DialogResult.Yes)
            {
                //MessageBox.Show(@"The application has been closed successfully.", @"Application Closed!", MessageBoxButtons.OK);
                e.Cancel = true;
                Activate();
            }
            else
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.GetType() == typeof(LoginForm))
                    {
                        form.WindowState = FormWindowState.Normal;
                        //form.Activate();
                        form.Close();
                        return;
                    }
                }
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        
        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshGridControl();
        }

        private void gridView1_RowCountChanged(object sender, EventArgs e)
        {
            RefreshGridControl();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
