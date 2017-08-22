using System.Drawing;
using System.Windows.Forms;

namespace QEMU_Panel
{
    public partial class settings : UserControl
    {
        
        public settings()
        {
            InitializeComponent();
            linkLabel1.LinkColor = linkLabel1.VisitedLinkColor
                = Color.FromArgb(255, Settings1.Default.color_r, Settings1.Default.color_g, Settings1.Default.color_b);
            //启动时设置链接颜色为所选配色
        }

        private void theme_dark_CheckedChanged(object sender, System.EventArgs e)
        {
            if (theme_light.Checked) Settings1.Default.isblack = 0;
            else Settings1.Default.isblack = 1;
            Settings1.Default.Save();
            Form1.fm1.change_theme();
        }

        private void settings_Load(object sender, System.EventArgs e)
        {
            if (Settings1.Default.isblack == 0) theme_light.Checked = true;
            else if (Settings1.Default.isblack == 1) theme_dark.Checked = true;
        }

        private void color1_Click(object sender, System.EventArgs e)
        {
            change_color(12, 81, 184);//更改颜色，下同
        }

        private void color2_Click(object sender, System.EventArgs e)
        {
            change_color(128, 0, 0);
        }

        private void color3_Click(object sender, System.EventArgs e)
        {
            change_color(46, 139, 87);
        }

        private void color4_Click(object sender, System.EventArgs e)
        {
            change_color(0, 139, 139);
        }

        private void color5_Click(object sender, System.EventArgs e)
        {
            change_color(33, 150, 243);
        }

        private void color6_Click(object sender, System.EventArgs e)
        {
            change_color(72, 61, 139);
        }

        private void color7_Click(object sender, System.EventArgs e)
        {
            change_color(250, 110, 183);
        }

        private void color8_Click(object sender, System.EventArgs e)
        {
            change_color(255, 84, 16);
        }

        private void color9_Click(object sender, System.EventArgs e)
        {
            change_color(255, 215, 0);
        }

        private void color10_Click(object sender, System.EventArgs e)
        {
            change_color(121, 268, 36);
        }

        private void color11_Click(object sender, System.EventArgs e)
        {
            change_color(161, 212, 192);
        }

        private void color12_Click(object sender, System.EventArgs e)
        {
            change_color(192, 192, 255);
        }

        private void color13_Click(object sender, System.EventArgs e)
        {
            change_color(255, 192, 128);
        }

        private void color14_Click(object sender, System.EventArgs e)
        {
            change_color(128, 128, 128);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabel1.Text);
        }

        private void change_color(int r,int g,int b)
        {
            linkLabel1.LinkColor = linkLabel1.VisitedLinkColor = Color.FromArgb(255, r, g, b);
            //以上将更改链接颜色为所选配色
            Form1.fm1.change_color(r, g, b);
        }
    }
}
