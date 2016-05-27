using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pingpong_game
{
    public partial class looser : Form
    {
        string time;

        public looser(string Time)
        {
            InitializeComponent();
            time = Time;      
        }

        

        private void looser_Load(object sender, EventArgs e)
        {
            labelTime.Text ="Your Time : " + time;
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"c:\bse5\l.wav");
            simpleSound.Play();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PingPong ob = new PingPong();
            ob.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void cancel_picture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
