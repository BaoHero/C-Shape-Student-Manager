using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblThoiKhoaBieu
    {
        private string MaThoiKhoaBieu;
        private string MaSinhVien;

        public tblThoiKhoaBieu(string maThoiKhoaBieu, string maSinhVien)
        {
            MaThoiKhoaBieu1 = maThoiKhoaBieu;
            MaSinhVien1 = maSinhVien;
        }

        public string MaThoiKhoaBieu1 { get => MaThoiKhoaBieu; set => MaThoiKhoaBieu = value; }
        public string MaSinhVien1 { get => MaSinhVien; set => MaSinhVien = value; }
    }
}
