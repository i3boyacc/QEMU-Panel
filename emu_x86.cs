///运行QEMU （x86架构）的控件

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace QEMU_Panel
{
    public partial class emu_x86 : UserControl
    {
        public emu_x86()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cpuarg, cpumarg, memarg, hdaarg, audioarg, flparg, netarg, timearg, cdromarg, bootarg, biosarg, vncarg, vgaarg, win2khack, usb, qemufilename;
            //cpuarg--CPU个数参数；cpumarg--CPU型号参数；memarg--内存大小参数；hdaarg--主硬盘参数；audioarg--声卡参数
            //flparg--软盘参数；netarg--网卡参数；timearg--模拟器时间参数；cdromarg--光驱参数；bootarg--启动项参数；qemufilename--要启动的QEMU文件名
            //biosarg--第三方BIOS文件设置; vncarg--vnc参数; win2khack-- 避免win2k安装磁盘已满的参数; usb--启用USB及USB键鼠支持的参数
            int vncport;//vnc端口号
            if (cpu_mode.Text == "i386") qemufilename = "qemu-system-i386.exe";
            else qemufilename = "qemu-system-x86_64.exe";
            if (File.Exists(qemufilename))//判断指定的QEMU文件名是否存在，如存在则继续设置启动参数，如不存在则给出错误提示并拒绝启动QEMU
            {
                if ((File.Exists("\"" + hdd_img.Text + "\"") || hdd_img.Text == String.Empty)
                && (File.Exists("\"" + flp_img.Text + "\"") || flp_img.Text == String.Empty)
                && File.Exists("\"" + cdr_img.Text + "\"") || cdr_img.Text == String.Empty) Thread.Sleep(1) ;
                //VS提示空语句可能有错误，我也不知道该写什么了，然而我又不知道文件不存在该怎么写，只能这么写了（对程序速度影响甚微）
                else MessageBox.Show("警告：我们无法找到您指定的硬盘、软盘或光盘镜像，模拟器可能会无法启动。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //判断指定的镜像文件是否存在，如不存在则给出警告（我用的这方式不要吐槽）
                if (cpu_corenum.Text == String.Empty) { cpuarg = String.Empty; }
                else
                {
                    if (cpu_pnum.Text == String.Empty) { cpuarg = " -smp " + cpu_corenum.Text; }
                    else
                    {
                        if (cpu_per_core_num.Text == String.Empty) { cpuarg = " -smp " + cpu_corenum.Text + ",sockets=" + cpu_pnum.Text; }
                        else { cpuarg = " -smp " + cpu_corenum.Text + ",sockets=" + cpu_pnum.Text + ",cores=" + cpu_per_core_num.Text; }
                    }
                } //处理器个数设置
                if (cpu_model.Text == String.Empty) { cpumarg = String.Empty; }
                else if (cpu_model.Text == "486") { cpumarg = " -cpu 486 "; }
                else if (cpu_model.Text == "Intel Core Processor (Broadwell, no TSX)") { cpumarg = " -cpu Broadwell-noTSX "; }
                else if (cpu_model.Text == "Intel Core Processor (Broadwell)") { cpumarg = " -cpu Broadwell "; }
                else if (cpu_model.Text == "Intel Celeron_4x0 (Conroe/Merom Class Core 2)") { cpumarg = " -cpu Conroe "; }
                else if (cpu_model.Text == "Intel Core Processor (Haswell, no TSX)") { cpumarg = " -cpu Haswell-noTSX "; }
                else if (cpu_model.Text == "Intel Core Processor (Haswell)") { cpumarg = " -cpu Haswell "; }
                else if (cpu_model.Text == "Intel Xeon E3-12xx v2 (Ivy Bridge)") { cpumarg = " -cpu IvyBridge "; }
                else if (cpu_model.Text == "Intel Core i7 9xx (Nehalem Class Core i7)") { cpumarg = " -cpu Nehalem "; }
                else if (cpu_model.Text == "AMD Opteron 240 (Gen 1 Class Opteron)") { cpumarg = " -cpu Opteron_G1 "; }
                else if (cpu_model.Text == "AMD Opteron 22xx (Gen 2 Class Opteron)") { cpumarg = " -cpu Opteron_G2 "; }
                else if (cpu_model.Text == "AMD Opteron 23xx (Gen 3 Class Opteron)") { cpumarg = " -cpu Opteron_G3 "; }
                else if (cpu_model.Text == "AMD Opteron 62xx class CPU") { cpumarg = " -cpu Opteron_G4 "; }
                else if (cpu_model.Text == "AMD Opteron 63xx class CPU") { cpumarg = " -cpu Opteron_G5 "; }
                else if (cpu_model.Text == "Intel Core 2 Duo P9xxx (Penryn Class Core 2)") { cpumarg = " -cpu Penryn "; }
                else if (cpu_model.Text == "Intel Xeon E312xx (Sandy Bridge)") { cpumarg = " -cpu SandyBridge "; }
                else if (cpu_model.Text == "Intel Core Processor (Skylake)") { cpumarg = " -cpu Skylake-Client "; }
                else if (cpu_model.Text == "Westmere E56xx/L56xx/X56xx (Nehalem-C)") { cpumarg = " -cpu Westmere "; }

                else if (cpu_model.Text == "QEMU Virtual CPU version 2.5+") { cpumarg = " -cpu athlon "; }
                else if (cpu_model.Text == "Intel(R) Core(TM)2 Duo CPU     T7700  @ 2.40GHz") { cpumarg = " -cpu core2duo "; }
                else if (cpu_model.Text == "Genuine Intel(R) CPU           T2600  @ 2.16GHz") { cpumarg = " -cpu coreduo "; }
                else if (cpu_model.Text == "Intel Celeron_4x0 (Conroe/Merom Class Core 2)") { cpumarg = " -cpu Conroe "; }
                else if (cpu_model.Text == "Common 32-bit KVM processor") { cpumarg = " -cpu kvm32 "; }
                else if (cpu_model.Text == "Common KVM processor") { cpumarg = " -cpu kvm64 "; }
                else if (cpu_model.Text == "Intel(R) Atom(TM) CPU N270   @ 1.60GHz") { cpumarg = " -cpu n270 "; }
                else if (cpu_model.Text == "Pentium") { cpumarg = " -cpu pentium "; }
                else if (cpu_model.Text == "Pentium 2") { cpumarg = " -cpu pentium2 "; }

                else if (cpu_model.Text == "Pentium 3") { cpumarg = " -cpu pentium3 "; }
                else if (cpu_model.Text == "base CPU model type with no features enabled") { cpumarg = " -cpu base "; }
                else if (cpu_model.Text == "AMD Phenom(tm) 9550 Quad-Core Processor") { cpumarg = " -cpu phenom "; }
                else if (cpu_model.Text == "Common KVM processor") { cpumarg = " -cpu kvm64 "; }
                else if (cpu_model.Text == "QEMU Virtual CPU version 2.5+(x86)") { cpumarg = " -cpu qemu32 "; }
                else if (cpu_model.Text == "QEMU Virtual CPU version 2.5+") { cpumarg = " -cpu qemu64 "; }
                else if (cpu_model.Text == "Enables all features supported by the accelerator in the current host") { cpumarg = " -cpu max "; }
                else { cpumarg = String.Empty; }
                //CPU型号设置，根据所选CPU名称生成相应的参数

                if (mem_size.Text == String.Empty) { memarg = String.Empty; }
                else { memarg = " -m " + mem_size.Text; }
                //内存设置

                if (hdd_img.Text == String.Empty) { hdaarg = String.Empty; }
                else { hdaarg = " -hda " + "\"" + hdd_img.Text + "\""; }
                //硬盘设置

                if (aud_mod.Text == String.Empty) { audioarg = String.Empty; }
                else if (aud_mod.Text == "PC speaker") { audioarg = " -soundhw pcspk "; }
                else if (aud_mod.Text == "Intel HD Audio") { audioarg = " -soundhw hda "; }
                else if (aud_mod.Text == "CS4231A") { audioarg = " -soundhw cs4231a "; }
                else if (aud_mod.Text == "Gravis Ultrasound GF1") { audioarg = " -soundhw gus "; }
                else if (aud_mod.Text == "Yamaha YM3812 (OPL2)") { audioarg = " -soundhw adlib "; }
                else if (aud_mod.Text == "ENSONIQ AudioPCI ES1370") { audioarg = " -soundhw es1370 "; }
                else if (aud_mod.Text == "Creative Sound Blaster 16") { audioarg = " -soundhw sb16 "; }
                else if (aud_mod.Text == "Intel 82801AA AC97 Audio") { audioarg = " -soundhw ac97 "; }
                else if (aud_mod.Text == "全部") { audioarg = " -soundhw all "; }
                else { audioarg = String.Empty; }
                //声卡设置

                if (flp_img.Text == String.Empty) { flparg = String.Empty; }
                else { flparg = " -fda " + "\"" + flp_img.Text + "\" "; }
                //软盘设置

                if (cdr_img.Text == String.Empty) { cdromarg = String.Empty; }
                else { cdromarg = " -cdrom " + "\"" + cdr_img.Text + "\" "; }
                //光驱设置

                if (net_mod.Text == String.Empty) netarg = String.Empty;
                else
                {
                    netarg = " -net nic,model=" + net_mod.Text;
                    if (net_host_port.Text == String.Empty || net_vm_port.Text == String.Empty) netarg = netarg + " -net user ";
                    else netarg = netarg + " -net user,hostfwd=tcp::" + net_host_port.Text + "-:" + net_vm_port.Text + " ";
                }
                //网卡设置

                if (time_y.Text == String.Empty || time_m.Text == String.Empty || time_d.Text == String.Empty) { timearg = " -rtc base=localtime "; }
                else
                {
                    if (time_hour.Text == String.Empty || time_min.Text == String.Empty || time_sec.Text == String.Empty)
                    { timearg = " -rtc base=" + time_y.Text + "-" + time_m.Text + "-" + time_d.Text + ""; }
                    else
                    {
                        timearg = " -rtc base=" + time_y.Text + "-" + time_m.Text + "-" + time_d.Text
                        + "T" + time_hour.Text + ":" + time_min.Text + ":" + time_sec.Text + " ";
                    }
                }
                //BIOS时间设置

                if (vnc_port.Text == String.Empty) vncarg = String.Empty;
                else
                {
                    vncport = Convert.ToInt32(vnc_port.Text) - 5900;
                    vncarg = " -vnc :" + Convert.ToString(vncport) + " ";
                }
                //VNC设置

                if (boot_sel.Text == "(开启启动菜单，启动时手动选择)") bootarg = " -boot menu=on ";
                else if (boot_sel.Text == "第一软盘驱动器") bootarg = " -boot a ";
                else if (boot_sel.Text == "第一硬盘驱动器") bootarg = " -boot c ";
                else if (boot_sel.Text == "光盘驱动器") bootarg = " -boot d ";
                else bootarg = " -boot menu=on ";
                //启动项设置

                if (bios_file.Text == String.Empty) biosarg = String.Empty;
                else
                {
                    biosarg = " -bios " + "\"" + bios_file.Text + "\" ";
                }//第三方BIOS设置

                if (vga_mod.Text == String.Empty) vgaarg = String.Empty;
                else if (vga_mod.Text == "Cirrus Logic GD5446 Video card") vgaarg = " -vga cirrus ";
                else if (vga_mod.Text == "Standard VGA card with Bochs VBE extensions(默认)") vgaarg = " -vga std ";
                else if (vga_mod.Text == "VMWare SVGA-II compatible adapter") vgaarg = " -vga vmware ";
                else if (vga_mod.Text == "QXL paravirtual graphic card") vgaarg = " -vga qxl ";
                else if (vga_mod.Text == "Sun TCX framebuffer") vgaarg = " -vga tcx ";
                else if (vga_mod.Text == "Sun cgthree framebuffer") vgaarg = " -vga cg3 ";
                else if (vga_mod.Text == "Virtio VGA card") vgaarg = " -vga virtio ";
                else if (vga_mod.Text == "(禁用VGA显示卡)") vgaarg = " -vga none ";
                else vgaarg = String.Empty;
                //VGA设置

                if (usb_dev.Checked) usb = " -usb -device usb-kbd -device usb-mouse -device usb-tablet ";
                else usb = "";
                //USB设备及键鼠支持设置

                if (win2k_hack.Checked) win2khack = " -win2k-hack ";
                else win2khack = "";
                //避免Win2k安装磁盘已满的Bug设置

                string arg = cpuarg + cpumarg + memarg + hdaarg + audioarg + flparg + netarg + vncarg +
                     timearg + cdromarg + bootarg + vgaarg + biosarg + usb + win2khack + add_arg.Text;
                //生成启动参数

                Process qemu = new Process();
                ProcessStartInfo qemuinfo = new ProcessStartInfo();
                qemu.StartInfo = qemuinfo;
                qemuinfo.Arguments = arg;
                qemuinfo.FileName = qemufilename;
                qemuinfo.CreateNoWindow = true;
                qemuinfo.RedirectStandardInput = true;
                qemuinfo.RedirectStandardOutput = true;
                qemuinfo.RedirectStandardError = true;
                qemuinfo.UseShellExecute = false;
                qemu.Start();
                //启动QEMU，且不创建命令行窗口
            }
            else
            {
                if (cpu_mode.Text == cpu_mode.Items[0].ToString()) MessageBox.Show("错误：无法启动模拟器，因为无法找到QEMU文件“qemu-system-i386.exe”\n请检查后重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else MessageBox.Show("错误：无法启动模拟器，因为无法找到QEMU文件“qemu-system-x86_64.exe”\n请检查后重试。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_hda = new OpenFileDialog();
            open_hda.Filter = "镜像文件|*.img;*.vmdk;*.vhd|所有文件|*.*";
            if (open_hda.ShowDialog() == DialogResult.OK)
            {
                hdd_img.Text = open_hda.FileName;
            }
        }//浏览硬盘镜像文件

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_cdr = new OpenFileDialog();
            open_cdr.Filter = "镜像文件|*.iso;*.cdr|所有文件|*.*";
            if (open_cdr.ShowDialog() == DialogResult.OK)
            {
                cdr_img.Text = open_cdr.FileName;
            }
        }//浏览光盘镜像文件

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_flp = new OpenFileDialog();
            open_flp.Filter = "镜像文件|*.img;*.ima|所有文件|*.*";
            if (open_flp.ShowDialog() == DialogResult.OK)
            {
                flp_img.Text = open_flp.FileName;
            }
        }//浏览软盘镜像文件

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_bios = new OpenFileDialog();
            open_bios.Filter = "BIOS文件|*.*";
            if (open_bios.ShowDialog() == DialogResult.OK)
            {
                bios_file.Text = open_bios.FileName;
            }
        }

        private void label1_ForeColorChanged(object sender, EventArgs e)
        {
            cpu_corenum.BackColor
            = cpu_model.BackColor
            = cpu_per_core_num.BackColor
            = cpu_pnum.BackColor
            = flp_img.BackColor
            = cdr_img.BackColor
            = hdd_img.BackColor
            = time_d.BackColor
            = time_y.BackColor
            = time_m.BackColor
            = time_hour.BackColor
            = time_min.BackColor
            = time_sec.BackColor
            = mem_size.BackColor
            = aud_mod.BackColor
            = bios_file.BackColor
            = vga_mod.BackColor
            = net_host_port.BackColor
            = net_mod.BackColor
            = net_vm_port.BackColor
            = vnc_port.BackColor
            = time_sec.BackColor
            = add_arg.BackColor
            = boot_sel.BackColor
            = cpu_mode.BackColor
            = label1.BackColor;
            //在切换颜色时，将easymode（本控件）中所有控件的颜色更改为与Label1一致的颜色
            //（从主窗口更改只有部分颜色会更改）
            //本人水平低，不会父传子，只会这么搞，勿喷
            //下面代码同

            cpu_corenum.ForeColor
            = cpu_model.ForeColor
            = cpu_per_core_num.ForeColor
            = cpu_pnum.ForeColor
            = flp_img.ForeColor
            = cdr_img.ForeColor
            = hdd_img.ForeColor
            = time_d.ForeColor
            = time_y.ForeColor
            = time_m.ForeColor
            = time_hour.ForeColor
            = time_min.ForeColor
            = time_sec.ForeColor
            = mem_size.ForeColor
            = bios_file.ForeColor
            = vga_mod.ForeColor
            = net_host_port.ForeColor
            = net_mod.ForeColor
            = net_vm_port.ForeColor
            = vnc_port.ForeColor
            = aud_mod.ForeColor
            = add_arg.ForeColor
            = boot_sel.ForeColor
            = cpu_mode.ForeColor
            = label1.ForeColor;

            if (label1.ForeColor == Color.Black)
                button1.BackColor
                    = button2.BackColor
                    = button3.BackColor
                    = button4.BackColor
                    = button5.BackColor
                    = Color.FromArgb(255, 192, 192, 192);
            else
                button1.BackColor
                    = button2.BackColor
                    = button3.BackColor
                    = button4.BackColor
                    = button5.BackColor
                    = Color.FromArgb(255, 64, 64, 64);
        }

        private void easymode_Load(object sender, EventArgs e)
        {
            cpu_mode.Text = cpu_mode.Items[0].ToString();//默认选择第一个值
            boot_sel.Text = boot_sel.Items[0].ToString();
        }
    }
}