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
    public partial class G_ChiTietTKB : Form
    {
        public G_ChiTietTKB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvcttkb.DataSource = B_ChiTietTKB.GetAllChiTietTKB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvcttkb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvcttkb.Rows[e.RowIndex];
            txtmtkb.Text = row.Cells[0].Value.ToString();
            txtmmh.Text = row.Cells[1].Value.ToString();
            txtt.Text = row.Cells[2].Value.ToString();
            txttbd.Text = row.Cells[3].Value.ToString();
            txtph.Text = row.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mathoikhoabieu = txtmtkb.Text;
                string mamonhoc = txtmmh.Text;
                string thu = txtt.Text;
                int tietbatdau = int.Parse(txttbd.Text);
                string phonghoc = txtph.Text;



                tblChiTietTKB cttkb = new tblChiTietTKB(mathoikhoabieu, mamonhoc, thu, tietbatdau, phonghoc);
                B_ChiTietTKB.InsertChiTietTKB(cttkb);
                MessageBox.Show("Bạn đã thêm " + mathoikhoabieu + " thành công");
                dgvcttkb.DataSource = B_ChiTietTKB.GetAllChiTietTKB();
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
                string mamonhoc = txtmmh.Text;
                string thu = txtt.Text;
                int tietbatdau = int.Parse(txttbd.Text);
                string phonghoc = txtph.Text;



                tblChiTietTKB cttkb = new tblChiTietTKB(mathoikhoabieu, mamonhoc, thu, tietbatdau, phonghoc);
                B_ChiTietTKB.UpdateChiTietTKB(cttkb);
                MessageBox.Show("Bạn đã sửa " + mathoikhoabieu + " thành công");
                dgvcttkb.DataSource = B_ChiTietTKB.GetAllChiTietTKB();
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
                string mamonhoc = txtmmh.Text;
                string thu = txtt.Text;
                int tietbatdau = int.Parse(txttbd.Text);
                string phonghoc = txtph.Text;



                tblChiTietTKB cttkb = new tblChiTietTKB(mathoikhoabieu, mamonhoc, thu, tietbatdau, phonghoc);
                B_ChiTietTKB.DeleteChiTietTKB(mathoikhoabieu);
                MessageBox.Show("Bạn đã xóa " + mathoikhoabieu + " thành công");
                dgvcttkb.DataSource = B_ChiTietTKB.GetAllChiTietTKB();
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
    }
}
