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
    public partial class G_LichThi : Form
    {
        public G_LichThi()
        {
            InitializeComponent();
        }

        private void G_LichThi_Load(object sender, EventArgs e)
        {
            dgvLichThi.DataSource = B_LichThi.GetAllLichThi();
        }

        private void dgvLichThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvLichThi.Rows[e.RowIndex];
                txtMLT.Text = row.Cells[0].Value.ToString();
                txtMMH.Text = row.Cells[1].Value.ToString();
                dtpNT.Text = row.Cells[2].Value.ToString();
                txtGT.Text = row.Cells[3].Value.ToString();
                txtPT.Text = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string malichthi = txtMLT.Text;
                string mamonhoc = txtMMH.Text;
                DateTime ngaythi = dtpNT.Value;
                string giothi = txtGT.Text;
                string phongthi = txtPT.Text;
                tblLichThi lt = new tblLichThi(malichthi,mamonhoc, ngaythi, giothi, phongthi);
                B_LichThi.InsertLichThi(lt);
                MessageBox.Show("Bạn đã thêm mã " + malichthi+ " thành công");
                dgvLichThi.DataSource = B_LichThi.GetAllLichThi();
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
                string malichthi = txtMLT.Text;
                string mamonhoc = txtMMH.Text;
                DateTime ngaythi = dtpNT.Value;
                string giothi = txtGT.Text;
                string phongthi = txtPT.Text;
                tblLichThi lt = new tblLichThi(malichthi, mamonhoc, ngaythi, giothi, phongthi);
                B_LichThi.UpdateLichThi(lt);
                MessageBox.Show("Bạn đã sửa mã " + malichthi + " thành công");
                dgvLichThi.DataSource = B_LichThi.GetAllLichThi();
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

                string malichthi = txtMLT.Text;
                string mamonhoc = txtMMH.Text;
                DateTime ngaythi = dtpNT.Value;
                string giothi = txtGT.Text;
                string phongthi = txtPT.Text;
                tblLichThi lt = new tblLichThi(malichthi, mamonhoc, ngaythi, giothi, phongthi);
                B_LichThi.DeleteLichThi(malichthi);
                MessageBox.Show("Bạn đã xóa mã " + malichthi + " thành công");
                dgvLichThi.DataSource = B_LichThi.GetAllLichThi();
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
                string searchText = txtSearchMaLichThi.Text;
                dgvLichThi.DataSource = B_LichThi.SearchLichThi(searchText);
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
    }
}
