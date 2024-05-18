using QuanLyBienLai.LoginTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyBienLai
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            QueriesTableAdapter dn = new QueriesTableAdapter();
            if(dn.checkLog(txtTK.Text,txtMK.Text) == 1)
            {
                main m = new main();
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                txtTK.ResetText();
                txtMK.ResetText();
            }

            main newtext = new main();
            newtext.SetLabelText(txtTK.Text);
            newtext.Show();

        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
