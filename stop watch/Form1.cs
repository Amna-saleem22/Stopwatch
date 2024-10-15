using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stop_watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hrs_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int msec = Convert.ToInt32(minsec.Text);
            int secs = Convert.ToInt32(sec.Text);
            int min = Convert.ToInt32(mins.Text);
            int hr = Convert.ToInt32(hrs.Text);

            msec = msec + 1;
            minsec.Text = msec.ToString();
            if (msec >= 60)
            {
                minsec.Text = "00";
                secs = secs + 1;
                sec.Text = secs.ToString();

            }

            else if (secs >= 60)
            {
                sec.Text = "00";
                min = min + 1;
                mins.Text = mins.ToString();

            }
            else if (min >= 60)
            {
                mins.Text = "00";
                hr = hr + 1;
                hrs.Text = hrs.ToString();




            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            minsec.Text = "00";
            sec.Text = "00";
            mins.Text = "00";
            hrs.Text = "00";
            timer1.Enabled = false;
        }
    }
}
