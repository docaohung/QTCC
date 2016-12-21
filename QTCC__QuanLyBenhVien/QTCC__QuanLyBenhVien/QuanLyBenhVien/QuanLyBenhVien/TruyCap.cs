using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBenhVien
{
    public partial class TruyCap : Form
    {
        public TruyCap()
        {
            InitializeComponent();
        }

        private void abtnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "admin" && txtPassword.Text == "admin")
            {
                this.Hide();
                BenhVien b = new BenhVien();
                b.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Sai Tài Khoản Hoặc Mật Khẩu");
            }

        }
    }
}
