using System;

namespace DTO
{
    public class tblHocSinh
    {
        private String MaSinhVien;
        private String TenSinhVien;
        private DateTime NgaySinh;
        private String GioiTinh;
        private String DiaChi;
        private String MaLop;
        public tblHocSinh(string maSinhVien, string tenSinhVien, DateTime ngaySinh, string gioiTinh, string diaChi, string maLop)
        {
            MaSinhVien = maSinhVien;
            TenSinhVien = tenSinhVien;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            MaLop = maLop;

        }

        public string MaSinhVien1 { get => MaSinhVien; set => MaSinhVien = value; }
        public string TenSinhVien1 { get => TenSinhVien; set => TenSinhVien = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public string MaLop1 { get => MaLop; set => MaLop = value; }

    }
}