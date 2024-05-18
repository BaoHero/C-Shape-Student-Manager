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
    public class B_ChiTietTKB
    {

        public static DataTable GetAllChiTietTKB()
        {
            return D_ChiTietTKB.getData();
        }
        public static void InsertChiTietTKB(tblChiTietTKB cttkb)
        {
            D_ChiTietTKB.InsertChiTietTKB(cttkb);
        }
        public static void UpdateChiTietTKB(tblChiTietTKB cttkb)
        {
            D_ChiTietTKB.UpdateChiTietTKB(cttkb);
        }
        public static void DeleteChiTietTKB(string macttkb)
        {
            D_ChiTietTKB.DeleteChiTietTKB(macttkb);
        }

    }
}
