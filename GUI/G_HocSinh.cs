using BUS;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyBienLai
{
    public partial class G_HocSinh : Form
    {
        public G_HocSinh()
        {
            InitializeComponent();
        }

        private void G_HocSinh_Load(object sender, EventArgs e)
        {
            dgvHocSinh.DataSource = B_HocSinh.GetAllHocSinh();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            main newForm = new main();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                string masv = textBox1.Text;
                string tensv = textBox3.Text;
                DateTime ns = dateTimePicker1.Value;
                string gt = comboBox1.Text;
                string ml = txtML.Text;
                string dc = textBox4.Text;
                tblHocSinh hocsinh = new tblHocSinh(masv, tensv, ns, gt, dc, ml);
                B_HocSinh.InsertHocSinh(hocsinh);
                MessageBox.Show("Bạn đã thêm " + tensv + " vào danh sách ");
                dgvHocSinh.DataSource = B_HocSinh.GetAllHocSinh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string masv = textBox1.Text;
            string tensv = textBox3.Text;
            DateTime ns = dateTimePicker1.Value;
            string gt = comboBox1.Text;
            string ml = txtML.Text;
            string dc = textBox4.Text;
            tblHocSinh hocsinh = new tblHocSinh(masv, tensv, ns, gt, dc, ml);
            B_HocSinh.UpdateHocSinh(hocsinh);
            MessageBox.Show("Bạn đã sửa " + tensv + " trong danh sách ");
            dgvHocSinh.DataSource = B_HocSinh.GetAllHocSinh();

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string masv = textBox1.Text;
            string tensv = textBox3.Text;
            DateTime ns = dateTimePicker1.Value;
            string gt = comboBox1.Text;
            string ml = txtML.Text;
            string dc = textBox4.Text;
            tblHocSinh hocsinh = new tblHocSinh(masv, tensv, ns, gt, dc, ml);
            B_HocSinh.DeleteHocSinh(masv);
            MessageBox.Show("Bạn đã xóa " + tensv + " khỏi danh sách ");
            dgvHocSinh.DataSource = B_HocSinh.GetAllHocSinh();
        }

        private void dgvHocSinh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHocSinh.Rows[e.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                comboBox1.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
                txtML.Text = row.Cells[5].Value.ToString();
            }
            catch { }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text;
                dgvHocSinh.DataSource = B_HocSinh.SearchSinhVien(searchText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            G_Lop newForm = new G_Lop();
            newForm.Show();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                string maLop = txtThongKe.Text;
                dgvHocSinh.DataSource = B_HocSinh.ThongKeSinhVienTheoLop(maLop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}