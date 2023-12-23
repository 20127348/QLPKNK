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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treatment1.BringToFront();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            calendar1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calendar1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            profileNS1.BringToFront();
        }
    }
}
