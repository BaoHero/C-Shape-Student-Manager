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
    public class D_Lop
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllLop", Conn); // Lấy dữ liệu từ proce
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertLop(tblLop l)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertLop", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TenLop", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 100);

            command.Parameters["@MaLop"].Value = l.MaLop1;
            command.Parameters["@TenLop"].Value = l.TenLop1;
            command.Parameters["@MaKhoa"].Value = l.MaKhoa1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();



        }


        public static void UpdateLop(tblLop l)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateLop", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TenLop", SqlDbType.NVarChar, 50);
            command.Parameters.Add("@MaKhoa", SqlDbType.NVarChar, 100);

            command.Parameters["@MaLop"].Value = l.MaLop1;
            command.Parameters["@TenLop"].Value = l.TenLop1;
            command.Parameters["@MaKhoa"].Value = l.MaKhoa1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();





        }
        public static void DeleteLop(string malop)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteLop", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 100);
            command.Parameters["@MaLop"].Value = malop;



            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();





        }
        public static DataTable SearchLop(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchLop", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = searchText;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
