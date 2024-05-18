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
    public class D_Diem
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllDiem", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertDiem(tblDiem d)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertDiem", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaDiemSo", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@Diem", SqlDbType.Float);


            command.Parameters["@MaDiemSo"].Value = d.MaDiemSo1;
            command.Parameters["@MaSinhVien"].Value = d.MaSinhVien1;
            command.Parameters["@MaMonHoc"].Value = d.MaMonHoc1;
            command.Parameters["@Diem"].Value = d.Diem1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateDiem(tblDiem d)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateDiem", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaDiemSo", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@Diem", SqlDbType.Float);


            command.Parameters["@MaDiemSo"].Value = d.MaDiemSo1;
            command.Parameters["@MaSinhVien"].Value = d.MaSinhVien1;
            command.Parameters["@MaMonHoc"].Value = d.MaMonHoc1;
            command.Parameters["@Diem"].Value = d.Diem1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteDiem(string madiemso)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteDiem", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaDiemSo", SqlDbType.NVarChar, 100);
            command.Parameters["@MaDiemSo"].Value = madiemso;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchDiem(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchDiem", Conn);
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
