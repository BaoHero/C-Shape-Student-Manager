using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblGiangVien
    {
        private string MaGiangVien;
        private string TenGiangVien;
        private string Email;
        private string MaKhoa;

        public tblGiangVien(string maGiangVien, string tenGiangVien, string email, string maKhoa)
        {
            MaGiangVien1 = maGiangVien;
            TenGiangVien1 = tenGiangVien;
            Email1 = email;
            MaKhoa1 = maKhoa;
        }

        public string MaGiangVien1 { get => MaGiangVien; set => MaGiangVien = value; }
        public string TenGiangVien1 { get => TenGiangVien; set => TenGiangVien = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
    }
}
