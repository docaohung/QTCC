namespace QTCC_QuanLyBenhVien
{
    partial class HoSoKhamBenh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoSoKhamBenh));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.lichSuKhamBenhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaYTe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuanDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenThuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoiDan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTaiKham = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBenhNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnCapNhat = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuKhamBenhsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.lichSuKhamBenhsBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 143);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(790, 456);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // lichSuKhamBenhsBindingSource
            // 
            this.lichSuKhamBenhsBindingSource.DataSource = typeof(QTCC_QuanLyBenhVien.Model.DTO.LichSuKhamBenh);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMaYTe,
            this.colChuanDoan,
            this.colTenThuoc,
            this.colLoiDan,
            this.colNgayTaiKham,
            this.colBenhNhan});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            this.gridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView_RowUpdated);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colMaYTe
            // 
            this.colMaYTe.FieldName = "MaYTe";
            this.colMaYTe.Name = "colMaYTe";
            this.colMaYTe.OptionsColumn.ReadOnly = true;
            // 
            // colChuanDoan
            // 
            this.colChuanDoan.FieldName = "ChuanDoan";
            this.colChuanDoan.Name = "colChuanDoan";
            this.colChuanDoan.Visible = true;
            this.colChuanDoan.VisibleIndex = 0;
            // 
            // colTenThuoc
            // 
            this.colTenThuoc.FieldName = "TenThuoc";
            this.colTenThuoc.Name = "colTenThuoc";
            this.colTenThuoc.Visible = true;
            this.colTenThuoc.VisibleIndex = 1;
            // 
            // colLoiDan
            // 
            this.colLoiDan.FieldName = "LoiDan";
            this.colLoiDan.Name = "colLoiDan";
            this.colLoiDan.Visible = true;
            this.colLoiDan.VisibleIndex = 2;
            // 
            // colNgayTaiKham
            // 
            this.colNgayTaiKham.FieldName = "NgayTaiKham";
            this.colNgayTaiKham.Name = "colNgayTaiKham";
            this.colNgayTaiKham.Visible = true;
            this.colNgayTaiKham.VisibleIndex = 3;
            // 
            // colBenhNhan
            // 
            this.colBenhNhan.FieldName = "BenhNhan";
            this.colBenhNhan.Name = "colBenhNhan";
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bsiRecordsCount,
            this.btnThem,
            this.btnCapNhat,
            this.btnXoa,
            this.btnClose});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 21;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 143);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            this.bsiRecordsCount.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 16;
            this.btnThem.ImageOptions.ImageUri.Uri = "New";
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Caption = "Cập nhật";
            this.btnCapNhat.Id = 17;
            this.btnCapNhat.ImageOptions.ImageUri.Uri = "Edit";
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCapNhat_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 18;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.ImageUri.Uri = "Delete";
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Thoát";
            this.btnClose.Id = 20;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.LargeImage")));
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCapNhat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnXoa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Hồ sơ bệnh án";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Thoát";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 31);
            // 
            // HoSoKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "HoSoKhamBenh";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Hồ sơ khám bệnh";
            this.Activated += new System.EventHandler(this.HoSoKhamBenh_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lichSuKhamBenhsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnCapNhat;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private System.Windows.Forms.BindingSource lichSuKhamBenhsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMaYTe;
        private DevExpress.XtraGrid.Columns.GridColumn colChuanDoan;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuoc;
        private DevExpress.XtraGrid.Columns.GridColumn colLoiDan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTaiKham;
        private DevExpress.XtraGrid.Columns.GridColumn colBenhNhan;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}