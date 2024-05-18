using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class B_LichThi
    {
        public static DataTable GetAllLichThi()
        {
            return D_LichThi.getData();
        }
        public static void InsertLichThi(tblLichThi lt)
        {
            D_LichThi.InsertLT(lt);
        }
        public static void UpdateLichThi(tblLichThi lt)
        {
            D_LichThi.UpdateLT(lt);
        }
        public static void DeleteLichThi(string malichthi)
        {
            D_LichThi.DeleteLT(malichthi);
        }
        public static DataTable SearchLichThi(string searchText)
        {
            return D_LichThi.SearchLichThi(searchText);
        }
    }
}
