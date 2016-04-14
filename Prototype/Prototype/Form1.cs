using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Welcome_form : Form
    {
        public Welcome_form()
        {
            InitializeComponent();
        }

        private void play_btn_Click(object sender, EventArgs e)
        {
            Gameform obj = new Gameform();
            obj.Show();
            this.Hide();
        }

        private void settings_btn_Click(object sender, EventArgs e)
        {
            Settings_form obj1 = new Settings_form();
            obj1.Show();
            this.Hide();
        }
    }
}
