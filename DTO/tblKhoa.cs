using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblKhoa
    {
        private string MaKhoa;
        private string TenKhoa;

        public tblKhoa(string maKhoa, string tenKhoa)
        {
            MaKhoa1 = maKhoa;
            TenKhoa1 = tenKhoa;
        }

        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
        public string TenKhoa1 { get => TenKhoa; set => TenKhoa = value; }
    }
}
