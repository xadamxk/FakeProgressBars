using System;
using System.Drawing;
using System.Windows.Forms;
/* Description: Creates. customized fake progress bars
 * Uses: Ever wanted to slack off at school or work for a bit and blame it on your computer?
 * 
 * Made this tool (toy) based on a similar program for Macs - http://osxdaily.com/2014/05/09/fake-progress-bar-app-mac-corporate-avoidance/
 * Icon: http://findicons.com/icon/492689/progress_bar_info?id=512104
 */

namespace FakeProgressBars
{
    public partial class Form1 : Form
    {
        private string timeEquivalent = "";


        public static string caption = "";
        public static int progress = 0;
        public static bool timer = true;
        public static Icon icon;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set Defaults
                // Disable Custom Checkbox
                customCaptionTextBox.Enabled = false;
                // Enable Timer
                timerRadioButton.Checked = true;
                // Timer Label
                timerRadioButton.Text = "Timer (1 min.)";
                // Percentage NumericUpDown
                percentNumericUpDown.Value = 10;
                // Caption ComboBox Index
                captionComboBox.SelectedIndex = 3;
        }

        private void timerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // When Timer Clicked
            radioValuesChanged();
        }

        private void percentageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // When Percentage Clicked
            radioValuesChanged();
        }

        private void radioValuesChanged()
        {
            if (timerRadioButton.Checked) // Timer Checked
            {
                timerTrackbar.Enabled = true;
                percentNumericUpDown.Enabled = false;
            }

            else if (percentageRadioButton.Checked) // Percentage Checked
            {
                timerTrackbar.Enabled = false;
                percentNumericUpDown.Enabled = true;
            }

        }

        private void customCaptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customCaptionCheckBox.Checked) // Custom Caption Checked
            {
                customCaptionTextBox.Enabled = true;
            }
            else if (!customCaptionCheckBox.Checked)
            {
                customCaptionTextBox.Enabled = false;
            }
        }

        private void timerTrackbar_Scroll(object sender, EventArgs e)
        {
            int currentInterval = timerTrackbar.Value;
            // Convert 1-6 to appropriate values
            switch (currentInterval)
            {
                case 1:
                    timeEquivalent = "1";
                    break;
                case 2:
                    timeEquivalent = "5";
                    break;
                case 3:
                    timeEquivalent = "10";
                    break;
                case 4:
                    timeEquivalent = "30";
                    break;
                case 5:
                    timeEquivalent = "60";
                    break;
                case 6:
                    timeEquivalent = "90";
                    break;
            }
            toolTip1.SetToolTip(timerTrackbar, timeEquivalent + " Min");
        }

        private void timerTrackbar_ValueChanged(object sender, EventArgs e)
        {
            timerRadioButton.Text = "Timer (" + timeEquivalent + " min.)";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // Caption
                // Default Caption
                if (!customCaptionCheckBox.Checked) 
                    caption = captionComboBox.Text;
                // Custom Caption
                else
                    caption = customCaptionTextBox.Text;

            // Progress
                // Default Progress (Timer)
                if (timerRadioButton.Checked)
                {
                    switch (timerTrackbar.Value)
                    {
                        case 1:
                            progress = 1*60;
                            break;
                        case 2:
                            progress = 5*60;
                            break;
                        case 3:
                            progress = 10*60;
                            break;
                        case 4:
                            progress = 30*60;
                            break;
                        case 5:
                            progress = 60*60;
                            break;
                        case 6:
                            progress = 90*60;
                            break;
                    }
                    timer = true;
                }
                // Custom Progress (Percentage)
                else
                {
                    progress = Int32.Parse(percentNumericUpDown.Text);
                    timer = false;
                }

            // Close current, open progress bar form
            this.Hide();
            ProgressBar create = new ProgressBar();
            create.Closed += (s, args) => this.Close();
            create.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "";
            // Select file
            DialogResult confirm = openFileDialog1.ShowDialog();
            if (confirm == DialogResult.OK)
            {
                try
                {
                    file = openFileDialog1.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error! File Name invalid.");
                }

                // Grab icon from file
                icon = Icon.ExtractAssociatedIcon(file);

                // Preview selected icon (Credit: http://stackoverflow.com/questions/15782857/displaying-an-icon-in-a-picturebox)
                iconPictureBox.Image = Bitmap.FromHicon(new Icon(icon, new Size(48, 48)).Handle);
            }
        }

        
    }
}
