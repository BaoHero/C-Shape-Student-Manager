using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblChiTietBienLai
    {
        private String MaBienLai;
        private String MaMonHoc;
        //private int HocPhi;

        public tblChiTietBienLai(string maBienLai, string maMonHoc)
        {
            MaBienLai1 = maBienLai;
            MaMonHoc1 = maMonHoc;
            //HocPhi1 = hocPhi;
        }
        public string MaBienLai1 { get => MaBienLai; set => MaBienLai = value; }
        public string MaMonHoc1 { get => MaMonHoc; set => MaMonHoc = value; }
        //public int HocPhi1 { get => HocPhi; set => HocPhi = value; }
    }
}
