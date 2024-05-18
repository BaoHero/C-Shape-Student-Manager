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
    public class B_Diem
    {
        public static DataTable GetAllDiem()
        {
            return D_Diem.getData();
        }
        public static void InsertDiem(tblDiem d)
        {
            D_Diem.InsertDiem(d);
        }
        public static void UpdateDiem(tblDiem d)
        {
            D_Diem.UpdateDiem(d);
        }
        public static void DeleteDiem(string madiemso)
        {
            D_Diem.DeleteDiem(madiemso);
        }
        public static DataTable SearchDiem(string searchText)
        {
            return D_Diem.SearchDiem(searchText);
        }


    }
}
