using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblBienLai
    {
        private String MaBienLai;
        private String MaSinhVien;
        private DateTime NgayThanhToan;

        public tblBienLai(string maBienLai, string maSinhVien, DateTime ngayThanhToan)
        {
            MaBienLai = maBienLai;
            MaSinhVien = maSinhVien;
            NgayThanhToan = ngayThanhToan;
        }

        public string MaBienLai1 { get => MaBienLai; set => MaBienLai = value; }
        public string MaSinhVien1 { get => MaSinhVien; set => MaSinhVien = value; }
        public DateTime NgayThanhToan1 { get => NgayThanhToan; set => NgayThanhToan = value; }
    }
}
