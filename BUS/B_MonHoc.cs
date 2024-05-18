using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class B_MonHoc
    {
        public static DataTable GetAllMonHoc()
        {
            return D_MonHoc.getData();
        }
        public static void InsertMonHoc(tblMonHoc mh)
        {
            D_MonHoc.InsertMH(mh);
        }
        public static void UpdateMonHoc(tblMonHoc mh)
        {
            D_MonHoc.UpdateMH(mh);
        }
        public static void DeleteMonHoc(string mamonhoc)
        {
            D_MonHoc.DeleteMH(mamonhoc);
        }
        public static DataTable SearchMonHoc(string searchText)
        {
            return D_MonHoc.SearchMonHoc(searchText);
        }
        public static DataTable ThongKeMonHoc()
        {
            return D_MonHoc.ThongKeMonHoc();
        }
    }
}
