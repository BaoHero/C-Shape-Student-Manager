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
    public class B_Lop
    {
        public static DataTable GetAllLop()
        {
            return D_Lop.getData();
        }
        public static void InsertLop(tblLop lop)
        {
            D_Lop.InsertLop(lop);
        }
        public static void UpdateLop(tblLop lop)
        {
            D_Lop.UpdateLop(lop);
        }
        public static void DeleteLop(string malop)
        {
            D_Lop.DeleteLop(malop);
        }
        public static DataTable SearchLop(string searchText)
        {
            return D_Lop.SearchLop(searchText);
        }
    }
}
