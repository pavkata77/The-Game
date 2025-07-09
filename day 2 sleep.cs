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
    public partial class day_2_sleep : Form
    {
        public day_2_sleep()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            day3morning day3Morning = new day3morning();
            day3Morning.Show();
        }
    }
}
