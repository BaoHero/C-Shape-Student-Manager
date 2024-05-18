using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAL
{
    public class D_HocSinh
    {
        public static DataTable getData()
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_GetAllHocSinh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            Conn.Close();
            return dt;
        }
        public static void InsertHS(tblHocSinh hs)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_InsertHocSinh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TenSinhVien", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200);
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 100);

            command.Parameters["@MaSinhVien"].Value = hs.MaSinhVien1;
            command.Parameters["@TenSinhVien"].Value = hs.TenSinhVien1;
            command.Parameters["@NgaySinh"].Value = hs.NgaySinh1;
            command.Parameters["@GioiTinh"].Value = hs.GioiTinh1;
            command.Parameters["@DiaChi"].Value = hs.DiaChi1;
            command.Parameters["@MaLop"].Value = hs.MaLop1;




            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void UpdateHS(tblHocSinh hs)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_UpdateHocSinh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@TenSinhVien", SqlDbType.NVarChar, 100);
            command.Parameters.Add("@NgaySinh", SqlDbType.Date);
            command.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 10);
            command.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200);
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 100);

            command.Parameters["@MaSinhVien"].Value = hs.MaSinhVien1;
            command.Parameters["@TenSinhVien"].Value = hs.TenSinhVien1;
            command.Parameters["@NgaySinh"].Value = hs.NgaySinh1;
            command.Parameters["@GioiTinh"].Value = hs.GioiTinh1;
            command.Parameters["@DiaChi"].Value = hs.DiaChi1;
            command.Parameters["@MaLop"].Value = hs.MaLop1;


            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static void DeleteHS(string masv)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_DeleteHocSinh", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaSinhVien", SqlDbType.NVarChar, 100);
            command.Parameters["@MaSinhVien"].Value = masv;

            Conn.Open();
            command.ExecuteNonQuery();
            Conn.Close();
        }
        public static DataTable SearchSV(string searchText)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_SearchSinhVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@SearchText", SqlDbType.NVarChar, 100).Value = searchText;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static DataTable ThongKeSinhVienTheoLop(string maLop)
        {
            SqlConnection Conn = dbConnectionData.HamKetNoi();
            SqlCommand command = new SqlCommand("sp_ThongKeSinhVien", Conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@MaLop", SqlDbType.NVarChar, 100).Value = maLop;

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}