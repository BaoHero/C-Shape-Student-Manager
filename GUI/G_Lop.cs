using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyBienLai
{
    public partial class G_Lop : Form
    {
        public G_Lop()
        {
            InitializeComponent();
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvLop.Rows[e.RowIndex];
            txtML.Text = row.Cells[0].Value.ToString();
            txtTL.Text = row.Cells[1].Value.ToString();
            txtMK.Text = row.Cells[2].Value.ToString();
        }

        private void G_Lop_Load(object sender, EventArgs e)
        {
            dgvLop.DataSource = B_Lop.GetAllLop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string malop = txtML.Text;
                string tenlop = txtTL.Text;
                string makhoa = txtMK.Text;
                tblLop lop = new tblLop(malop, tenlop, makhoa);
                B_Lop.InsertLop(lop);
                MessageBox.Show(" Bạn đã thêm " + tenlop + "thành công");
                dgvLop.DataSource = B_Lop.GetAllLop();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string malop = txtML.Text;
                string tenlop = txtTL.Text;
                string makhoa = txtMK.Text;
                tblLop lop = new tblLop(malop, tenlop, makhoa);
                B_Lop.UpdateLop(lop);
                MessageBox.Show(" Bạn đã sửa " + malop + "thành công");
                dgvLop.DataSource = B_Lop.GetAllLop();
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
                string malop = txtML.Text;
                string tenlop = txtTL.Text;
                string makhoa = txtMK.Text;
                tblLop lop = new tblLop(malop, tenlop, makhoa);
                B_Lop.DeleteLop(malop);
                MessageBox.Show(" Bạn đã xóa" + malop + "thành công");
                dgvLop.DataSource = B_Lop.GetAllLop();
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
                string searchText = txttk.Text;
                dgvLop.DataSource = B_Lop.SearchLop(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            G_Khoa newForm = new G_Khoa();
            newForm.Show();
            this.Hide();
        }
    }
}
