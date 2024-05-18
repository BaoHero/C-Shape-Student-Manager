using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblChiTietTKB
    {
        private string MaThoiKhoaBieu;
        private string MaMonHoc;
        private string Thu;
        private int TietBatDau;
        private string PhongHoc;

        public tblChiTietTKB(string maThoiKhoaBieu, string maMonHoc, string thu, int tietBatDau, string phongHoc)
        {
            MaThoiKhoaBieu = maThoiKhoaBieu;
            MaMonHoc = maMonHoc;
            Thu = thu;
            TietBatDau = tietBatDau;
            PhongHoc = phongHoc;
        }

        public string MaThoiKhoaBieu1 { get => MaThoiKhoaBieu; set => MaThoiKhoaBieu = value; }
        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public string Thu1 { get => Thu; set => Thu = value; }
        public int TietBatDau1 { get => TietBatDau; set => TietBatDau = value; }
        public string PhongHoc1 { get => PhongHoc; set => PhongHoc = value; }
    }
}
