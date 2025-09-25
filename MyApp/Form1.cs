using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k = 0, l = 0, z = 0, u = 0, m = 0, n = 0;

        private void timer3_Tick(object sender, EventArgs e)
        {
            k = pictureBox4.Left;
            l = pictureBox4.Top;
            z = pictureBox5.Left;
            u = pictureBox5.Top;
            m = pictureBox6.Left;
            n = pictureBox6.Top;
            if (q == 0)
            {
                x = pictureBox3.Left;
                q++;
            }

            pictureBox3.Left -= 1;
            for (int j = 0; j < 30; j++)
            {

                if (pictureBox3.Location == new Point(k, l - j))
                {
                    pictureBox4.Visible = false;
                }
                if (pictureBox3.Location == new Point(z, u - j))
                {
                    pictureBox5.Visible = false;
                }
                if (pictureBox3.Location == new Point(m, n - j))
                {
                    pictureBox6.Visible = false;
                }
            }
            for (int j = 0; j < 30; j++)
            {

                if (pictureBox3.Location == new Point(k, l + j))
                {
                    pictureBox4.Visible = false;
                }
                if (pictureBox3.Location == new Point(z, u + j))
                {
                    pictureBox5.Visible = false;
                }
                if (pictureBox3.Location == new Point(m, n + j))
                {
                    pictureBox6.Visible = false;
                }
            }
            if (pictureBox3.Left == x-210)
            {
                if(pictureBox3.Top==320)
                {
                    timer3.Enabled = false;
                    timer4.Enabled = true;
                    q--;
                }
                if (pictureBox3.Top != 320)
                {
                    timer3.Enabled = false;
                    timer2.Enabled = true;
                    q--;
                }
                

            }
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            if(pictureBox3.Top!=100)
            {
                pictureBox3.Top -= 1;
                if(pictureBox3.Top==320)
                {
                    timer4.Enabled = false;
                    timer8.Enabled = true;
                }
            }
            if (pictureBox3.Left != 265)
            {
                pictureBox3.Left += 1;
            }
            if(pictureBox3.Left == 265)
            {
                timer4.Enabled = false;
                timer1.Enabled = true;
            }
            
            
        }
        
      

        private void pictureBox4_VisibleChanged(object sender, EventArgs e)
        {
            if (pictureBox4.Visible == false)
            {
                if (pictureBox4.Left < 221)
                {
                    progressBar1.Value += 33;
                }
                if (pictureBox4.Left > 221)
                {
                    progressBar2.Value += 33;
                }
                int v1 = progressBar1.Value, v2 = progressBar2.Value;

                label3.Text = "Part A is " + Convert.ToString(v1) + "% clean" + "\nPart B is " + Convert.ToString(v2) + "% clean";
            }
        }

        private void pictureBox6_VisibleChanged(object sender, EventArgs e)
        {
            if (pictureBox6.Visible == false)
            {
                if (pictureBox6.Left < 221)
                {
                    progressBar1.Value += 33;
                }
                if (pictureBox6.Left > 221)
                {
                    progressBar2.Value += 33;
                }
                int v1 = progressBar1.Value, v2 = progressBar2.Value;

                label3.Text = "Part A is " + Convert.ToString(v1) + "% clean" + "\nPart B is " + Convert.ToString(v2) + "% clean";
            }
        }

        private void pictureBox5_VisibleChanged(object sender, EventArgs e)
        {
            if (pictureBox5.Visible == false)
            {
                if (pictureBox5.Left < 221)
                {
                    progressBar1.Value += 33;
                }
                if (pictureBox5.Left > 221)
                {
                    progressBar2.Value += 33;
                }
                int v1 = progressBar1.Value, v2 = progressBar2.Value;

                label3.Text = "Part A is " + Convert.ToString(v1) + "% clean" + "\nPart B is " + Convert.ToString(v2) + "% clean";
            }
        }
        bool T=true;
        private void timer5_Tick(object sender, EventArgs e)
        {
            
            
            label8.Visible = true;
            label6.Visible = true;
            if (T==true)
            {
                label6.ForeColor = Color.White;
                label3.Text = "Scannig.";
                ++q;
                           
            }
            
            if(T==true)
            {
                T = false;
            }
            if (q == 0)
            {
                label6.ForeColor = Color.Lime;
                label3.Text = "Scannig...";
                T = true;
            }
            if(T==false)
            {
                q--;
            }
            



        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if(w==0)
            {
                label8.Top++;
                if (label8.Top == 350)
                {
                    ++w;
                }
            }
            
            if (w == 1)
            {
                label8.Top--;
                if (label8.Top == 99 && label8.Left==10)
                {
                    w = 0;
                    timer6.Enabled = true;
                    label8.Left = 265;
                    label6.Left = 266;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = true;

                }
                if (label8.Top == 100 && label8.Left == 265)
                {
                    label8.Visible = false;
                    pictureBox9.Visible = false;
                    label6.Visible = false;
                    timer5.Enabled = false;
                    timer6.Enabled = false;
                    label3.Text = label+"\nScanned.";
                    timer7.Enabled = true;
                }

            }
        }

        int q = 0, x = 0,w=0;

        private void timer9_Tick(object sender, EventArgs e)
        {
            
            if (pictureBox3.Location == new Point(10, 100))
            {
                
                if (progressBar3.Value < 100)
                {
                    progressBar3.Value += 2;
                }
            }
            else
            {
                progressBar3.Value-=2;
                
            }
        }

        private void pictureBox3_Move(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_LocationChanged(object sender, EventArgs e)
        {
            timer9.Enabled = true;
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            if (pictureBox3.Left != 10)
            {
                pictureBox3.Left--;
            }
            if (pictureBox3.Top != 100)
            {
                pictureBox3.Top--;
            }
            if(pictureBox3.Location==new Point(10,100))
            {
                timer8.Enabled = false;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            

            k = pictureBox4.Left;
            l = pictureBox4.Top;
            z = pictureBox5.Left;
            u = pictureBox5.Top;
            m = pictureBox6.Left;
            n = pictureBox6.Top;
            if(pictureBox3.Left<265)
            {
                label3.Text = "cleaning part A";
            }
            if (pictureBox3.Left > 265)
            {
                label3.Text = "cleaning part B";
            }
            if (pictureBox3.Location==pictureBox4.Location)
            {
                pictureBox4.Visible = false;
            }
            if (pictureBox3.Location == pictureBox5.Location)
            {
                pictureBox5.Visible = false;
            }
            if (pictureBox3.Location == pictureBox6.Location)
            {
                pictureBox6.Visible = false;
            }
            if(q==0)
            {
                if (pictureBox3.Left > k)
                {
                    pictureBox3.Left--;
                }
                if (pictureBox3.Left < k)
                {
                    pictureBox3.Left++;
                }
                if (pictureBox3.Top > l)
                {
                    pictureBox3.Top--;
                }
                if (pictureBox3.Top < l)
                {
                    pictureBox3.Top++;
                }
                if(pictureBox4.Visible==false)
                {
                    q++;
                }
            }
            if (q == 1)
            {
                if (pictureBox3.Left > z)
                {
                    pictureBox3.Left--;
                }
                if (pictureBox3.Left < z)
                {
                    pictureBox3.Left++;
                }
                if (pictureBox3.Top > u)
                {
                    pictureBox3.Top--;
                }
                if (pictureBox3.Top < u)
                {
                    pictureBox3.Top++;
                }
                if (pictureBox5.Visible == false)
                {
                    q++;
                }
            }
            if (q == 2)
            {
                if (pictureBox3.Left > m)
                {
                    pictureBox3.Left--;
                }
                if (pictureBox3.Left < m)
                {
                    pictureBox3.Left++;
                }
                if (pictureBox3.Top > n)
                {
                    pictureBox3.Top--;
                }
                if (pictureBox3.Top < n)
                {
                    pictureBox3.Top++;
                }
                if (pictureBox6.Visible == false)
                {
                    q=q-2;
                    timer7.Enabled = false;
                    timer8.Enabled = true;
                }
            }

        }

        string label;

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(q==0)
            {
                x = pictureBox3.Top;
                q++;
            }
            
                pictureBox3.Top += 1;
            if (pictureBox3.Top == x + 44)
            {
                timer2.Enabled = false;
                if(pictureBox3.Left==220 || pictureBox3.Left == 475)
                {
                    timer3.Enabled = true;
                    q--;
                }
                if (pictureBox3.Left == 10 || pictureBox3.Left == 265)
                {
                    timer1.Enabled = true;
                    q--;
                }

                
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            k = pictureBox4.Left;
            l = pictureBox4.Top;
            z = pictureBox5.Left;
            u = pictureBox5.Top;
            m = pictureBox6.Left;
            n = pictureBox6.Top;
            if (q == 0)
            {
                x = pictureBox3.Left;
                q++;
            }

            pictureBox3.Left += 1;
            for (int j = 0; j <30; j++)
            {

                if (pictureBox3.Location == new Point(k, l-j))
                {
                    pictureBox4.Visible = false;
                }
                if (pictureBox3.Location == new Point(z, u - j))
                {
                    pictureBox5.Visible = false;
                }
                if (pictureBox3.Location == new Point(m, n - j))
                {
                    pictureBox6.Visible = false;
                }
            }
            for (int j = 0; j < 30; j++)
            {

                if (pictureBox3.Location == new Point(k, l + j))
                {
                    pictureBox4.Visible = false;
                }
                if (pictureBox3.Location == new Point(z, u + j))
                {
                    pictureBox5.Visible = false;
                }
                if (pictureBox3.Location == new Point(m, n + j))
                {
                    pictureBox6.Visible = false;
                }
            }
            if (pictureBox3.Left==x+210)
            {
                timer1.Enabled = false;
                timer2.Enabled = true;
                q--;
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Location = new Point(10, 100);
            pictureBox3.Location = new Point(10, 100);
            timer9.Enabled = true;
            if(radioButton1.Checked==true)
            {
                timer1.Enabled = true;
            }
            if (radioButton2.Checked == true)
            {
                timer5.Enabled = true;
                timer6.Enabled = true;
                pictureBox8.Visible = true;
                label = label3.Text;
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 100;
            progressBar2.Value = 100;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            Random rnd = new Random();
            do
            {
                for (int i = 0; i < 6; i++)
                {
                    k = rnd.Next(10, 470);
                    l = rnd.Next(101, 320);
                    z = rnd.Next(10, 470);
                    u = rnd.Next(101, 320);
                    m = rnd.Next(10, 470);
                    n = rnd.Next(101, 320);
                }
                pictureBox4.Location = new Point(k, l);
                pictureBox5.Location = new Point(z, u);
                pictureBox6.Location = new Point(m, n);
            } while ((k >220 && k<265)|| (z > 220 && z < 265)|| (m > 220 && m < 265));
            if (pictureBox4.Left < 221)
            {
                progressBar1.Value -= 33;
            }
            if (pictureBox5.Left < 221)
            {
                progressBar1.Value -= 33;
            }
            if (pictureBox6.Left < 221)
            {
                progressBar1.Value -= 33;
            }
            if (pictureBox4.Left > 221)
            {
                progressBar2.Value -= 33;
            }
            if (pictureBox5.Left > 221)
            {
                progressBar2.Value -= 33;
            }
            if (pictureBox6.Left > 221)
            {
                progressBar2.Value -= 33;
            }
            int v1=progressBar1.Value, v2 = progressBar2.Value;

            label3.Text = "Part A is "+Convert.ToString(v1)+"% clean"+"\nPart B is " + Convert.ToString(v2) + "% clean";

               
        }
    }
}
