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
        public static Form1 fm1 = null;
        public Form1()
        {
            fm1 = this;//便于其它控件调用该窗口中的函数
            InitializeComponent();
        }

        public int selected;//用值表示选中的按钮
        public emu_x86 x86;
        public settings set;
        public emu_arm arm;
        public emu_ppc ppc;
        

        public void Form1_Load(object sender, EventArgs e)
        {
            x86 = new emu_x86();
            set = new settings();
            arm = new emu_arm();
            ppc = new emu_ppc();
            
            x86.Show();
            set.Show();
            arm.Show();
            ppc.Show();
            panel3.Controls.Add(x86);
            panel3.Controls.Add(set);
            panel3.Controls.Add(arm);
            panel3.Controls.Add(ppc);//向panel里面添加运行QEMU及设置的控件

            x86.Visible = false;
            set.Visible = false;
            arm.Visible = false;
            ppc.Visible = false;
            //由于默认选中了QEMU x86，因此默认隐藏其它三个控件

            if (Settings1.Default.isblack == 0)//设置默认颜色，白色或黑色
            {
                this.BackColor = Color.White;
                panel1.ForeColor = Color.Black;
                panel1.BackColor = SystemColors.Menu;
                x86.BackColor = arm.BackColor = ppc.BackColor = set.BackColor = Color.White;
                x86.ForeColor = arm.ForeColor = ppc.ForeColor = set.ForeColor = Color.Black;
                btn_x86.ForeColor = btn_arm.ForeColor = btn_ppc.ForeColor = btn_set.ForeColor = Color.Black;
                btn_arm.BackColor = btn_set.BackColor = btn_x86.BackColor = btn_ppc.BackColor = panel1.BackColor;
            }
            else
            {
                this.BackColor = Color.FromArgb(24, 24, 24);
                panel1.ForeColor = Color.FromArgb(233, 233, 233);
                panel1.BackColor = Color.FromArgb(32, 32, 32);
                x86.BackColor = arm.BackColor = ppc.BackColor = set.BackColor = Color.FromArgb(24, 24, 24);
                x86.ForeColor = arm.ForeColor = ppc.ForeColor = set.ForeColor = Color.FromArgb(233, 233, 233);
                btn_x86.ForeColor = btn_arm.ForeColor = btn_ppc.ForeColor = btn_set.ForeColor = Color.FromArgb(233, 233, 233);
                btn_arm.BackColor = btn_set.BackColor = btn_x86.BackColor = btn_ppc.BackColor = panel1.BackColor;
            }
            change_color(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
        }

        public void change_theme()
        {
            if (Settings1.Default.isblack == 0)//设置默认颜色，白色或黑色
            {
                this.BackColor = Color.White;
                panel1.ForeColor = Color.Black;
                panel1.BackColor = SystemColors.Menu;
                x86.BackColor = arm.BackColor = ppc.BackColor = set.BackColor = Color.White;
                x86.ForeColor = arm.ForeColor = ppc.ForeColor = set.ForeColor = Color.Black;
                btn_x86.ForeColor = btn_arm.ForeColor = btn_ppc.ForeColor = btn_set.ForeColor = Color.Black;
                btn_arm.BackColor = btn_set.BackColor = btn_x86.BackColor = btn_ppc.BackColor = panel1.BackColor;
            }
            else
            {
                this.BackColor = Color.FromArgb(24, 24, 24);
                panel1.ForeColor = Color.FromArgb(233, 233, 233);
                panel1.BackColor = Color.FromArgb(32, 32, 32);
                x86.BackColor = arm.BackColor = ppc.BackColor = set.BackColor = Color.FromArgb(24, 24, 24);
                x86.ForeColor = arm.ForeColor = ppc.ForeColor = set.ForeColor = Color.FromArgb(233, 233, 233);
                btn_x86.ForeColor = btn_arm.ForeColor = btn_ppc.ForeColor = btn_set.ForeColor = Color.FromArgb(233, 233, 233);
                btn_arm.BackColor = btn_set.BackColor = btn_x86.BackColor = btn_ppc.BackColor = panel1.BackColor;
            }
        }

        public void change_color(int r, int g, int b)
        {
            Settings1.Default.color_r = r;
            Settings1.Default.color_g = g;
            Settings1.Default.color_b = b;
            if (selected == 0) btn_x86.ForeColor = Color.FromArgb(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
            else if (selected == 1) btn_arm.ForeColor = Color.FromArgb(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
            else if (selected == 2) btn_ppc.ForeColor = Color.FromArgb(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
            else if (selected == 3) btn_set.ForeColor = Color.FromArgb(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
            panel_bt.BackColor = Color.FromArgb(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
            Settings1.Default.Save();
        }
        

        private void btn_x86_Click(object sender, EventArgs e)
        {
            x86.Visible = true;
            set.Visible = false;
            arm.Visible = false;
            ppc.Visible = false;//切换panel中的控件
            panel_bt.Visible = true;
            if (Settings1.Default.isblack == 0)
            {
                btn_set.ForeColor
                = btn_arm.ForeColor
                = btn_ppc.ForeColor
                = Color.Black;
            }
            else
            {
                btn_set.ForeColor
                = btn_arm.ForeColor
                = btn_ppc.ForeColor
                = Color.FromArgb(233, 233, 233);
            }//根据当前颜色主题设置未选中控件对应按钮的文字颜色
            selected = 0;//用数字表示目前选中的控件对应的按钮，以便后续使用
            panel_bt.Location = btn_x86.Location;
            panel3.AutoScrollMinSize = new Size(10, x86.Height);//设置滚动条滚动长度
            change_color(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
        }

        private void btn_arm_Click(object sender, EventArgs e)
        {
            arm.Visible = true;
            set.Visible = false;
            x86.Visible = false;
            ppc.Visible = false;
            panel_bt.Visible = true;
            if (Settings1.Default.isblack == 0)
            {
                btn_set.ForeColor
                = btn_ppc.ForeColor
                = btn_x86.ForeColor
                = Color.Black;
            }
            else
            {
                btn_set.ForeColor
                = btn_x86.ForeColor
                = btn_ppc.ForeColor
                = Color.FromArgb(233, 233, 233);
            }
            selected = 1;
            panel_bt.Location = btn_arm.Location;
            panel3.AutoScrollMinSize = new Size(10, arm.Height);
            change_color(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
        }

        private void btn_ppc_Click(object sender, EventArgs e)
        {
            ppc.Visible = true;
            arm.Visible = false;
            set.Visible = false;
            x86.Visible = false;
            panel_bt.Visible = true;
            if (Settings1.Default.isblack == 0)
            {
                btn_set.ForeColor = btn_x86.ForeColor = btn_arm.ForeColor = Color.Black;
            }
            else
            {
                btn_set.ForeColor = btn_x86.ForeColor = btn_arm.ForeColor
                    = Color.FromArgb(233, 233, 233);
            }
            selected = 2;
            panel_bt.Location = btn_ppc.Location;
            panel3.AutoScrollMinSize = new Size(10, ppc.Height);
            change_color(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            set.Visible = true;
            x86.Visible = false;
            arm.Visible = false;
            ppc.Visible = false;
            if (Settings1.Default.isblack == 0)
            {
                btn_x86.ForeColor
                = btn_arm.ForeColor
                = btn_ppc.ForeColor
                = Color.Black;
            }
            else
            {
                btn_x86.ForeColor
                = btn_arm.ForeColor 
                = btn_ppc.ForeColor
                = Color.FromArgb(233, 233, 233);
            }
            selected = 3;
            panel3.AutoScrollMinSize = new Size(10, set.Height);
            panel_bt.Location = btn_set.Location;

            change_color(Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
        }//切换控件，设置控件可见性，设置按钮颜色
        
    }
}