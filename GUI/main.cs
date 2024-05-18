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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm )
        {
            if(currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add( childForm );
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new G_BienLai());
            label1.Text = "QUẢN LÍ BIÊN LAI";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new G_LichThi());
            label1.Text = "QUẢN LÍ LỊCH THI";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new G_Diem());
            label1.Text = "QUẢN LÍ ĐIỂM SINH VIÊN";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new G_HocSinh());
            label1.Text = "THÔNG TIN SINH VIÊN";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new G_ThoiKhoaBieu());
            label1.Text = "QUẢN LÍ THỜI KHÓA BIỂU";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new G_MonHoc());
            label1.Text = "QUẢN LÍ THÔNG TIN MÔN HỌC";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = " QUẢN LÍ THÔNG TIN SINH VIEN ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DangNhap newForm = new DangNhap();
            newForm.Show();
            this.Hide();
        }

       public void SetLabelText(string text)
        {
            TenTKlabel.Text = text;
        }
    }
}
