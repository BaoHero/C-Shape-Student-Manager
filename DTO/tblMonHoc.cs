using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblMonHoc
    {
        private String MaMonHoc;
        private String TenMonHoc;
        private int SoTinChi;
        private String MaGiangVien;

        public tblMonHoc(string maMonHoc, string tenMonHoc, int soTinChi, string maGiangVien)
        {
            MaMonHoc = maMonHoc;
            TenMonHoc = tenMonHoc;
            SoTinChi = soTinChi;
            MaGiangVien = maGiangVien;
        }

        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        public string TenMonHoc1 { get => TenMonHoc; set => TenMonHoc = value; }
        public int SoTinChi1 { get => SoTinChi; set => SoTinChi = value; }
        public string MaGiangVien1 { get => MaGiangVien; set => MaGiangVien = value; }
    }
}
