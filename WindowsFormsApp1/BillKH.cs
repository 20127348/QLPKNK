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
    public partial class BillKH : UserControl
    {
        public BillKH()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-V4J1R76;Initial Catalog=QLPKNHAKHOATEST;Integrated Security=True");

        private void BillKH_Load(object sender, EventArgs e)
        {
            conn.Open();
            string sql = "select ID_HOADON, NGAYGIAODICH, TONGTIENTHANHTOAN, TIENDATRA, TIENTHOI, GHICHU, LOAITHANHTOAN from HOADON where ID_HOSOBN = "+Save.id_hs+"";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            groupBox1.Text = tb.Rows[0]["ID_HOADON"].ToString();
            textBox1.Text = tb.Rows[0]["NGAYGIAODICH"].ToString();
            textBox2.Text = tb.Rows[0]["TONGTIENTHANHTOAN"].ToString();
            textBox3.Text = tb.Rows[0]["TIENDATRA"].ToString();
            textBox4.Text = tb.Rows[0]["TIENTHOI"].ToString();
            textBox5.Text = tb.Rows[0]["GHICHU"].ToString();
            textBox6.Text = tb.Rows[0]["LOAITHANHTOAN"].ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
