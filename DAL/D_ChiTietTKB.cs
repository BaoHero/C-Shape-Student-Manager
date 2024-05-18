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
    public class D_ChiTietTKB
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllChiTietTKB", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void UpdateChiTietTKB(tblChiTietTKB chiTietTKB)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateChiTietTKB", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaThoiKhoaBieu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@Thu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TietBatDau", SqlDbType.Int);
            command.Parameters.Add("@PhongHoc", SqlDbType.NVarChar, 100);

            command.Parameters["@MaThoiKhoaBieu"].Value = chiTietTKB.MaThoiKhoaBieu1;
            command.Parameters["@MaMonHoc"].Value = chiTietTKB.MaMonHoc1;
            command.Parameters["@Thu"].Value = chiTietTKB.Thu1;
            command.Parameters["@TietBatDau"].Value = chiTietTKB.TietBatDau1;
            command.Parameters["@PhongHoc"].Value = chiTietTKB.PhongHoc1;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void InsertChiTietTKB(tblChiTietTKB cttkb)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertChiTietTKB", Conn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.Add("@MaThoiKhoaBieu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@MaMonHoc", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@Thu", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TietBatDau", SqlDbType.Int);
            command.Parameters.Add("@PhongHoc", SqlDbType.NVarChar, 100);

            command.Parameters["@MaThoiKhoaBieu"].Value = cttkb.MaThoiKhoaBieu1;
            command.Parameters["@MaMonHoc"].Value = cttkb.MaMonHoc1;
            command.Parameters["@Thu"].Value = cttkb.Thu1;
            command.Parameters["@TietBatDau"].Value = cttkb.TietBatDau1;
            command.Parameters["@PhongHoc"].Value = cttkb.PhongHoc1;



            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }

        public static void DeleteChiTietTKB(string macttkb)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteChiTietTKB", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaThoiKhoaBieu", SqlDbType.NVarChar, 100);
            command.Parameters["@MaThoiKhoaBieu"].Value = macttkb;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
    }

}
