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
    public class D_ThoiKhoaBieu
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllThoiKhoaBieu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertThoiKhoaBieu(tblThoiKhoaBieu tkb)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertThoiKhoaBieu", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaThoiKhoaBieu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar, 100);
            ;


            command.Parameters["@MaThoiKhoaBieu"].Value = tkb.MaThoiKhoaBieu1;
            command.Parameters["@MaSinhVien"].Value = tkb.MaSinhVien1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateThoiKhoaBieu(tblThoiKhoaBieu tkb)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateDiem", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaThoiKhoaBieu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar, 100);
            ;


            command.Parameters["@MaThoiKhoaBieu"].Value = tkb.MaThoiKhoaBieu1;
            command.Parameters["@MaSinhVien"].Value = tkb.MaSinhVien1;



            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteThoiKhoaBieu(string mathoikhoabieu)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteThoiKhoaBieu", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaThoiKhoaBieu", SqlDbType.NVarChar, 100);
            command.Parameters["@MaThoiKhoaBieu"].Value = mathoikhoabieu;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }
}
