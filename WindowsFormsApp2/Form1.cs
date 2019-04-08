using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sekunde = 0;
        int vrijemeSekunde = 0;
        int vrijemeMinute = 0;
        string vremena="";

        private void timer1_Tick(object sender, EventArgs e)
        {
            sekunde++;
            vrijemeSekunde = sekunde % 60;
            vrijemeMinute = sekunde / 60;
            oiMinute.Text = vrijemeMinute.ToString();
            oiSekunde.Text = vrijemeSekunde.ToString();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sekunde = 0;
            oiMinute.Text = "0";
            oiSekunde.Text = "0";
            timer1.Start();

        }

        private void btnLap_Click(object sender, EventArgs e)
        {
            vremena += vrijemeMinute + " : " + vrijemeSekunde + "\r\n";
            oiVremena.Text = vremena;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
