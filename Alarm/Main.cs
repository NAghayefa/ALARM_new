using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace Alarm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        SoundPlayer sound = new SoundPlayer("alarm.wav");
        int DelayTime = 0;

        private void btn_stop_Click(object sender, EventArgs e)
        {
            sound.Stop();
            timer2.Stop();
            lbl_time.Text = "Alarm Stoped!";
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lbl_now.Text = DateTime.Now.ToLongTimeString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_now.Text = DateTime.Now.ToLongTimeString();
            if (lbl_now.Text == txtbx_alarm.Text) 
            {
                sound.Play();
                
            }
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
           
                DateTime time = Convert.ToDateTime(txtbx_alarm.Text);   
            
        }

        private void btn_delay_Click(object sender, EventArgs e)
        {
            DelayTime = 60;
            timer2.Enabled = true;
            lbl_time.Text = "Alarm delayed for 1 minute";
            sound.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            while(DelayTime==0)
            {
                sound.Play();
                timer1.Enabled = true;
                timer2.Enabled = false;
                lbl_time.Text = "It's time!";
                
                return;
            }
            DelayTime--;
        }

        private void txtbx_alarm_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }
    }
}
