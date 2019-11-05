using KT.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\Administrator\source\repos\KT\KT\DATA\nhom.txt";
        string pathLienLac = @"C:\Users\Administrator\source\repos\KT\KT\DATA\lienlac.txt";
        public Form1()
        {
            InitializeComponent();
            dtgvNhom.AutoGenerateColumns = false;
            dtgvNhom.DataSource = DAL.Entity.Nhom.getNhomFromFile(path);
            
            dtgvLienLac.AutoGenerateColumns = false;
            dtgvLienLac.DataSource = DAL.Entity.Lienlac.getListFromFile(pathLienLac);
        }


        private void dtgvNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvNhom.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgvNhom.CurrentRow.Selected = true;
                string tenNhom = dtgvNhom.Rows[e.RowIndex].Cells["TenNhom"].FormattedValue.ToString();
                string maNhom = Nhom.getMaTuTenNhom(tenNhom, path);

                List<Lienlac> lstLienLac = Lienlac.getLienLacTuMaNhom(maNhom, pathLienLac);
                dtgvLienLac.AutoGenerateColumns = false;
                dtgvLienLac.DataSource = lstLienLac;

            }
        }

        private void dtgvLienLac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvLienLac.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgvLienLac.CurrentRow.Selected = true;
                lblTenGoi.Text = dtgvLienLac.Rows[e.RowIndex].Cells["TenGoi"].FormattedValue.ToString();
                lblEmail.Text = dtgvLienLac.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                lblSoDienThoai.Text = dtgvLienLac.Rows[e.RowIndex].Cells["SoDienThoai"].FormattedValue.ToString();
            }
            
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            var f = new frmThemNhom();
            f.ShowDialog();
        }

        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Ban chac chan muon xoa nhom nay?",
               "Thong bao",

               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                bool flag = dtgvNhom.CurrentRow.Selected;
                if (flag)
                {
                    string tenNhom = dtgvNhom.SelectedCells[0].Value.ToString();
                    string maNhom = Nhom.getMaTuTenNhom(tenNhom, path);
                    Nhom.xoaNhom(path, maNhom);
                }

                MessageBox.Show(" Xoa thanh cong!",
                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Refresh
            List<Nhom> lstNhom = Nhom.getNhomFromFile(path);
            dtgvNhom.AutoGenerateColumns = false;
            dtgvNhom.DataSource = lstNhom;
            dtgvNhom.Refresh();
        }

        private void btnThemLienLac_Click(object sender, EventArgs e)
        {
            var f = new frmThemLienLac();
            f.ShowDialog();
        }

        private void btnXoaLienLac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
               "Ban co that su muon xoa khong?",
               "Thong bao",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                bool flag = dtgvLienLac.CurrentRow.Selected;
                if (flag)
                {
                    string tenLienLac = dtgvLienLac.SelectedCells[0].Value.ToString();
                    string maLienLac = Lienlac.getMaTuTenLienLac(tenLienLac, pathLienLac);
                    Lienlac.Remove(pathLienLac, maLienLac);
                }

                MessageBox.Show("Da xoa thanh cong!",
                 "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Refresh
            List<Lienlac> lslienlac = Lienlac.getListFromFile(pathLienLac);
            dtgvLienLac.AutoGenerateColumns = false;
            dtgvLienLac.DataSource = lslienlac;
            dtgvLienLac.Refresh();
        }
    }
}
