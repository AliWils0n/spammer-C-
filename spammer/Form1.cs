using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class spammer : Form
    {
        public spammer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop(); // stop
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString(); // show speed to you  
            timer1.Interval = trackBar1.Value;// change speed of massages to timer and timer send your massage on line 43
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();// start 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);// your massage 
            SendKeys.Send("{Enter}");// Sender 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/users/522498622265360395"); //my discord profile link 

        }
    }
}
