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
    public partial class G_MonHoc : Form
    {
        public G_MonHoc()
        {
            InitializeComponent();
        }

        private void G_MonHoc_Load(object sender, EventArgs e)
        {
            dgvMonHoc.DataSource = B_MonHoc.GetAllMonHoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mamonhoc = txtMMH.Text;
                string tenmonhoc = txtTMH.Text;
                int sotinchi = int.Parse(txtSTC.Text);
                string magiangvien = txtMGV.Text;
                tblMonHoc monhoc = new tblMonHoc(mamonhoc, tenmonhoc, sotinchi, magiangvien);
                B_MonHoc.InsertMonHoc(monhoc);
                MessageBox.Show("Bạn đã thêm mã " + mamonhoc + " thành công");
                dgvMonHoc.DataSource = B_MonHoc.GetAllMonHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvMonHoc.Rows[e.RowIndex];
                txtMMH.Text = row.Cells[0].Value.ToString();
                txtTMH.Text = row.Cells[1].Value.ToString();
                txtSTC.Text = row.Cells[2].Value.ToString();
                txtMGV.Text = row.Cells[3].Value.ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mamonhoc = txtMMH.Text;
                string tenmonhoc = txtTMH.Text;
                int sotinchi = int.Parse(txtSTC.Text);
                string magiangvien = txtMGV.Text;
                tblMonHoc monhoc = new tblMonHoc(mamonhoc, tenmonhoc, sotinchi, magiangvien);
                B_MonHoc.UpdateMonHoc(monhoc);
                MessageBox.Show("Bạn đã sửa mã " + mamonhoc + " thành công");
                dgvMonHoc.DataSource = B_MonHoc.GetAllMonHoc();
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
                string mamonhoc = txtMMH.Text;
                string tenmonhoc = txtTMH.Text;
                int sotinchi = int.Parse(txtSTC.Text);
                string magiangvien = txtMGV.Text;
                tblMonHoc monhoc = new tblMonHoc(mamonhoc, tenmonhoc, sotinchi, magiangvien);
                B_MonHoc.DeleteMonHoc(mamonhoc);
                MessageBox.Show("Bạn đã xóa mã " + mamonhoc + " thành công");
                dgvMonHoc.DataSource = B_MonHoc.GetAllMonHoc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text;
                dgvMonHoc.DataSource = B_MonHoc.SearchMonHoc(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            main newForm = new main();
            newForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            G_GiangVien newForm = new G_GiangVien();
            newForm.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                G_ThongKeMonHoc thongKeForm = new G_ThongKeMonHoc(); // Tạo instance của G_ThongKeMonHoc
                thongKeForm.Show(); // Hiển thị form G_ThongKeMonHoc
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
