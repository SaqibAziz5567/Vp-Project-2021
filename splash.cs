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

namespace VPProject2021
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }
        System.Windows.Forms.Timer tmr;
        private void splash_Shown(object sender, EventArgs e)
        {
            

                tmr = new System.Windows.Forms.Timer();

                //set time interval 4 sec

                tmr.Interval = 6000;

                //starts the timer

                tmr.Start();

                tmr.Tick += tmr_Tick;

            }

            void tmr_Tick(object sender, EventArgs e)

            {

                //after 4 sec stop the timer

                tmr.Stop();

                //display mainform

                Form1 mf = new Form1();

                mf.Show();

                //hide this form

                this.Hide();

            }
        //private void fadeTimer_Tick(object sender, EventArgs e)
        //{
        //    this.Opacity -= 0.01;
        //    if (this.Opacity <= 0)
        //    {
        //        this.Close();
        //    }
            
        //    Form1 mf = new Form1();

        //    mf.Show();

        //    //hide this form

        //    this.Hide();
        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(@"C:\Users\hp\Documents\Visual Studio 2022\VP Project\micdrop.wav");
            sp.Play();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }