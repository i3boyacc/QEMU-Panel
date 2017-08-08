///运行QEMU的控件

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace QEMU_Panel
{
    public partial class easymode : UserControl
    {
        public easymode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(".\\qemu-system-x86_64.exe"))
            {
                string cpuarg, cpumarg, memarg, hdaarg, audioarg, flparg, netarg, timearg, cdromarg, bootarg;
                if (cpu_corenum.Text == String.Empty) { cpuarg = String.Empty; }
                else
                {
                    if (cpu_pnum.Text == String.Empty) { cpuarg = " -smp " + cpu_corenum.Text; }
                    else
                    {
                        if(cpu_per_core_num.Text == String.Empty) { cpuarg = " -smp " + cpu_corenum.Text + ",sockets=" + cpu_pnum.Text; }
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
                //CPU型号设置

                if (mem_size.Text == String.Empty) { memarg = String.Empty; }
                else { memarg = " -m " + mem_size.Text; }
                //内存设置

                if (hdd_img.Text == String.Empty) { hdaarg = String.Empty; }
                else { hdaarg = " -hda " + "\"" + hdd_img.Text + "\""; }
                //硬盘设置

                if (aud_mod.Text == String.Empty) { audioarg = String.Empty; } 
                else if(aud_mod.Text == "PC speaker") { audioarg = " -soundhw pcspk "; }
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
                else { flparg = " -fda " + "\"" + flp_img.Text + "\""; }
                //软盘设置

                if (cdr_img.Text == String.Empty) { cdromarg = String.Empty; }
                else { cdromarg = " -cdrom " + "\"" + cdr_img.Text + "\""; }
                //光驱设置

                netarg = " -net user";
                //网卡设置

                if(time_y.Text == String.Empty) { timearg = " -rtc base=localtime "; }
                else if (time_m.Text == String.Empty) { timearg = " -rtc base=localtime "; }
                else if (time_d.Text == String.Empty) { timearg = " -rtc base=localtime "; }
                else
                {
                    if (time_hour.Text == String.Empty) { timearg = " -rtc base=" + time_y.Text + "-" + time_m.Text + "-" + time_d.Text; }
                    else if (time_min.Text == String.Empty) { timearg = " -rtc base=" + time_y.Text + "-" + time_m.Text + "-" + time_d.Text; }
                    else if (time_sec.Text == String.Empty) { timearg = " -rtc base=" + time_y.Text + "-" + time_m.Text + "-" + time_d.Text; }
                    else { timearg = " -rtc base=" + time_y.Text + "-" + time_m.Text + "-" + time_d.Text 
                            + "T" + time_hour.Text + ":" + time_min.Text + ":" + time_sec.Text; }
                }
                //BIOS时间设置

                if (boot_sel.Text == String.Empty) bootarg = " -boot menu=on ";
                else if (boot_sel.Text == "(开启启动菜单，启动时手动选择)") bootarg = " -boot menu=on ";
                else if (boot_sel.Text == "第一软盘驱动器") bootarg = " -boot a ";
                else if (boot_sel.Text == "第一硬盘驱动器") bootarg = " -boot c ";
                else if (boot_sel.Text == "光盘驱动器") bootarg = " -boot d ";
                else bootarg = " -boot menu=on ";
                string arg = cpuarg + cpumarg + memarg + hdaarg + audioarg + flparg + netarg + timearg + cdromarg  + bootarg + " " + add_arg.Text;
                //MessageBox.Show("目标参数：" + arg, "目标参数", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Process qemu = new Process();
                ProcessStartInfo qemuinfo = new ProcessStartInfo();
                qemu.StartInfo = qemuinfo;
                qemuinfo.Arguments = arg;
                qemuinfo.FileName = "qemu-system-x86_64.exe";

                qemuinfo.CreateNoWindow = true;
                qemuinfo.RedirectStandardInput = true;
                qemuinfo.RedirectStandardOutput = true;
                qemuinfo.RedirectStandardError = true;
                qemuinfo.UseShellExecute = false;
                //不创建命令行窗口
                qemu.Start();
            }
            else MessageBox.Show("无法启动虚拟机。\n原因：QEMU程序文件不存在（qemu-system-x86_64.exe）", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_hda = new OpenFileDialog();
            open_hda.Filter = "镜像文件|*.img;*.vmdk;*.vhd|所有文件|*.*";
            if (open_hda.ShowDialog() == DialogResult.OK)
            {
                hdd_img.Text = open_hda.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_cdr = new OpenFileDialog();
            open_cdr.Filter = "镜像文件|*.iso;*.cdr|所有文件|*.*";
            if (open_cdr.ShowDialog() == DialogResult.OK)
            {
                cdr_img.Text = open_cdr.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_flp = new OpenFileDialog();
            open_flp.Filter = "镜像文件|*.img;*.ima|所有文件|*.*";
            if (open_flp.ShowDialog() == DialogResult.OK)
            {
                flp_img.Text = open_flp.FileName;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cpu_corenum.BackColor = label1.BackColor;
            cpu_model.BackColor = label1.BackColor;
            cpu_per_core_num.BackColor = label1.BackColor;
            cpu_pnum.BackColor = label1.BackColor;
            flp_img.BackColor = label1.BackColor;
            cdr_img.BackColor = label1.BackColor;
            hdd_img.BackColor = label1.BackColor;
            time_d.BackColor = label1.BackColor;
            time_y.BackColor = label1.BackColor;
            time_m.BackColor = label1.BackColor;
            time_hour.BackColor = label1.BackColor;
            time_min.BackColor = label1.BackColor;
            time_sec.BackColor = label1.BackColor;
            mem_size.BackColor = label1.BackColor;
            aud_mod.BackColor = label1.BackColor;
            time_sec.BackColor = label1.BackColor;
            cpu_corenum.ForeColor = label1.ForeColor;
            cpu_model.ForeColor = label1.ForeColor;
            cpu_per_core_num.ForeColor = label1.ForeColor;
            cpu_pnum.ForeColor = label1.ForeColor;
            flp_img.ForeColor = label1.ForeColor;
            cdr_img.ForeColor = label1.ForeColor;
            hdd_img.ForeColor = label1.ForeColor;
            time_d.ForeColor = label1.ForeColor;
            time_y.ForeColor = label1.ForeColor;
            time_m.ForeColor = label1.ForeColor;
            time_hour.ForeColor = label1.ForeColor;
            time_min.ForeColor = label1.ForeColor;
            time_sec.ForeColor = label1.ForeColor;
            mem_size.ForeColor = label1.ForeColor;
            aud_mod.ForeColor = label1.ForeColor;
            if (label1.ForeColor == Color.Black) button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = Color.FromArgb(255, 192, 192, 192);
            else button1.BackColor = button2.BackColor = button3.BackColor = button4.BackColor = Color.FromArgb(255, 64, 64, 64);
            timer1.Stop();
        }

        private void label1_ForeColorChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
