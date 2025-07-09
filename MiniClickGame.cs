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
    public partial class MiniClickGame : Form
    {
        private Rectangle greenZone;
        private int successCount = 0;
        private bool isGameActive = false;

        private Timer arrowTimer;
        private int arrowX = 50;
        private int arrowSpeed = 5;
        private bool movingRight = true;

        private Random rand = new Random();
        public MiniClickGame()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Width = 800;
            this.Height = 300;
            this.Text = "Green Zone Click Game";
            this.KeyPreview = true;

            this.Paint += GameForm_Paint;
            this.KeyDown += GameForm_KeyDown;

            arrowTimer = new Timer();
            arrowTimer.Interval = 16; // ~60 FPS
            arrowTimer.Tick += ArrowTimer_Tick;

            StartGame();
        }

        private void StartGame()
        {
            successCount = 0;
            isGameActive = true;
            CreateNewZone();
            arrowX = 50;
            movingRight = true;
            arrowTimer.Start();
            Invalidate(); // Redraw
        }

        private void CreateNewZone()
        {
            int lineY = this.ClientSize.Height / 2;
            int zoneWidth = 100;
            int x = rand.Next(50, this.ClientSize.Width - 50 - zoneWidth);
            greenZone = new Rectangle(x, lineY - 10, zoneWidth, 20);
        }

        private void ArrowTimer_Tick(object sender, EventArgs e)
        {
            int minX = 50;
            int maxX = this.ClientSize.Width - 50;

            if (movingRight)
            {
                arrowX += arrowSpeed;
                if (arrowX >= maxX)
                    movingRight = false;
            }
            else
            {
                arrowX -= arrowSpeed;
                if (arrowX <= minX)
                    movingRight = true;
            }

            Invalidate(); // Redraw the form
        }

        private void GameForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Draw horizontal line
            int lineY = this.ClientSize.Height / 2;
            g.DrawLine(Pens.Black, 50, lineY, this.ClientSize.Width - 50, lineY);

            // Draw green zone
            if (isGameActive)
                g.FillRectangle(Brushes.Green, greenZone);

            // Draw red arrow
            DrawArrow(g, arrowX, lineY - 40);

            // Optional: Draw score
            using (Font font = new Font("Arial", 12))
            {
                g.DrawString($"Score: {successCount}/10", font, Brushes.Black, 10, 10);
            }
        }

        private void DrawArrow(Graphics g, int x, int y)
        {
            // Draw a red triangle pointing down
            Point[] triangle = new Point[]
            {
            new Point(x, y),          // tip
            new Point(x - 10, y + 20),
            new Point(x + 10, y + 20)
            };

            g.FillPolygon(Brushes.Red, triangle);
        }

        private void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameActive) return;

            if (e.KeyCode == Keys.Space)
            {
                Rectangle arrowRect = new Rectangle(arrowX - 1, greenZone.Y, 2, greenZone.Height);
                if (greenZone.IntersectsWith(arrowRect))
                {
                    successCount++;
                    if (successCount >= 10)
                    {
                        arrowTimer.Stop();
                        MessageBox.Show("You did 10 reps! Now you will continue.");
                        this.Hide();
                        day2workout_finished day2Workout_Finished = new day2workout_finished();
                        day2Workout_Finished.Show();
                    }
                    else
                    {
                        CreateNewZone();
                        Invalidate();
                    }
                }
                else
                {
                    arrowTimer.Stop();
                    MessageBox.Show("You missed! Game over.");
                    this.Hide();
                    Form1 form1 = new Form1();  
                    form1.Show();
                }
            }
        }

        private void ShowMainMenu()
        {
            
        }

        

        private void MiniClickGame_Load(object sender, EventArgs e)
        {

        }
    }
}
