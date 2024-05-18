using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyBienLai
{
    public partial class G_Khoa : Form
    {
        public G_Khoa()
        {
            InitializeComponent();
        }

        private void G_Khoa_Load(object sender, EventArgs e)
        {
            dgvkhoa.DataSource = B_Khoa.GetAllKhoa();
        }

        private void dgvkhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvkhoa.Rows[e.RowIndex];
            txtmk.Text = row.Cells[0].Value.ToString();
            txttk.Text = row.Cells[1].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string makhoa = txtmk.Text;
                string tenkhoa = txttk.Text;


                tblKhoa khoa = new tblKhoa(makhoa, tenkhoa);
                B_Khoa.InsertKhoa(khoa);
                MessageBox.Show("Bạn đã thêm " + makhoa + " thành công");
                dgvkhoa.DataSource = B_Khoa.GetAllKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                string makhoa = txtmk.Text;
                string tenkhoa = txttk.Text;


                tblKhoa khoa = new tblKhoa(makhoa, tenkhoa);
                B_Khoa.UpdateKhoa(khoa);
                MessageBox.Show("Bạn đã sửa " + makhoa + " thành công");
                dgvkhoa.DataSource = B_Khoa.GetAllKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                string makhoa = txtmk.Text;
                string tenkhoa = txttk.Text;


                tblKhoa khoa = new tblKhoa(makhoa, tenkhoa);
                B_Khoa.DeleteKhoa(makhoa);
                MessageBox.Show("Bạn đã xóa " + makhoa + " thành công");
                dgvkhoa.DataSource = B_Khoa.GetAllKhoa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            G_Lop newForm = new G_Lop();
            newForm.Show();
            this.Hide();
        }

        private void dgvkhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txttkk.Text;
                dgvkhoa.DataSource = B_Khoa.SearchKhoa(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
