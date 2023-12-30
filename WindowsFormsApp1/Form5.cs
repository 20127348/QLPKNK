using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            profileKH1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scheduleKH1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            medicineKH1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            profileKH1.BringToFront();
        }

        private void medicineKH1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            treatmentKH1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            billKH1.BringToFront();
        }
    }
}
