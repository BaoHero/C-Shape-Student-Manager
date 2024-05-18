using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLichThi
    {
        private String MaLichThi;
        private String MaMonHoc;
        private DateTime NgayThi;
        private String GioThi;
        private String PhongThi;

        public tblLichThi(string maLichThi, string maMonHoc, DateTime ngayThi, string gioThi, string phongThi)
        {
            MaLichThi = maLichThi;
            MaMonHoc = maMonHoc;
            NgayThi = ngayThi;
            GioThi = gioThi;
            PhongThi = phongThi;
        }

        public string MaLichThi1 { get => MaLichThi; set => MaLichThi = value; }
        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public DateTime NgayThi1 { get => NgayThi; set => NgayThi = value; }
        public string GioThi1 { get => GioThi; set => GioThi = value; }
        public string PhongThi1 { get => PhongThi; set => PhongThi = value; }
    }
}
