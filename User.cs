using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPProject2021
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        int i = 0;

        private void User_Load(object sender, EventArgs e)
        {
            panel8.Hide();
            panel4.Hide();
            panel1.Hide();

            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();

            pictureBox1.Image = Image.FromFile("C:\\Users\\hp\\Documents\\Visual Studio 2022\\VP Project\\Movies" + "\\image" + 1 + ".jpg");
        pictureBox2.Hide();
            pictureBox3.Hide();
        }
        int num = System.IO.Directory.EnumerateFiles("C:\\Users\\hp\\Documents\\Visual Studio 2022\\VP Project\\Movies").Count();
        int imageNum=0;
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % (num + 1);
            if (imageNum == 0)
            {
                imageNum = 1;
            }
            string fileName = @"C:\\Users\\hp\\Documents\\Visual Studio 2022\\VP Project\\Movies" + "\\image" + imageNum + ".jpg";

            if (File.Exists(fileName))
            {
            if (imageNum <= num)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\hp\\Documents\\Visual Studio 2022\\VP Project\\Movies" + "\\image" + imageNum + ".jpg");

                }
           }
            else
            {
                imageNum++;
            }
                

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            imageNum--;
            if (imageNum ==0)
            {
                imageNum = num;
            }
            pictureBox1.Image = Image.FromFile("C:\\Users\\hp\\Documents\\Visual Studio 2022\\VP Project\\Movies" + "\\image" + imageNum + ".jpg");

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox2.Show();
            pictureBox3.Show();
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
        }

        private void User_MouseHover(object sender, EventArgs e)
        {
            panel1.Hide();
            panel4.Hide();
            panel2.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            imageNum = (imageNum + 1) % (num + 1);
            if (imageNum == 0)
            {
                imageNum = 1;
            }
            
                if (imageNum <= num)
                {
                    pictureBox1.Image = Image.FromFile("C:\\Users\\hp\\Documents\\Visual Studio 2022\\VP Project\\Movies" + "\\image" + imageNum + ".jpg");

                }
           
            else
            {
                imageNum++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Hide();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Red;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Red;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Red;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }

        private void panel4_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            panel4.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            panel1.Hide();
            panel4.Hide();
            panel2.Hide();
            panel5.Hide();
            panel6.Hide();
            panel7.Hide();

        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            panel4.Hide();
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void pictureBox11_MouseHover(object sender, EventArgs e)
        {
            panel6.Show();
        }

        private void pictureBox14_MouseHover(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_MouseHover_1(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Red;
        }

        private void label10_MouseLeave_1(object sender, EventArgs e)
        {
            label10.ForeColor = Color.White;
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            label11.ForeColor = Color.Red;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = Color.White;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Red;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            label12.ForeColor = Color.Red;
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            label13.ForeColor = Color.Red;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = Color.White;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = Color.White;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Red;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            label14.ForeColor = Color.Red;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = Color.White;
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            label15.ForeColor = Color.Red;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = Color.White;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Red;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.White;
        }

        private void label16_MouseHover(object sender, EventArgs e)
        {
            label16.ForeColor = Color.Red;
        }

        private void label17_MouseHover(object sender, EventArgs e)
        {
            label17.ForeColor = Color.Red;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = Color.White;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = Color.White;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.ForeColor = Color.Red;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.ForeColor = Color.White;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_MouseHover(object sender, EventArgs e)
        {
            label18.ForeColor = Color.Red;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.White;
        }

        private void label19_MouseHover(object sender, EventArgs e)
        {
            label19.ForeColor = Color.Red;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = Color.White;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.ForeColor = Color.Red;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.ForeColor = Color.White;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.White;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            panel8.Show();
            timer3.Start();
            i++;
            


        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (i==1)
            {
                timer2.Stop();
                panel8.Hide();
                i--;
                timer2.Start();
            }
            
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_MouseHover(object sender, EventArgs e)
        {
            panel14.Show();
        }

        private void pictureBox20_MouseHover(object sender, EventArgs e)
        {
            panel13.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_MouseHover(object sender, EventArgs e)
        {
            panel12.Show();
        }

        private void pictureBox18_MouseHover(object sender, EventArgs e)
        {
            panel11.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            panel10.Show();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_MouseHover(object sender, EventArgs e)
        {
            panel9.Show();
        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel14.Hide();

        }

        private void label30_MouseHover(object sender, EventArgs e)
        {
            label30.ForeColor = Color.Red;
        }

        private void label30_MouseLeave(object sender, EventArgs e)
        {
            label30.ForeColor = Color.White;
        }

        private void label31_MouseHover(object sender, EventArgs e)
        {
            label31.ForeColor = Color.Red;
        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            label31.ForeColor = Color.White;
        }

        private void button14_MouseHover(object sender, EventArgs e)
        {
            button14.ForeColor = Color.Red;
        }

        private void button14_MouseLeave(object sender, EventArgs e)
        {
            button14.ForeColor = Color.White;
        }

        private void label28_MouseHover(object sender, EventArgs e)
        {
            label28.ForeColor = Color.Red;
        }

        private void label28_MouseLeave(object sender, EventArgs e)
        {
            label28.ForeColor = Color.White;
        }

        private void label29_MouseHover(object sender, EventArgs e)
        {
            label29.ForeColor = Color.Red;
        }

        private void label29_MouseLeave(object sender, EventArgs e)
        {
            label29.ForeColor = Color.White;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.ForeColor = Color.Red;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.ForeColor = Color.White;
        }

        private void label26_MouseHover(object sender, EventArgs e)
        {
            label26.ForeColor = Color.Red;
        }

        private void label26_MouseLeave(object sender, EventArgs e)
        {
            label26.ForeColor = Color.White;
        }

        private void label27_MouseHover(object sender, EventArgs e)
        {
            label27.ForeColor = Color.Red;
        }

        private void label27_MouseLeave(object sender, EventArgs e)
        {
            label27.ForeColor = Color.White;
        }

        private void button10_MouseHover(object sender, EventArgs e)
        {
            button10.ForeColor = Color.Red;
        }

        private void button10_MouseLeave(object sender, EventArgs e)
        {
            button10.ForeColor = Color.White;
        }

        private void label24_MouseHover(object sender, EventArgs e)
        {
            label24.ForeColor = Color.Red;
        }

        private void label24_MouseLeave(object sender, EventArgs e)
        {
            label24.ForeColor = Color.White;
        }

        private void label25_MouseHover(object sender, EventArgs e)
        {
            label25.ForeColor = Color.Red;
        }

        private void label25_MouseLeave(object sender, EventArgs e)
        {
            label25.ForeColor = Color.White;
        }

        private void button11_MouseHover(object sender, EventArgs e)
        {
            button11.ForeColor = Color.Red;
        }

        private void button11_MouseLeave(object sender, EventArgs e)
        {
            button11.ForeColor = Color.White;
        }

        private void label22_MouseHover(object sender, EventArgs e)
        {
            label22.ForeColor = Color.Red;
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.ForeColor = Color.White;
        }

        private void label23_MouseHover(object sender, EventArgs e)
        {
            label23.ForeColor = Color.Red;
        }

        private void label23_MouseLeave(object sender, EventArgs e)
        {
            label23.ForeColor = Color.White;
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.ForeColor = Color.Red;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.ForeColor = Color.White;
        }

        private void label20_MouseHover(object sender, EventArgs e)
        {
            label20.ForeColor = Color.Red;
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            label20.ForeColor = Color.White;
        }

        private void label21_MouseHover(object sender, EventArgs e)
        {
            label21.ForeColor = Color.Red;
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.ForeColor = Color.White;
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            button13.ForeColor = Color.Red;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            button13.ForeColor = Color.White;
        }

        private void panel14_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel13_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel12_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void panel14_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel13_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel12_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }
    }
}
