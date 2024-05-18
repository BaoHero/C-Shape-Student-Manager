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
    public class B_ThoiKhoaBieu
    {
        public static DataTable GetAllThoiKhoaBieu()
        {
            return D_ThoiKhoaBieu.getData();
        }
        public static void InsertThoiKhoaBieu(tblThoiKhoaBieu tkb)
        {
            D_ThoiKhoaBieu.InsertThoiKhoaBieu(tkb);
        }
        public static void UpdateThoiKhoaBieu(tblThoiKhoaBieu tkb)
        {
            D_ThoiKhoaBieu.UpdateThoiKhoaBieu(tkb);
        }
        public static void DeleteThoiKhoaBieu(string mathoikhoabieu)
        {
            D_ThoiKhoaBieu.DeleteThoiKhoaBieu(mathoikhoabieu);
        }
    }
}
