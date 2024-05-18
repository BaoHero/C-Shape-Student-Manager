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
using QuanLyBienLai;

namespace QuanLyBienLai
{
    public partial class G_GiangVien : Form
    {
        public G_GiangVien()
        {
            InitializeComponent();
        }

        private void G_GiangVien_Load(object sender, EventArgs e)
        {
            dgvgiangvien.DataSource = B_GiangVien.GetAllGiangVien();
        }

        private void dgvgiangvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string magiangvien = txtmgv.Text;
                string tengiangvien = txttgv.Text;
                string email = txtem.Text;
                string makhoa = txtmk.Text;

                tblGiangVien hh = new tblGiangVien(magiangvien, tengiangvien, email, makhoa);
                B_GiangVien.InsertGV(hh);
                MessageBox.Show(" Bạn đã thêm " + magiangvien + " thành công ");
                dgvgiangvien.DataSource = B_GiangVien.GetAllGiangVien();
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
                string magiangvien = txtmgv.Text;
                string tengiangvien = txttgv.Text;
                string email = txtem.Text;
                string makhoa = txtmk.Text;

                tblGiangVien gv = new tblGiangVien(magiangvien, tengiangvien, email, makhoa);
                B_GiangVien.UpdateGV(gv);
                MessageBox.Show(" Bạn đã sửa " + magiangvien + " thành công ");
                dgvgiangvien.DataSource = B_GiangVien.GetAllGiangVien();
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
                string magiangvien = txtmgv.Text;
                string tengiangvien = txttgv.Text;
                string email = txtem.Text;
                string makhoa = txtmk.Text;

                tblGiangVien giangvien = new tblGiangVien(magiangvien, tengiangvien, email, makhoa);
                B_GiangVien.DeleteGiangVien(magiangvien);
                MessageBox.Show(" Bạn đã xóa " + magiangvien + " thành công ");
                dgvgiangvien.DataSource = B_GiangVien.GetAllGiangVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void dgvGiangVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvgiangvien.Rows[e.RowIndex];
            txtmgv.Text = row.Cells[0].Value.ToString();
            txttgv.Text = row.Cells[1].Value.ToString();
            txtem.Text = row.Cells[2].Value.ToString();
            txtmk.Text = row.Cells[3].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txttkgv.Text;
                dgvgiangvien.DataSource = B_GiangVien.SearchGiangVien(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
