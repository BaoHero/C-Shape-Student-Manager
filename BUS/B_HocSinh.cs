using System;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class B_HocSinh
    {
        public static DataTable GetAllHocSinh()
        {
            return D_HocSinh.getData();
        }
        public static void InsertHocSinh(tblHocSinh hs)
        {
            D_HocSinh.InsertHS(hs);
        }
        public static void UpdateHocSinh(tblHocSinh hs)
        {
            D_HocSinh.UpdateHS(hs);
        }
        public static void DeleteHocSinh(string masv)
        {
            D_HocSinh.DeleteHS(masv);
        }
        public static DataTable SearchSinhVien(string searchText)
        {
            return D_HocSinh.SearchSV(searchText);
        }
        public static DataTable ThongKeSinhVienTheoLop(string maLop)
        {
            return D_HocSinh.ThongKeSinhVienTheoLop(maLop);
        }
    }
}