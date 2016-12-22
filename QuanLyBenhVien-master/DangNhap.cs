using System;
using System.Windows.Forms;
using QTCC_QuanLyBenhVien.Model.DAO;

namespace QTCC_QuanLyBenhVien
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly UserDAO _userDao;
        public LoginForm()
        {
            InitializeComponent();
            _userDao = new UserDAO();
            txtPwd.Properties.UseSystemPasswordChar = true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                dxErrorProviderDangnhap.SetError(txtUsername, "Vui lòng nhập username");
            }
        }

        private void txtPwd_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPwd.Text))
            {
                dxErrorProviderDangnhap.SetError(txtPwd, "Vui lòng nhập password");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var result = _userDao.Login(txtUsername.Text, txtPwd.Text);
            if (result == 1)
            {
                var formql = new DanhSachBenhNhan();
                formql.Show();
                if (!cbRemember.Checked)
                {
                    txtUsername.Text = null;
                    txtPwd.Text = null;
                }
                Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}