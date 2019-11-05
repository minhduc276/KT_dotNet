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
    public partial class frmThemNhom : Form
    {
        Nhom Nhom;
        public frmThemNhom()
        {
            InitializeComponent();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (Nhom != null)
            {
                MessageBox.Show("viet cap nhat tai day");
            }
            else
            {
                string pathNhom = @"C:\Users\Administrator\source\repos\KT\KT\DATA\nhom.txt";
                using (StreamWriter sw = File.AppendText(pathNhom))
                {
                    string text = textThemMaNhom.Text.ToString() + "#" + txtThemTenNhom.Text.ToString();
                    sw.Write("\n" + text);
                }
                MessageBox.Show("Dã cập nhật thành công");
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
