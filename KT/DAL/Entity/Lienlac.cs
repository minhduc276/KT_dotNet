using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.DAL.Entity
{ 
    public class Lienlac
    {
        public string malienhe { get; set; }
        public string tenlienhe { get; set; }
        public string emaillienhe { get; set; }
        public string sdtlienhe { get; set; }
        public string maNhom { get; set; }

        public static List<Lienlac> getListFromFile(string pathLienLac)
        {
            var array = File.ReadLines(pathLienLac);
            List<Lienlac> hienthi = new List<Lienlac>();
            foreach (string line in array)
            {
                var lsvalue = line.Split('#');
                var Lienlac = new Lienlac
                {
                    malienhe = lsvalue[0],
                    tenlienhe = lsvalue[1],
                    emaillienhe = lsvalue[2],
                    sdtlienhe = lsvalue[3],
                    maNhom = lsvalue[4]
                };
                hienthi.Add(Lienlac);
            }
            return hienthi;
        }

        public static List<Lienlac> getLienLacTuMaNhom(string maNhom, string path)
        {
            List<Lienlac> lstLienLac = getListFromFile(path);
            List<Lienlac> lstLienLacNhom = new List<Lienlac>();

            foreach (Lienlac lienLac in lstLienLac)
            {
                if (lienLac.maNhom.Equals(maNhom))
                {
                    lstLienLacNhom.Add(lienLac);
                }
            }

            return lstLienLacNhom;
        }

        public static string getMaTuTenLienLac(string tenLienLac, string path)
        {
            List<Lienlac> lslienlac = getListFromFile(path);

            foreach (Lienlac LienLac in lslienlac)
            {
                if (LienLac.tenlienhe == tenLienLac)
                {
                    return LienLac.malienhe;
                }
            }
            return null;
        }

        public static void Remove(string pathLienLac, string maLienLac)
        {
            string[] lines = File.ReadAllLines(pathLienLac);

            // Xóa hết
            File.WriteAllText(pathLienLac, "");

            // Ghi lại nếu không trùng mã 
            using (StreamWriter writer = new StreamWriter(pathLienLac))
            {
                foreach (string line in lines)
                {
                    var lsValue = line.Split('#');
                    string MaLienLac = lsValue[0];
                    if (!MaLienLac.Contains(maLienLac))
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
