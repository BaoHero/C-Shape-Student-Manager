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
    public partial class G_Diem : Form
    {
        public G_Diem()
        {
            InitializeComponent();
        }

        private void G_Diem_Load(object sender, EventArgs e)
        {
            dgvDiem.DataSource = B_Diem.GetAllDiem();
        }

        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDiem.Rows[e.RowIndex];
                txtmds.Text = row.Cells[0].Value.ToString();
                txtmsv.Text = row.Cells[1].Value.ToString();
                txtmmh.Text = row.Cells[2].Value.ToString();
                txtd.Text = row.Cells[3].Value.ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string madiemso = txtmds.Text;
                string masinhvien = txtmsv.Text;
                string mamonhoc = txtmmh.Text;
                float diem = float.Parse(txtd.Text);

                tblDiem diemm = new tblDiem(madiemso, masinhvien, mamonhoc, diem);
                B_Diem.InsertDiem(diemm);
                MessageBox.Show("Bạn đã thêm mã " + madiemso + " thành công");
                dgvDiem.DataSource = B_Diem.GetAllDiem();
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
                string madiemso = txtmds.Text;
                string masinhvien = txtmsv.Text;
                string mamonhoc = txtmmh.Text;
                float diem = float.Parse(txtd.Text);

                tblDiem diemm = new tblDiem(madiemso, masinhvien, mamonhoc, diem);
                B_Diem.UpdateDiem(diemm);
                MessageBox.Show("Bạn đã sửa " + madiemso + " thành công");
                dgvDiem.DataSource = B_Diem.GetAllDiem();
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
                string madiemso = txtmds.Text;
                string masinhvien = txtmsv.Text;
                string mamonhoc = txtmmh.Text;
                float diem = float.Parse(txtd.Text);

                tblDiem diemm = new tblDiem(madiemso, masinhvien, mamonhoc, diem);
                B_Diem.DeleteDiem(madiemso);
                MessageBox.Show("Bạn đã xóa " + madiemso + " thành công");
                dgvDiem.DataSource = B_Diem.GetAllDiem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            main newForm = new main();
            newForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string searchText = txttk.Text;
                dgvDiem.DataSource = B_Diem.SearchDiem(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
