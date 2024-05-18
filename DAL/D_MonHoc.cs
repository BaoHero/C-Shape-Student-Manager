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
    public class D_MonHoc
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllMonHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertMH(tblMonHoc mh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertMonHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar);
            command.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar);
            command.Parameters.Add("@SoTinChi", SqlDbType.Int);
            command.Parameters.Add("@MaGiangVien", SqlDbType.NVarChar);
            command.Parameters["@MaMonHoc"].Value = mh.MaMonHoc1;
            command.Parameters["@TenMonHoc"].Value = mh.TenMonHoc1;
            command.Parameters["@SoTinChi"].Value = mh.SoTinChi1;
            command.Parameters["@MaGiangVien"].Value = mh.MaGiangVien1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateMH(tblMonHoc mh)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateMonHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar);
            command.Parameters.Add("@TenMonHoc", SqlDbType.NVarChar);
            command.Parameters.Add("@SoTinChi", SqlDbType.Int);
            command.Parameters.Add("@MaGiangVien", SqlDbType.NVarChar);
            command.Parameters["@MaMonHoc"].Value = mh.MaMonHoc1;
            command.Parameters["@TenMonHoc"].Value = mh.TenMonHoc1;
            command.Parameters["@SoTinChi"].Value = mh.SoTinChi1;
            command.Parameters["@MaGiangVien"].Value = mh.MaGiangVien1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteMH(string mamonhoc)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteMonHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar);
            command.Parameters["@MaMonHoc"].Value = mamonhoc;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchMonHoc(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchMonHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = searchText;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable ThongKeMonHoc()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_ThongKeMonHoc", Conn);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
