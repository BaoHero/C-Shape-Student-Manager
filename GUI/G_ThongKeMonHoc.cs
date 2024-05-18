using BUS;
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
    public partial class G_ThongKeMonHoc : Form
    {
        public G_ThongKeMonHoc()
        {
            InitializeComponent();
        }

        private void G_ThongKeMonHoc_Load(object sender, EventArgs e)
        {
            dgvThongKeMonHoc.DataSource = B_MonHoc.ThongKeMonHoc();
        }
    }
}