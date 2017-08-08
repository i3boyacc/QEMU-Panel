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

       
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string name);
        [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
        private static extern IntPtr GetProcAddress(IntPtr hmod, string name);
        private delegate void FarProc();
        /// <summary>
                /// The main entry point for the application.
                /// </summary>
        [STAThread]
        static void Main()
        {
            IntPtr hUser32 = GetModuleHandle("user32.dll");
            IntPtr addrSetProcessDPIAware = GetProcAddress(hUser32, "SetProcessDPIAware");
            if (addrSetProcessDPIAware != IntPtr.Zero)
            {
                FarProc SetProcessDPIAware = (FarProc)Marshal.GetDelegateForFunctionPointer(addrSetProcessDPIAware, typeof(FarProc));
                SetProcessDPIAware();
            }
            // C#的原有代码
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
