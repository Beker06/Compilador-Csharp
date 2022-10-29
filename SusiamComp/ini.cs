using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SusiamComp
{
    public partial class ini : Form
    {
        public ini()
        {
            InitializeComponent();
            tm1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tm1_Tick(object sender, EventArgs e)
        {
            panel2.Width = panel2.Width + 3;

            if (panel2.Width >= 630)
            {
                tm1.Stop();
                ide id = new ide();
                id.Show();
                this.Hide();
            }
        }
    }
}
