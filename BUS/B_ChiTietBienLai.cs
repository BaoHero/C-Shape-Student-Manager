using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class B_ChiTietBienLai
    {
        public static DataTable GetAllHocPhi()
        {
            return D_ChiTietBienLai.getData();
        }
        public static void InsertHocPhi(tblChiTietBienLai hp)
        {
            D_ChiTietBienLai.InsertHP(hp);
        }
        public static void UpdateHocPhi(tblChiTietBienLai hp)
        {
            D_ChiTietBienLai.UpdateHP(hp);
        }
        public static void DeleteHocPhi(string mabienlai, string mamonhoc)
        {
            D_ChiTietBienLai.DeleteHP(mabienlai, mamonhoc);
        }
        public static DataTable SearchHP(string searchText)
        {
            return D_ChiTietBienLai.SearchHP(searchText);
        }
        public static void ExportHPToCsv(string filePath)
        {
            D_ChiTietBienLai.ExportHPToCsv(filePath);
        }

    }
}
