using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement.EL;
using HospitalManagement.BLL;

namespace HospitalManagement
{
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            gridViewList.DataSource = new HospitalBLO().loadAllData();

        }

        private void abtnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                HospitalDTO hos = new HospitalDTO(int.Parse(txtID.Text), txtName.Text,txtBirth.Text, txtAddress.Text, txtMedicalHistory.Text, txtSecondExamine.Text);

                if (new HospitalBLO().Add(hos))
                    MessageBox.Show(this, "Thanh Cong ");
                else
                    MessageBox.Show(this, "Moi Nhap Du Thong Tin");
                Detail_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Moi Nhap Du Thong Tin");
            }
        }

        private void abtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                HospitalDTO hos = new HospitalDTO(int.Parse(txtID.Text), txtName.Text, txtBirth.Text, txtAddress.Text, txtMedicalHistory.Text, txtSecondExamine.Text);


                if (new HospitalBLO().update(hos))
                    MessageBox.Show(this, "Thanh Cong ");
                else
                    MessageBox.Show(this, "That Bai ");
                Detail_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show(this, "Moi Ban Chon Mot Dong Va Thay Doi Cac Thong Tin Can Sua");
            }
        }

        int dong;
        private void gridViewList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            try
            {
                
                txtID.Text = gridViewList.Rows[dong].Cells[0].Value.ToString();
                txtName.Text = gridViewList.Rows[dong].Cells[1].Value.ToString();
                txtBirth.Text = gridViewList.Rows[dong].Cells[2].Value.ToString();
                txtAddress.Text = gridViewList.Rows[dong].Cells[3].Value.ToString();
                txtMedicalHistory.Text = gridViewList.Rows[dong].Cells[4].Value.ToString();
                txtSecondExamine.Text = gridViewList.Rows[dong].Cells[5].Value.ToString();
                
            }
            catch (Exception)
            {

            }
        }

        private void abtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtSearch.Text;

                List<HospitalDTO> lst = new HospitalBLO().find(name);
                if (lst.Count() != 0)
                {
                    MessageBox.Show(this, "Tim Thay");
                    gridViewList.DataSource = lst;
                }
            }
            catch (Exception)
            {

                if (txtSearch.Text == "")
                    MessageBox.Show(this, "Ban Chua Nhap Gia Tri De Tim Kiem");
                else
                    MessageBox.Show(this, "Tim Khong Thay");
            }  
        }

        private void abtnReload_Click(object sender, EventArgs e)
        {
            Detail_Load(sender, e);
        }

        private void abtnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtBirth.Text = "";
            txtAddress.Text = "";
            txtMedicalHistory.Text = "";
            txtSecondExamine.Text = "";
           
        }

        private void abtnDelete_Click(object sender, EventArgs e)
        {
            //try
            //{

            //    DialogResult dg;
            //    HospitalDTO hos = new HospitalDTO(int.Parse(txtID.Text), txtName.Text, txtBirth.Text, txtAddress.Text, txtMedicalHistory.Text, txtSecondExamine.Text);




            //    dg = MessageBox.Show("Ban Co Muon Xoa", "Xoa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            //    if (dg == DialogResult.Yes)
            //    {
            //        if (new HospitalBLO().DeleteData(hos))
            //            MessageBox.Show(this, "Thanh Cong ");

            //    }
            //    //else
            //    //{
            //    //    MessageBox.Show(this, "That Bai");
            //    //}
            //    Detail_Load(sender, e);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show(this, "Moi Chon Mot Dong De Xoa");
            //}
        }

        private void Detail_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg;
            dg = MessageBox.Show("Are you sure you want to exit?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (dg == DialogResult.Yes)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
