using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.DAL.Entity
{
    class Nhom
    {
        private string maNhom;
        private string tenNhom;

        public string MaNhom { get => maNhom; set => maNhom = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }

        public static List<Nhom> getNhomFromFile(string path)
        {
            var arraylist = File.ReadLines(path);
            List<Nhom> hienthi = new List<Nhom>();
            foreach (string line in arraylist)
            {
                var lsvalue = line.Split(new char[] { '#' });
                var Nhom = new Nhom
                {
                    maNhom = lsvalue[0],
                    tenNhom = lsvalue[1]
                };
                hienthi.Add(Nhom);
            }
            return hienthi;

        }

        public static string getMaTuTenNhom(string tenNhom, string path)
        {
            List<Nhom> lstNhom = getNhomFromFile(path);

            foreach (Nhom nhom in lstNhom)
            {
                if (nhom.tenNhom == tenNhom)
                {
                    return nhom.maNhom;
                }
            }
            return null;
        }

        public static void xoaNhom(string path, string maNhom)
        {
            string[] lines = File.ReadAllLines(path);

            // Xóa hết
            File.WriteAllText(path, "");

            // Ghi lại nếu không trùng mã 
            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (string line in lines)
                {
                    var lsValue = line.Split('#');
                    // Lấy mã 
                    string ma = lsValue[0];
                    if (!ma.Contains(maNhom))
                    {
                        writer.WriteLine(line);
                    }
                }
                writer.Flush();
                writer.Close();
            }
        }
    }
}
