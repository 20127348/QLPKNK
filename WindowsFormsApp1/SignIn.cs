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
    public partial class SignIn : UserControl
    {
        public SignIn()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=QLPKNHAKHOA;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string tk = txtusername.Text;
            string mk = txtpassword.Text;
            try
            {
                if (radioButton1.Checked)
                {
                    string sql = "select* from BENHNHAN where TENTAIKHOANBN='" + tk + "' and MATKHAUBN='" + mk + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Save.username = dtable.Rows[0]["HOTENBN"].ToString();
                        Save.dob = dtable.Rows[0]["NGAYSINHBN"].ToString();
                        Save.phonenum = dtable.Rows[0]["SDTBN"].ToString();
                        Save.email = dtable.Rows[0]["EMAIL"].ToString();
                        this.Hide();
                        Form5 frm5 = new Form5();
                        frm5.ShowDialog();
                        frm5 = null;
                        this.Show();
                    }
                    else MessageBox.Show("Error");
                }
                if (radioButton2.Checked)
                {
                    string sql = "select* from NHASI where TENTAIKHOANNS='" + tk + "' and MATKHAUNS='" + mk + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Save.username = dtable.Rows[0]["HOTENNS"].ToString();
                        Save.dob = dtable.Rows[0]["NGAYSINHNS"].ToString();
                        Save.phonenum = dtable.Rows[0]["SDTNS"].ToString();
                        this.Hide();
                        Form2 frm2 = new Form2();
                        frm2.ShowDialog();
                        frm2 = null;
                        this.Show();
                    }
                    else MessageBox.Show("Error");
                }
                if (radioButton3.Checked)
                {
                    string sql = "select* from NHANVIEN where TENTAIKHOANNV='" + tk + "' and MATKHAUNV='" + mk + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Save.username = dtable.Rows[0]["HOTENNV"].ToString();
                        Save.dob = dtable.Rows[0]["NGAYSINHNV"].ToString();
                        Save.phonenum = dtable.Rows[0]["SDTNV"].ToString();
                        this.Hide();
                        Form3 frm3 = new Form3();
                        frm3.ShowDialog();
                        frm3 = null;
                        this.Show();
                    }
                    else MessageBox.Show("Error");
                }
                if (radioButton4.Checked)
                {
                    string sql = "select* from QUANTRIVIEN where TENTAIKHOANQTV='" + tk + "' and MATKHAUQTV='" + mk + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        Save.username = dtable.Rows[0]["HOTENQTV"].ToString();
                        Save.dob = dtable.Rows[0]["NGAYSINHQTV"].ToString();
                        Save.phonenum = dtable.Rows[0]["SDTQTV"].ToString();
                        this.Hide();
                        Form4 frm4 = new Form4();
                        frm4.ShowDialog();
                        frm4 = null;
                        this.Show();
                    }
                    else MessageBox.Show("Error");
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
            /*
            if(username.Text == "ns")
            {
                this.Hide();
                Form2 frm2 = new Form2();
                frm2.ShowDialog();
                frm2 = null;
                this.Show();
            }
            else if (username.Text == "nv")
            {
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
                frm3 = null;
                this.Show();
            }
            else if (username.Text == "ad")
            {
                this.Hide();
                Form4 frm4 = new Form4();
                frm4.ShowDialog();
                frm4 = null;
                this.Show();
            }
            else if (username.Text == "kh")
            {
                this.Hide();
                Form5 frm5 = new Form5();
                frm5.ShowDialog();
                frm5 = null;
                this.Show();
            }
            */
            
        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
