using KT.DAL.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT
{
    public partial class frmThemLienLac : Form
    {
        Lienlac lienlac; 
        public frmThemLienLac()
        {
            InitializeComponent();
            List<Nhom> ds = Nhom.getNhomFromFile(@"C:\Users\Administrator\source\repos\KT\KT\DATA\nhom.txt");
            foreach (Nhom ls in ds)
            {
                cbxMaNhom.Items.Add(ls.MaNhom);
            }
        }

        private void btnThemMoiLienLac_Click(object sender, EventArgs e)
        {
            if (lienlac != null)
            {
                MessageBox.Show("viet cap nhat tai day");
            }
            else
            {
                string pathNhom = @"C:\Users\Administrator\source\repos\KT\KT\DATA\lienlac.txt";
                using (StreamWriter sw = File.AppendText(pathNhom))
                {
                    //string text = txtMaLienLac.Text+"#" + txtTenLienLac.Text.ToString()+"#" +txtEmail.Text.ToString+"#"+txtSdt.Text.ToString+"#"+this.cbbMaNhom.GetItemText(this.cbbMaNhom.SelectedItem);
                    string text = txtMaLienLac.Text + "#" + txtTenGoi.Text + "#" + txtEmail.Text + "#" + txtSoDienThoai.Text + "#" + this.cbxMaNhom.GetItemText(this.cbxMaNhom.SelectedItem);
                    sw.Write("\n" + text);
                }
                MessageBox.Show("Dã cập nhật thành công");
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
