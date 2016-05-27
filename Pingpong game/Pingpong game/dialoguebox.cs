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
    public partial class dialoguebox : Form
    {
        string time;
        public dialoguebox(string Time)
        {
            InitializeComponent();
            time = Time;
        }

       

        private void replay_button_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void dialoguebox_Load(object sender, EventArgs e)
        {
            labeltime.Text = "Your Time : " + time;
            System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(@"c:\bse5\n.wav");
            simpleSound.Play();
        }
    }
}
