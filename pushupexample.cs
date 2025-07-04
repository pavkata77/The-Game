using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_menu
{
    public partial class pushupexample : Form
    {
        public pushupexample()
        {
            InitializeComponent();
        }
        private int x;
        private int y;
        private List<Image> backgroundImages;
        private int imageIndex = 0;
        private const int requiredClicks = 30;
        private const int totalSeconds = 10;
        private Timer countdownTimer;
        private int secondsLeft;

        private void button1_Click(object sender, EventArgs e)
        {
            x++;
            if (x % 2 == 0)
            {
                y++;
                button1.Text = y.ToString();

            }
            imageIndex = (imageIndex + 1) % backgroundImages.Count;
            this.BackgroundImage = backgroundImages[imageIndex];

            if(y >= requiredClicks)
            {
                countdownTimer.Stop();
                MessageBox.Show($"Great! You did {y} push ups.");
                this.Hide();
                day1eating day1Eating = new day1eating();
                day1Eating.Show();
            }
        }

        private void pushupexample_Load(object sender, EventArgs e)
        {
            backgroundImages = new List<Image>
            {
                Properties.Resources._1__9zE_A7jBt9_DySFtbrWPw,
                Properties.Resources._1__9zE_A7jBt9_DySFtbrWPw__1_,

            };
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = backgroundImages[0];

            secondsLeft = totalSeconds;

           
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; 
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();

         
            label1.Text = $"Time Left: {secondsLeft}s";

          
            button1.Text = "Count: 0";
        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            secondsLeft--;
            label1.Text = $"Time Left: {secondsLeft}s";

            if (secondsLeft <= 0)
            {
                countdownTimer.Stop();

                if (y < requiredClicks)
                {
                   
                    MessageBox.Show($"Time's up! You did {y} push ups, which is less than {requiredClicks}. You will now return to the main menu.");

                    var newForm = new Form1(); 
                    newForm.Show();
                    this.Hide();
                }
                if (y > requiredClicks) 
                {
                    
                    MessageBox.Show($"Great! You did {y} push ups.");
                }
            }
        }

    }
}
