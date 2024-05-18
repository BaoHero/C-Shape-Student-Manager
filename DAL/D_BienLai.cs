using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class D_BienLai
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertBL(tblBienLai bl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaBienLai", SqlDbType.NVarChar);
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar);
            command.Parameters.Add("@NgayThanhToan", SqlDbType.Date);
            command.Parameters["@MaBienLai"].Value = bl.MaBienLai1;
            command.Parameters["@MaSinhVien"].Value = bl.MaSinhVien1;
            command.Parameters["@NgayThanhToan"].Value = bl.NgayThanhToan1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateBL(tblBienLai bl)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaBienLai", SqlDbType.NVarChar);
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar);
            command.Parameters.Add("@NgayThanhToan", SqlDbType.Date);
            command.Parameters["@MaBienLai"].Value = bl.MaBienLai1;
            command.Parameters["@MaSinhVien"].Value = bl.MaSinhVien1;
            command.Parameters["@NgayThanhToan"].Value = bl.NgayThanhToan1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteBL(string mabienlai)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaBienLai", SqlDbType.NVarChar);
            command.Parameters["@MaBienLai"].Value = mabienlai;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchBienLai(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = searchText;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable ThongKeBL(string loaiThongKe)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_ThongKeBienLai", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@LoaiThongKe", SqlDbType.NVarChar, 50).Value = loaiThongKe;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
