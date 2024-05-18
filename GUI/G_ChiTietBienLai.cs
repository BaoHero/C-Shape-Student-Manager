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
    public partial class G_ChiTietBienLai : Form
    {
        public G_ChiTietBienLai()
        {
            InitializeComponent();
        }
        private void G_HocPhi_Load(object sender, EventArgs e)
        {
            dgvHocPhi.DataSource = B_ChiTietBienLai.GetAllHocPhi();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mabienlai = txtMBL.Text;
                string mamonhoc = txtMM.Text;
                //int hocphi = int.Parse(txtHP.Text);
                tblChiTietBienLai hocphi1 = new tblChiTietBienLai(mabienlai, mamonhoc);
                B_ChiTietBienLai.InsertHocPhi(hocphi1);
                MessageBox.Show("Bạn đã thêm mã " + mabienlai + " " + mamonhoc + " thành công");
                dgvHocPhi.DataSource = B_ChiTietBienLai.GetAllHocPhi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHocPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvHocPhi.Rows[e.RowIndex];
                txtMBL.Text = row.Cells[0].Value.ToString();
                txtMM.Text = row.Cells[1].Value.ToString();
                txtHP.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mabienlai = txtMBL.Text;
                string mamonhoc = txtMM.Text;
                int hocphi = int.Parse(txtHP.Text);
                tblChiTietBienLai hocphi1 = new tblChiTietBienLai(mabienlai, mamonhoc);
                B_ChiTietBienLai.UpdateHocPhi(hocphi1);
                MessageBox.Show("Bạn đã sửa mã " + mabienlai + " " + mamonhoc + " thành công");
                dgvHocPhi.DataSource = B_ChiTietBienLai.GetAllHocPhi();
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
                string mamonhoc = txtMM.Text;
                int hocphi = int.Parse(txtHP.Text);
                tblChiTietBienLai hocphi1 = new tblChiTietBienLai(mabienlai, mamonhoc);
                B_ChiTietBienLai.DeleteHocPhi(mabienlai,mamonhoc);
                MessageBox.Show("Bạn đã xóa mã " + mabienlai + " " + mamonhoc + " thành công");
                dgvHocPhi.DataSource = B_ChiTietBienLai.GetAllHocPhi();
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
                dgvHocPhi.DataSource = B_ChiTietBienLai.SearchHP(searchText);
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
                // Chọn đường dẫn lưu tệp tin
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Chọn nơi lưu tệp tin";
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    string filePath = saveFileDialog.FileName;
                    B_ChiTietBienLai.ExportHPToCsv(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
