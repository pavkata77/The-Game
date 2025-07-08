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
    public partial class day2_start : Form
    {
        public day2_start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MiniClickGame miniClickGame = new MiniClickGame();
            miniClickGame.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MiniClickGame miniClickGame = new MiniClickGame();
            miniClickGame.Show();
        }
    }
}
