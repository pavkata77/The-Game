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
    public partial class den1 : Form
    {
        public den1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            den1bad den1Bad = new den1bad();
            den1Bad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            den1train den1train = new den1train();
            den1train.Show();
        }
    }
}
