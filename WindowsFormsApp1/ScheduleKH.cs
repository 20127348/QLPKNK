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
    public partial class ScheduleKH : UserControl
    {
        public ScheduleKH()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-V4J1R76;Initial Catalog=QLPKNHAKHOATEST;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ScheduleKH_Load(object sender, EventArgs e)
        {
            
            conn.Open();
            string sql = "select ID_LICHHEN, THOIGIAN, PHONG, TINHTRANG, HOTENNS from NHASI join LICHHEN on NHASI.ID_NHASI = LICHHEN.ID_NHASI where ID_HOSOBN = "+Save.id_hs+"";
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            sda.Fill(tb);
            groupBox1.Text = tb.Rows[0]["ID_LICHHEN"].ToString();
            textBox1.Text = tb.Rows[0]["THOIGIAN"].ToString();
            textBox2.Text = tb.Rows[0]["PHONG"].ToString();
            textBox3.Text = tb.Rows[0]["TINHTRANG"].ToString();
            textBox4.Text = tb.Rows[0]["HOTENNS"].ToString();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
