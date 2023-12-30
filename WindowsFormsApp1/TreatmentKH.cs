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
    public partial class TreatmentKH : UserControl
    {
        public TreatmentKH()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-V4J1R76;Initial Catalog=QLPKNHAKHOATEST;Integrated Security=True");
        void loadData()
        {
            string sql = "select TENKEHOACH, BEMAT, TRANGTHAI from KEHOACHDIEUTRI join RANGKHAM on KEHOACHDIEUTRI.ID_KEHOACH = RANGKHAM.ID_KEHOACH where ID_HOSOBN = " + Save.id_hs + "";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderCell.Value = "Kế hoạch";
            dataGridView1.Columns[1].HeaderCell.Value = "Bề mặt";
            dataGridView1.Columns[2].HeaderCell.Value = "Trạng thái";
        }
        private void TreatmentKH_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadData();
        }
    }
}
