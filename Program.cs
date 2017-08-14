using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QEMU_Panel
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [DllImport("user32.dll")] 
        private static extern void SetProcessDPIAware();
        //高DPI设置
        /// <summary>
                /// The main entry point for the application.
                /// </summary>
        [STAThread]
        static void Main()
        {
            SetProcessDPIAware(); //高DPI设置
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
