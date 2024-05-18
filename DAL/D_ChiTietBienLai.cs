using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class D_ChiTietBienLai
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllChiTietBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertHP(tblChiTietBienLai hp)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertChiTietBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaBienLai", SqlDbType.NVarChar);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar);
            //command.Parameters.Add("@HocPhi", SqlDbType.Int);
            command.Parameters["@MaBienLai"].Value = hp.MaBienLai1;
            command.Parameters["@MaMonHoc"].Value = hp.MaMonHoc1;
            //command.Parameters["@HocPhi"].Value = hp.HocPhi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateHP(tblChiTietBienLai hp)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateChiTietBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaBienLai", SqlDbType.NVarChar);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar); ;
            //command.Parameters.Add("@HocPhi", SqlDbType.Int);
            command.Parameters["@MaBienLai"].Value = hp.MaBienLai1;
            command.Parameters["@MaMonHoc"].Value = hp.MaMonHoc1;
            //command.Parameters["@HocPhi"].Value = hp.HocPhi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteHP(string mahocphi, string mamonhoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteChiTietBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaBienLai", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar, 100);
            command.Parameters["@MaBienLai"].Value = mahocphi;
            command.Parameters["@MaMonHoc"].Value = mamonhoc;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchHP(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchChiTietBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = searchText;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static void ExportHPToCsv(string filePath)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_ExportHocPhi", Conn);
            command.CommandType = CommandType.StoredProcedure;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
