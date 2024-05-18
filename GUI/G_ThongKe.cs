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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyBienLai
{
    public partial class G_ThongKe : Form
    {
        private Dictionary<string, string> columnNameMapping;
        public G_ThongKe(DataTable thongKeData)
        {
            InitializeComponent();
            columnNameMapping = new Dictionary<string, string>
            {
                { "Mã sinh viên", "MaSinhVien" },
                { "Ngày thanh toán", "NgayThanhToan" }
            };

            comboBox1.DataSource = new BindingSource(columnNameMapping, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
            dgvThongKe.DataSource = thongKeData;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string displayName = comboBox1.Text;

            if (columnNameMapping.ContainsKey(displayName))
            {
                string columnName = columnNameMapping[displayName];
                DataTable data = B_BienLai.ThongKeBL(columnName);

                dgvThongKe.DataSource = data;

                DrawPieChart(data, displayName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DrawPieChart(DataTable data, string columnName)
        {
            chart1.Series.Clear();
            chart1.Titles.Clear();

            Series series = new Series(columnName);
            series.ChartType = SeriesChartType.Pie;

            foreach (DataRow row in data.Rows)
            {
                string label = row[0].ToString();
                int value = Convert.ToInt32(row[1]);

                series.Points.AddXY(label, value);
            }

            chart1.Series.Add(series);

            chart1.Titles.Add(columnName);
        }
    }
}
