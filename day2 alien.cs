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
    public partial class day2_alien : Form
    {
        public day2_alien()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            day2alien_end day2Alien_End = new day2alien_end();
            day2Alien_End.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            day1_alien_bad day2_Alien_Bad = new day1_alien_bad();
            day2_Alien_Bad.Show();
        }
    }
}
