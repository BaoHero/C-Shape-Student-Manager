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
    public class B_Khoa
    {
        public static DataTable GetAllKhoa()
        {
            return D_Khoa.getData();
        }
        public static void InsertKhoa(tblKhoa k)
        {
            D_Khoa.InsertKhoa(k);
        }
        public static void UpdateKhoa(tblKhoa k)
        {
            D_Khoa.UpdateKhoa(k);
        }
        public static void DeleteKhoa(string makhoa)
        {
            D_Khoa.DeleteKhoa(makhoa);
        }
        public static DataTable SearchKhoa(string searchText)
        {
            return D_Khoa.SearchKhoa(searchText);
        }
    }
}
