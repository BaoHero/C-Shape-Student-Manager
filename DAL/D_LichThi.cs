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
    public class D_LichThi
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllLichThi", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertLT(tblLichThi lt)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertLichThi", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLichThi", SqlDbType.NVarChar);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar);
            command.Parameters.Add("@NgayThi", SqlDbType.Date);
            command.Parameters.Add("@GioThi", SqlDbType.NVarChar);
            command.Parameters.Add("@PhongThi", SqlDbType.NVarChar);
            command.Parameters["@MaLichThi"].Value = lt.MaLichThi1;
            command.Parameters["@MaMonHoc"].Value = lt.MaMonHoc1;
            command.Parameters["@NgayThi"].Value = lt.NgayThi1;
            command.Parameters["@GioThi"].Value = lt.GioThi1;
            command.Parameters["@PhongThi"].Value = lt.PhongThi1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateLT(tblLichThi lt)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateLichThi", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLichThi", SqlDbType.NVarChar);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar);
            command.Parameters.Add("@NgayThi", SqlDbType.Date);
            command.Parameters.Add("@GioThi", SqlDbType.NVarChar);
            command.Parameters.Add("@PhongThi", SqlDbType.NVarChar);
            command.Parameters["@MaLichThi"].Value = lt.MaLichThi1;
            command.Parameters["@MaMonHoc"].Value = lt.MaMonHoc1;
            command.Parameters["@NgayThi"].Value = lt.NgayThi1;
            command.Parameters["@GioThi"].Value = lt.GioThi1;
            command.Parameters["@PhongThi"].Value = lt.PhongThi1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteLT(string malichthi)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteLichThi", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLichThi", SqlDbType.NVarChar);
            command.Parameters["@MaLichThi"].Value = malichthi;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchLichThi(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchLichThi", Conn);
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
