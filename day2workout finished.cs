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
    public partial class day2workout_finished : Form
    {
        public day2workout_finished()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            day2wofinished day2Wofinished = new day2wofinished();
            day2Wofinished.Show();
        }
    }
}
