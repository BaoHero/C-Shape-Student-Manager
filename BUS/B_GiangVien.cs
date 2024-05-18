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
    public class B_GiangVien
    {
        public static DataTable GetAllGiangVien()
        {
            return D_GiangVien.getData();
        }
        public static void InsertGV(tblGiangVien k)
        {
            D_GiangVien.InsertGV(k);
        }
        public static void UpdateGV(tblGiangVien k)
        {
            D_GiangVien.UpdateGV(k);
        }
        public static void DeleteGiangVien(string magiangvien)
        {
            D_GiangVien.DeleteGiangVien(magiangvien);
        }
        public static DataTable SearchGiangVien(string searchText)
        {
            return D_GiangVien.SearchGiangVien(searchText);
        }
    }
}
