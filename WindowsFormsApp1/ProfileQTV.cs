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
    public partial class ProfileQTV : UserControl
    {
        public ProfileQTV()
        {
            InitializeComponent();
        }

        private void ProfileQTV_Load(object sender, EventArgs e)
        {
            textBox1.Text = Save.username;
            textBox2.Text = Save.dob;
            textBox3.Text = Save.phonenum;
        }
    }
}
