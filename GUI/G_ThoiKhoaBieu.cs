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
    public partial class G_ThoiKhoaBieu : Form
    {
        public G_ThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void G_ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            dgvThoiKhoaBieu.DataSource = B_ThoiKhoaBieu.GetAllThoiKhoaBieu();
        }

        private void dgvThoiKhoaBieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvThoiKhoaBieu.Rows[e.RowIndex];
                txtmtkb.Text = row.Cells[0].Value.ToString();
                txtmsv.Text = row.Cells[1].Value.ToString();

            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mathoikhoabieu = txtmtkb.Text;
                string masinhvien = txtmsv.Text;


                tblThoiKhoaBieu thoikhoabieu = new tblThoiKhoaBieu(mathoikhoabieu, masinhvien);
                B_ThoiKhoaBieu.InsertThoiKhoaBieu(thoikhoabieu);
                MessageBox.Show("Bạn đã thêm mã" + mathoikhoabieu + " thành công");
                dgvThoiKhoaBieu.DataSource = B_ThoiKhoaBieu.GetAllThoiKhoaBieu();
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
                string mathoikhoabieu = txtmtkb.Text;
                string masinhvien = txtmsv.Text;


                tblThoiKhoaBieu thoikhoabieu = new tblThoiKhoaBieu(mathoikhoabieu, masinhvien);
                B_ThoiKhoaBieu.UpdateThoiKhoaBieu(thoikhoabieu);
                MessageBox.Show("Bạn đã thêm sửa" + mathoikhoabieu + " thành công");
                dgvThoiKhoaBieu.DataSource = B_ThoiKhoaBieu.GetAllThoiKhoaBieu();
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
                string mathoikhoabieu = txtmtkb.Text;
                string masinhvien = txtmsv.Text;


                tblThoiKhoaBieu thoikhoabieu = new tblThoiKhoaBieu(mathoikhoabieu, masinhvien);
                B_ThoiKhoaBieu.DeleteThoiKhoaBieu(mathoikhoabieu);
                MessageBox.Show("Bạn đã thêm xóa" + mathoikhoabieu + " thành công");
                dgvThoiKhoaBieu.DataSource = B_ThoiKhoaBieu.GetAllThoiKhoaBieu();
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

        private void button5_Click(object sender, EventArgs e)
        {
            main newForm = new main();
            newForm.Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            G_ChiTietTKB newForm = new G_ChiTietTKB();
            newForm.Show();
            
        }
    }
}
