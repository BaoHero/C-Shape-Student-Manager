using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBienLai
{
    public partial class G_BienLai : Form
    {
        public G_BienLai()
        {
            InitializeComponent();
        }

        private void G_BienLai_Load(object sender, EventArgs e)
        {
            dgvBienLai.DataSource = B_BienLai.GetAllBienLai();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mabienlai = txtMBL.Text;
                string masinhvien = txtMSV.Text;
                DateTime ngaythanhtoan = dtpNTT.Value;
                tblBienLai bienlai = new tblBienLai(mabienlai, masinhvien, ngaythanhtoan);
                B_BienLai.InsertBienLai(bienlai);
                MessageBox.Show("Bạn đã thêm mã " + mabienlai + " thành công");
                dgvBienLai.DataSource = B_BienLai.GetAllBienLai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvBienLai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvBienLai.Rows[e.RowIndex];
                txtMBL.Text = row.Cells[0].Value.ToString();
                txtMSV.Text = row.Cells[1].Value.ToString();
                dtpNTT.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            G_ChiTietBienLai newForm = new G_ChiTietBienLai();

            // Hiển thị form mới
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mabienlai = txtMBL.Text;
                string masinhvien = txtMSV.Text;
                DateTime ngaythanhtoan = dtpNTT.Value;
                tblBienLai bienlai = new tblBienLai(mabienlai, masinhvien, ngaythanhtoan);
                B_BienLai.UpdateBienLai(bienlai);
                MessageBox.Show("Bạn đã sửa mã " + mabienlai + " thành công");
                dgvBienLai.DataSource = B_BienLai.GetAllBienLai();
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
                string mabienlai = txtMBL.Text;
                string masinhvien = txtMSV.Text;
                DateTime ngaythanhtoan = dtpNTT.Value;
                tblBienLai bienlai = new tblBienLai(mabienlai, masinhvien, ngaythanhtoan);
                B_BienLai.DeleteBienLai(mabienlai);
                MessageBox.Show("Bạn đã xóa mã " + mabienlai + " thành công");
                dgvBienLai.DataSource = B_BienLai.GetAllBienLai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearchMaBienLai.Text;
                dgvBienLai.DataSource = B_BienLai.SearchBienLai(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable thongKeData = B_BienLai.ThongKeBL("MaSinhVien");
                G_ThongKe formThongKe = new G_ThongKe(thongKeData);
                formThongKe.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
