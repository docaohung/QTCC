using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Base;
using QTCC_QuanLyBenhVien.Model.DAO;
using QTCC_QuanLyBenhVien.Model.DTO;

namespace QTCC_QuanLyBenhVien
{
    public partial class HoSoKhamBenh : RibbonForm
    {
        private readonly BenhNhan _bn;
        private readonly LichSuKhamBenhDAO _lsDao = new LichSuKhamBenhDAO();
        private readonly QLBenhVienDBContext _dbContext = new QLBenhVienDBContext();
        private BindingList<LichSuKhamBenh> _blist;
        private BindingSource _bsource;
        private string _id;
        //private List<LichSuKhamBenh> _lsKham = new List<LichSuKhamBenh>();

        public HoSoKhamBenh(BenhNhan bn)
        {
            InitializeComponent();
            _bn = bn;
            RefreshGridControl();
        }

        public void RefreshGridControl()
        {
            _blist = new BindingList<LichSuKhamBenh>(_lsDao.GetByMaYte(_bn.MaYTe));
            _bsource = new BindingSource(_blist, null);
            gridControl.DataSource = _bsource;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof (ThemCapNhatBenhAn))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }
            var themba = new ThemCapNhatBenhAn(_bn.MaYTe);
            themba.Show();
        }

        private void gridView_RowUpdated(object sender, RowObjectEventArgs e)
        {
            _dbContext.SaveChanges();
        }

        private void gridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            try
            {
                _id = gridView.GetRowCellValue(e.FocusedRowHandle, "ID").ToString();
            }
            catch (Exception)
            {
                _id = null;
                throw;
            }
        }

        private void btnCapNhat_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof (ThemCapNhatBenhAn))
                {
                    form.WindowState = FormWindowState.Normal;
                    form.Activate();
                    return;
                }
            }
            var ls = _lsDao.GetBenhAnById(int.Parse(_id));
            var themba = new ThemCapNhatBenhAn(ls, 1);
            themba.Show();
        }

        private void btnXoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ls = _lsDao.GetBenhAnById(int.Parse(_id));
            var dialogResult = MessageBox.Show(@"Bạn có chắc chắn xóa dòng này?", @"Xác nhận",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                var result = _lsDao.XoaBenhAn(ls);
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
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void HoSoKhamBenh_Activated(object sender, EventArgs e)
        {
            RefreshGridControl();
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            var close = MessageBox.Show(@"Bạn có đồng tắt form này?", @"Thông báo", MessageBoxButtons.YesNo);
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
    }
}