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
    public class D_GiangVien
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllGiangVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertGV(tblGiangVien k)
        {
            using (SqlConnection Conn = dbConnectionData.HamKetNoi())
            {
                using (SqlCommand command = new SqlCommand("sp_InsertGiangVien", Conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MaGiangVien", SqlDbType.NVarChar, 50).Value = k.MaGiangVien1;
                    command.Parameters.Add("@TenGiangVien", SqlDbType.NVarChar, 50).Value = k.TenGiangVien1;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = k.Email1;
                    command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 50).Value = k.MaKhoa1;

                    Conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateGV(tblGiangVien k)
        {
            using (SqlConnection Conn = dbConnectionData.HamKetNoi())
            {
                using (SqlCommand command = new SqlCommand("sp_UpdateGiangVien", Conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@MaGiangVien", SqlDbType.NVarChar, 50).Value = k.MaGiangVien1;
                    command.Parameters.Add("@TenGiangVien", SqlDbType.NVarChar, 50).Value = k.TenGiangVien1;
                    command.Parameters.Add("@Email", SqlDbType.NVarChar, 50).Value = k.Email1;
                    command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 50).Value = k.MaKhoa1;

                    Conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void DeleteGiangVien(string magiangvien)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteGiangVien", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaGiangVien", SqlDbType.NVarChar, 50);
            command.Parameters["@MaGiangVien"].Value = magiangvien;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchGiangVien(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchGiangVien", Conn);
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
