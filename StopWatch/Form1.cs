using System;
using System.IO;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Timer timer1;   // timer declaration

        int hours = 0, minutes = 0, seconds = 0; // time variables

        public Form1()    // constructor -- creates timer---run timer event every 1000ms = 1 s.
        {
            InitializeComponent();

            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
        }

        // Timer runs every second
        private void timer1_Tick(object sender, EventArgs e)  //timer logic
        {
            seconds++;

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
            }

            if (minutes == 60)
            {
                minutes = 0;
                hours++;
            }

            txtHours.Text = hours.ToString("D2");   //UI update
            txtMinutes.Text = minutes.ToString("D2");    // format specifier - show 2 digits
            txtSeconds.Text = seconds.ToString("D2");
        }

        // START button
        private void btnStart_Click(object sender, EventArgs e)  // event event in WinForms uses this pattern
        {
            timer1.Start();
        }
        // STOP button
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // SAVE button
        private void btnSave_Click(object sender, EventArgs e)
        {
            string time = $"{txtHours.Text}:{txtMinutes.Text}:{txtSeconds.Text}";

            File.AppendAllText("times.txt", time + Environment.NewLine);

            MessageBox.Show("Time saved!");   // shows popup 
        }
    }
}