using System;
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
    public partial class den1train : Form
    {
        public den1train()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            den1tdrugs den1Tdrugs = new den1tdrugs();
            den1Tdrugs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            day1keeprunning day1Keeprunning = new day1keeprunning();
            day1Keeprunning.Show();
        }
    }
}
