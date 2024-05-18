using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLop
    {
        private string MaLop;
        private string TenLop;
        private string MaKhoa;

        public tblLop(string maLop, string tenLop, string maKhoa)
        {
            MaLop1 = maLop;
            TenLop1 = tenLop;
            MaKhoa1 = maKhoa;
        }

        public string MaLop1 { get => MaLop; set => MaLop = value; }
        public string TenLop1 { get => TenLop; set => TenLop = value; }
        public string MaKhoa1 { get => MaKhoa; set => MaKhoa = value; }
    }
}
