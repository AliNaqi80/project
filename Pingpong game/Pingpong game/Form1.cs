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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void play_label_MouseClick(object sender, MouseEventArgs e)
        {
            PingPong obj = new PingPong();
            obj.Show();
            this.Hide();
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
