using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblDiem
    {
        private string MaDiemSo;
        private string MaSinhVien;
        private string MaMonHoc;
        private float Diem;

        public tblDiem(string maDiemSo, string maSinhVien, string maMonHoc, float diem)
        {
            MaDiemSo1 = maDiemSo;
            MaSinhVien1 = maSinhVien;
            MaMonHoc1 = maMonHoc;
            Diem1 = diem;
        }

        public string MaDiemSo1 { get => MaDiemSo; set => MaDiemSo = value; }
        public string MaSinhVien1 { get => MaSinhVien; set => MaSinhVien = value; }
        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public float Diem1 { get => Diem; set => Diem = value; }
    }
}
