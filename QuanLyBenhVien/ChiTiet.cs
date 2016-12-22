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
    public partial class Form1_Load : Form
    {
        public Form1_Load()
        {
            InitializeComponent();
        }

        private void ChiTiet_Load(object sender, EventArgs e)
        {
            gridViewChiTiet.DataSource = new BenhVienBLO().LoadAllData();
        }
    }
}
