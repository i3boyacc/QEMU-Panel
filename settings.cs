using System.Windows.Forms;

namespace QEMU_Panel
{
    public partial class settings : UserControl
    {
        
        public settings()
        {
            InitializeComponent();
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
    }
}
