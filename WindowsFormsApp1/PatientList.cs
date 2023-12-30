using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApp1
{
    public partial class PatientList : UserControl
    {
        public PatientList()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-V4J1R76;Initial Catalog=QLPKNHAKHOATEST;Integrated Security=True");

        void loadData()
        {
            string sql = "select ID_HOSOBN, HOTENBN, SDTBN, NGAYSINHBN, GIOITINHBN, TINHTRANGSUCKHOE, THONGTINTONGQUAN from HOSOBENHNHAN";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderCell.Value = "ID Hồ sơ";
            dataGridView1.Columns[1].HeaderCell.Value = "Họ tên";
            dataGridView1.Columns[2].HeaderCell.Value = "Số điện thoại";
            dataGridView1.Columns[3].HeaderCell.Value = "Ngày sinh";
            dataGridView1.Columns[4].HeaderCell.Value = "Giới tính";
            dataGridView1.Columns[5].HeaderCell.Value = "Tình trạng sức khỏe";
            dataGridView1.Columns[6].HeaderCell.Value = "Thông tin tổng quát";
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadData();
        }
    }
}
