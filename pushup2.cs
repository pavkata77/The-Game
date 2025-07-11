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
    public partial class pushup2 : Form
    {
        public pushup2()
        {
            InitializeComponent();
        }
        private int x;
        private int y;
        private List<Image> backgroundImages;
        private int imageIndex = 0;
        private const int requiredClicks = 50;
        private const int totalSeconds = 25;
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

            if (y >= requiredClicks)
            {
                countdownTimer.Stop();
                MessageBox.Show($"Great! You did {y} push ups.");
                this.Hide();
                day3aftertrain day3Aftertrain = new day3aftertrain();
                day3Aftertrain.Show();  
            }
        }

        private void pushupexample_Load(object sender, EventArgs e)
        {
            backgroundImages = new List<Image>
            {
                Properties.Resources.exercise_18_1000x,
                Properties.Resources.exercise_18_1000x__1_


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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
