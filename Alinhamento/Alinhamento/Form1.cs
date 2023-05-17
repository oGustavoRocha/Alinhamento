using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alinhamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void cima_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
           // if (button5.Top > 0)
           // button5.Top -= 10;
        }

        private void esquerda_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = true;
            //if (button5.Left > 0)
            //button5.Left -= 10;
        }

        private void baixo_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            //if (button5.Top < this.Height - 180)
            //button5.Top += 10;
        }

        private void direita_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            timer3.Enabled = true;
            timer4.Enabled = false;
            // if(button5.Left < this.Width - 205)
            //button5.Left += 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button5.Top > 0)
            button5.Top -= 10;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (button5.Top < this.Height - 180)
            button5.Top += 10;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (button5.Left < this.Width - 205)
                button5.Left += 10;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (button5.Left > 0)
                button5.Left -= 10;
        }

        private void stop_Click_1(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            timer1.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                timer2.Enabled = true;
                timer1.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
            }

            if (e.KeyCode == Keys.A)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = true;
            }

            if (e.KeyCode == Keys.D)
            {
                timer2.Enabled = false;
                timer1.Enabled = false;
                timer3.Enabled = true;
                timer4.Enabled = false;
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) {
                timer2.Enabled = false;
                timer1.Enabled = true;
                timer3.Enabled = false;
                timer4.Enabled = false;
            }
        }
    }
}
