using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Countdown
{
    public partial class CountdownWindow : Form
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public int TotalTimeSeconds { get; set; }

        private System.Timers.Timer timer; 

        public CountdownWindow()
        {
            InitializeComponent();

            
        }

        private void Coundown_Load(object sender, EventArgs e)
        {
            
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(duration_txt.Text) && !this.durationValid_lbl.Visible)
            {
                timer.Stop();
                this.timer = new System.Timers.Timer((double)TotalTimeSeconds);
                timer.Start();
            }
            
        }

        private void restart_btn_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Interval = (TotalTimeSeconds * 100);
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }


        private void duration_txt_Leave(object sender, EventArgs e)
        {
            string rawText = this.duration_txt.Text;
            this.durationValid_lbl.Visible = false;

            try
            {
                string[] durations = rawText.Split(':');
                this.Hours = int.Parse(durations[0]);
                this.Minutes = int.Parse(durations[1]);
                this.Seconds = int.Parse(durations[2]);
                TotalTimeSeconds = ((Hours * 60) * 60) + (Minutes * 60) + Seconds;
                this.timeLeft_lbl.Text = string.Format($"{Hours}:{Minutes}:{Seconds}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex}");
                this.durationValid_lbl.Visible = true;
            }
        }

        private void format_txt_Leave(object sender, EventArgs e)
        {

        }
    }
}
