﻿using System;
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
    public partial class ProfileKH : UserControl
    {
        public ProfileKH()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfileKH_Load(object sender, EventArgs e)
        {
            textBox1.Text = Save.username;
            textBox2.Text = Save.dob;
            textBox3.Text = Save.phonenum;
            textBox4.Text = Save.email;
            textBox5.Text = Save.id_hs;
            textBox6.Text = Save.mk;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
