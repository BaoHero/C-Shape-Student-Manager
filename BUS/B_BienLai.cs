using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class B_BienLai
    {
        public static DataTable GetAllBienLai()
        {
            return D_BienLai.getData();
        }
        public static void InsertBienLai(tblBienLai bl)
        {
            D_BienLai.InsertBL(bl);
        }
        public static void UpdateBienLai(tblBienLai bl)
        {
            D_BienLai.UpdateBL(bl);
        }
        public static void DeleteBienLai(string mabienlai)
        {
            D_BienLai.DeleteBL(mabienlai);
        }
        public static DataTable SearchBienLai(string searchText)
        {
            return D_BienLai.SearchBienLai(searchText);
        }
        public static DataTable ThongKeBL(string loaiThongKe)
        {
            return D_BienLai.ThongKeBL(loaiThongKe);
        }
    }
}
