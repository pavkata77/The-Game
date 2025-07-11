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
    public partial class day3fugure : Form
    {
        public day3fugure()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();    
            day3meteor day3Meteor = new day3meteor();
            day3Meteor.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            day3stay day3Stay = new day3stay();
            day3Stay.Show();
        }
    }
}
