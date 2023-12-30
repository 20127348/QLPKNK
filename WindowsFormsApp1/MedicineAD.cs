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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace WindowsFormsApp1
{
    public partial class MedicineAD : UserControl
    {
        public MedicineAD()
        {
            InitializeComponent();
        }
        
        SqlConnection conn;
        SqlCommand cmd;
        string str = @"Data Source=DESKTOP-V4J1R76;Initial Catalog=QLPKNHAKHOATEST;Integrated Security=True";
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable tb = new DataTable();

        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select* from THUOC";
            sda.SelectCommand = cmd;
            tb.Clear();
            sda.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderCell.Value = "Mã thuốc";
            dataGridView1.Columns[1].HeaderCell.Value = "Tên thuốc";
            dataGridView1.Columns[2].HeaderCell.Value = "Số lượng";
            dataGridView1.Columns[3].HeaderCell.Value = "Đơn giá";
            dataGridView1.Columns[4].HeaderCell.Value = "Mô tả";
        }

        private void MedicineAD_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loadData();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into THUOC(ID_THUOC, TENTHUOC, SOLUONG, GIABAN, MOTA) values ('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"',N'"+textBox5.Text+"')";
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            cmd = conn.CreateCommand();
            cmd.CommandText = "delete from THUOC where ID_THUOC = '"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            loadData();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            cmd = conn.CreateCommand();
            cmd.CommandText = "update THUOC set TENTHUOC = '"+textBox2.Text+"', SOLUONG = '"+textBox3.Text+"', GIABAN = '"+textBox4.Text+"', MOTA = '"+textBox5.Text+"' where ID_THUOC = '"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
