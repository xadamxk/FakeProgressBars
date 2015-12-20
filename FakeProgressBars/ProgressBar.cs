using System;
using System.Drawing;
using System.Windows.Forms;

namespace FakeProgressBars
{
    public partial class ProgressBar : Form
    {
        private Icon icon = Form1.icon;
        private string caption = Form1.caption;
        private int progress = Form1.progress;
        private bool timer = Form1.timer;
        private int timerCount;

        public ProgressBar()
        {
            InitializeComponent();
            Text = caption;
            Size = new Size(450, 100);
        }
        private void ProgressBar_Load(object sender, EventArgs e)
        {
            
            this.Icon = icon;
            // Set Progress Bar
            if (timer) // Use Timer
            {
                timer1.Enabled = true;
                timer1.Start();
                timer1.Interval = 2000; // Each tick = 1 Second
                progressBar1.Maximum = progress*2; // *2 for 50% initial progress 
                progressBar1.Value = progress;
                timerCount = progress;
                timer1.Tick += (timer1_Tick);
            }
            else // Use Constant Percentage
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Value = progress;
                estimatedTimeLabel.Text = "Estimated Time: Calculating . . .";
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != progress * 2) // *2 for 50% initial progress 
            {
                // Format time left
                progressBar1.Value++;
                timerCount--;
                int hours = timerCount/3600;
                int minutes = (timerCount/60) - (hours*60);
                int seconds = timerCount - (hours*3600) - (minutes*60);
                string time = "";

                if (hours != 0)
                    time += hours + "Hr. ";
                if (minutes != 0)
                    time += minutes + "Min. ";
                if (seconds != 0)
                    time += seconds + "Sec.";

                // Display time left
                estimatedTimeLabel.Text = "Estimated Time: About " + time;
            }
            else
            {
                timer1.Stop();
                estimatedTimeLabel.Text = "Estimated Time: Complete";
                cancelButton.Text = "Close";
            }
        }
    }
}
