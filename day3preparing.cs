﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu
{
    public partial class day3preparing : Form
    {
        public day3preparing()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            day3fugure day3Fugure = new day3fugure();
            day3Fugure.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            day3meteor day3Meteor = new day3meteor();
            day3Meteor.Show();
        }
    }
}
