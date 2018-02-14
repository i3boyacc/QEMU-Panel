using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace QEMU_Panel
{
    public partial class emu_ppc : UserControl
    {
        public emu_ppc()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int vncport;
            string cpumarg, memarg, hdaarg, audioarg, netarg, cdromarg, bootarg, vncarg, vgaarg, usb, qemufilename;
            if (cpu_mode.Text == "ppc") qemufilename = "qemu-system-ppc.exe";
            else qemufilename = "qemu-system-ppc64.exe";
            if (File.Exists(qemufilename))//判断指定的QEMU文件名是否存在，如存在则继续设置启动参数，如不存在则给出错误提示并拒绝启动QEMU
            {
                if ((File.Exists("\"" + hdd_img.Text + "\"") || hdd_img.Text == String.Empty)
                && File.Exists("\"" + cdr_img.Text + "\"") || cdr_img.Text == String.Empty) System.Threading.Thread.Sleep(1);
                //VS提示空语句可能有错误，我也不知道该写什么了，然而我又不知道文件不存在该怎么写，只能这么写了（对程序速度影响甚微）
                else MessageBox.Show("警告：我们无法找到您指定的硬盘或光盘镜像，模拟器可能会无法启动。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //判断指定的镜像文件是否存在，如不存在则给出警告（我用的这方式不要吐槽）
                if (cpu_model.Text == String.Empty) { cpumarg = String.Empty; }
                else { cpumarg = " -cpu " + cpu_model.Text + " "; }
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


                //避免Win2k安装磁盘已满的Bug设置

                string arg = cpumarg + memarg + hdaarg + audioarg  + netarg + vncarg +
                     cdromarg + bootarg + vgaarg + usb + add_arg.Text;
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
   
    }
}
