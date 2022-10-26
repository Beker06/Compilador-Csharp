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
        int total = 0;

        public ini()
        {
            InitializeComponent();
        }

        private void ini_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressBar1.Step = 5;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = progressBar1.Minimum;

            total = total + 1;
            if (total == 2 && i < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                label1.Text = "Cargando complementos.";
            }

            if (total == 3 && i < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                label1.Text = "Cargando complementos..";
            }

            if (total == 4 && i < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                progressBar1.PerformStep();
                label1.Text = "Cargando complementos...";
            }

            if (total == 5 && i < progressBar1.Maximum)
            {
                label1.Text = "Sistema cargado";

                for (int isf = i; isf < progressBar1.Maximum; isf = isf + progressBar1.Step)
                {
                    progressBar1.PerformStep();
                    label1.Text = "Sistema cargado";
                }
            }

            if (total == 6)
            {
                ide id = new ide();
                this.Hide();

                id.Show();
            }
        }
    }
}
