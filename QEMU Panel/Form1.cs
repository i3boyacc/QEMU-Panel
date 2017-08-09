using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;



namespace QEMU_Panel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int num = 0, isblack = 0, selected = 0;
        int r = 12, g = 81, b = 184;
        public easymode em;
        public version ver;
        public help hlp;
        
        public void Form1_Load(object sender, EventArgs e)
        {
            em = new easymode();
            ver = new version();
            hlp = new help();
            em.Show();
            ver.Show();
            hlp.Show();
            
            panel3.Controls.Add(em);
            panel3.Controls.Add(ver);
            panel3.Controls.Add(hlp);//在右侧面板加载启动模拟器、帮助、版本控件

            ver.Visible = false;
            hlp.Visible = false;
            int em_h = em.Height;
            panel3.AutoScrollMinSize = new Size(10, em_h);
            
            
            r = Settings1.Default.color_r;
            g = Settings1.Default.color_g;
            b = Settings1.Default.color_b;
            if(Settings1.Default.isblack==0)//设置默认颜色，白色或黑色
            {
                color_white.Checked = true;
                this.BackColor = Color.White;
                panel1.ForeColor = Color.Black;
                panel1.BackColor = SystemColors.Menu;
                em.BackColor = Color.White;
                em.ForeColor = Color.Black;
                hlp.BackColor = Color.White;
                hlp.ForeColor = Color.Black;
                ver.BackColor = Color.White;
                ver.ForeColor = Color.Black;
                isblack = 0;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
            }
            else
            {
                color_black.Checked = true;
                this.BackColor = Color.FromArgb(255, 32, 32, 32);
                panel1.ForeColor = Color.FromArgb(255, 222, 222, 222);
                panel1.BackColor = Color.FromArgb(255, 48, 48, 48);
                em.BackColor = Color.FromArgb(255, 32, 32, 32);
                em.ForeColor = Color.FromArgb(255, 222, 222, 222);
                hlp.BackColor = Color.FromArgb(255, 32, 32, 32);
                hlp.ForeColor = Color.FromArgb(255, 222, 222, 222);
                ver.BackColor = Color.FromArgb(255, 32, 32, 32);
                ver.ForeColor = Color.FromArgb(255, 222, 222, 222);
                isblack = 1;
                button3.ForeColor = Color.FromArgb(255, 222, 222, 222);
                button4.ForeColor = Color.FromArgb(255, 222, 222, 222);
            }
            timer2.Start();
        }

        

        private void label5_Click(object sender, EventArgs e)
        {

            num++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (selected == 0) button2.ForeColor = Color.FromArgb(255, r, g, b);
            else if (selected == 1) button3.ForeColor = Color.FromArgb(255, r, g, b);
            else if (selected == 2) button4.ForeColor = Color.FromArgb(255, r, g, b);
            panel2.BackColor = panel_bt.BackColor  = Color.FromArgb(255, r, g, b);
            Settings1.Default.color_r = r;
            Settings1.Default.color_g = g;
            Settings1.Default.color_b = b;
            Settings1.Default.Save();
            timer2.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            num++;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ver.Visible = true;
            em.Visible = false;
            hlp.Visible = false;
            if (isblack == 0)
            {
                button2.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
            }
            else
            {
                button2.ForeColor = Color.FromArgb(255, 222, 222, 222);
                button3.ForeColor = Color.FromArgb(255, 222, 222, 222);
            }
            selected = 2;
            int ver_h = ver.Height;
            panel3.AutoScrollMinSize = new Size(10, ver_h);
            panel_bt.Location = button4.Location;
            
            timer2.Start();
        }//切换控件，设置控件可见性，设置按钮颜色

        private void button3_Click(object sender, EventArgs e)
        {
            hlp.Visible = true;
            ver.Visible = false;
            em.Visible = false;
            if (isblack == 0)
            {
                button4.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
            }
            else
            {
                button4.ForeColor = Color.FromArgb(255, 222, 222, 222);
                button2.ForeColor = Color.FromArgb(255, 222, 222, 222);
            }
            selected = 1;
            panel_bt.Location = button3.Location;
            timer2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            em.Visible = true;
            ver.Visible = false;
            hlp.Visible = false;
            if (isblack == 0)
            {
                button4.ForeColor = Color.Black;
                button3.ForeColor = Color.Black;
            }
            else
            {
                button4.ForeColor = Color.FromArgb(255, 222, 222, 222);
                button3.ForeColor = Color.FromArgb(255, 222, 222, 222);
            }
            selected = 0;
            panel_bt.Location = button2.Location;
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            r = 12; g = 81; b = 184;
            timer2.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            r = 128; g = 0; b = 0;
            timer2.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            r = 46; g = 139; b = 87;
            timer2.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            r = 0; g = 139; b = 139;
            timer2.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            r = 33; g = 150; b = 243;
            timer2.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            r = 72; g = 61; b = 139;
            timer2.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            r = 251; g = 114; b = 153;
            timer2.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            r = g = b = 128;
            timer2.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            r = 192;g = 64;b = 0;
            timer2.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            r = 255; g = 215; b = 0;
            timer2.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            r = 121;g = 68;b = 36;
            timer2.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            r = 167; g = 212; b = 192;
            timer2.Start();
        }

       

        private void button16_Click(object sender, EventArgs e)
        {
            r = 192; g =192; b = 255;
            timer2.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            r = 255; g = 192; b = 128;
            timer2.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorset.Visible == false)
            {
                colorset.Visible = true;
                button5.Text = "  隐藏颜色设置";
            }
            else if (colorset.Visible == true)
            {
                colorset.Visible = false;
                button5.Text = "  显示颜色设置";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
            if(color_white.Checked)
            {
                this.BackColor = Color.White;
                panel1.ForeColor = Color.Black;
                panel1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = SystemColors.Menu;
                em.BackColor = Color.White;
                em.ForeColor = Color.Black;
                hlp.BackColor = Color.White;
                hlp.ForeColor = Color.Black;
                ver.BackColor = Color.White;
                ver.ForeColor = Color.Black;
                isblack = 0;
                if (button2.ForeColor == Color.FromArgb(255, 222, 222, 222)) button2.ForeColor = Color.Black;
                if (button3.ForeColor == Color.FromArgb(255, 222, 222, 222)) button3.ForeColor = Color.Black;
                if (button4.ForeColor == Color.FromArgb(255, 222, 222, 222)) button4.ForeColor = Color.Black;
                Settings1.Default.isblack = 0;
                Settings1.Default.Save();
                timer2.Start();
            }
            else
            {
                this.BackColor = Color.FromArgb(255, 32, 32, 32);
                panel1.ForeColor = Color.FromArgb(255,222,222,222);
                panel1.BackColor = button2.BackColor =button3.BackColor = button4.BackColor = Color.FromArgb(255, 48, 48, 48);
                em.BackColor = Color.FromArgb(255, 32, 32, 32);
                em.ForeColor = Color.FromArgb(255, 222, 222, 222);
                hlp.BackColor = Color.FromArgb(255, 32, 32, 32);
                hlp.ForeColor = Color.FromArgb(255, 222, 222, 222);
                ver.BackColor = Color.FromArgb(255, 32, 32, 32);
                ver.ForeColor = Color.FromArgb(255, 222, 222, 222);

                isblack = 1;
                if (button2.ForeColor == Color.Black) button2.ForeColor = Color.FromArgb(255, 222, 222, 222);
                if (button3.ForeColor == Color.Black) button3.ForeColor = Color.FromArgb(255, 222, 222, 222);
                if (button4.ForeColor == Color.Black) button4.ForeColor = Color.FromArgb(255, 222, 222, 222);
                Settings1.Default.isblack = 1;
                Settings1.Default.Save();
                timer2.Start();
            }
        }
    }  
}
