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
    public class D_Khoa
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllKhoa", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertKhoa(tblKhoa k)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertKhoa", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 50);



            command.Parameters["@MaKhoa"].Value = k.MaKhoa1;
            command.Parameters["@TenKhoa"].Value = k.TenKhoa1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateKhoa(tblKhoa k)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateKhoa", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@TenKhoa", SqlDbType.NVarChar, 50);


            command.Parameters["@MaKhoa"].Value = k.MaKhoa1;
            command.Parameters["@TenKhoa"].Value = k.TenKhoa1;



            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteKhoa(string makhoa)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteKhoa", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 50);
            command.Parameters["@MaKhoa"].Value = makhoa;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchKhoa(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchKhoa", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@searchTerm", SqlDbType.NVarChar, 50).Value = searchText;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
