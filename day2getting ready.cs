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
    public partial class day2getting_ready : Form
    {
        public day2getting_ready()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            day2_alien day2_alien = new day2_alien();
            day2_alien.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
