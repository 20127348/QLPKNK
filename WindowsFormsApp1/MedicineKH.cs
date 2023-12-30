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
    public partial class MedicineKH : UserControl
    {
        public MedicineKH()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-V4J1R76;Initial Catalog=QLPKNHAKHOATEST;Integrated Security=True");

        
        void loadData()
        {
            
            string sql = "select TENTHUOC, SOLUONGCAP, GIABAN from DONTHUOC join THUOC on DONTHUOC.ID_THUOC = THUOC.ID_THUOC where ID_HOSOBN = "+Save.id_hs+"";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderCell.Value = "Tên thuốc";
            dataGridView1.Columns[1].HeaderCell.Value = "Số lượng cấp";
            dataGridView1.Columns[2].HeaderCell.Value = "Đơn giá";
        }
        

        private void MedicineKH_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadData();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
