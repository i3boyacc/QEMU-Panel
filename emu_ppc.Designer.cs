namespace QEMU_Panel
{
    partial class emu_ppc
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.add_arg = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.usb_dev = new System.Windows.Forms.CheckBox();
            this.label32 = new System.Windows.Forms.Label();
            this.boot_sel = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.net_mod = new System.Windows.Forms.ComboBox();
            this.net_host_port = new System.Windows.Forms.TextBox();
            this.net_vm_port = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.vnc_port = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.aud_mod = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpu_mode = new System.Windows.Forms.ComboBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.mem_size = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cpu_model = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cdr_img = new System.Windows.Forms.TextBox();
            this.hdd_img = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vga_mod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "QEMU PowerPC";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(28, 2236);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 25);
            this.label27.TabIndex = 156;
            this.label27.Text = "其它自定义参数：";
            // 
            // add_arg
            // 
            this.add_arg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_arg.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.add_arg.Location = new System.Drawing.Point(34, 2263);
            this.add_arg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_arg.Name = "add_arg";
            this.add_arg.Size = new System.Drawing.Size(624, 32);
            this.add_arg.TabIndex = 154;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button6.Location = new System.Drawing.Point(464, 2365);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 48);
            this.button6.TabIndex = 155;
            this.button6.Text = "确认并启动虚拟机";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // usb_dev
            // 
            this.usb_dev.AutoSize = true;
            this.usb_dev.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usb_dev.Location = new System.Drawing.Point(34, 2177);
            this.usb_dev.Margin = new System.Windows.Forms.Padding(4);
            this.usb_dev.Name = "usb_dev";
            this.usb_dev.Size = new System.Drawing.Size(596, 54);
            this.usb_dev.TabIndex = 145;
            this.usb_dev.Text = "启用USB设备及USB键鼠、触控板支持（PS/2键鼠支持将被禁用）\r\n(-usb -device usb-kbd -device usb-mouse -devic" +
    "e usb-tablet)";
            this.usb_dev.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label32.Location = new System.Drawing.Point(35, 1943);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(582, 75);
            this.label32.TabIndex = 139;
            this.label32.Text = "说明：\r\n如果进入启动菜单后您无法输入任何内容，请将输入法切换为英文输\r\n入模式。（系统启动后如无法输入任何内容也可以用此办法解决）";
            // 
            // boot_sel
            // 
            this.boot_sel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boot_sel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.boot_sel.FormattingEnabled = true;
            this.boot_sel.Items.AddRange(new object[] {
            "(开启启动菜单，启动时手动选择)",
            "第一软盘驱动器",
            "第一硬盘驱动器",
            "光盘驱动器"});
            this.boot_sel.Location = new System.Drawing.Point(233, 1905);
            this.boot_sel.Margin = new System.Windows.Forms.Padding(4);
            this.boot_sel.Name = "boot_sel";
            this.boot_sel.Size = new System.Drawing.Size(371, 32);
            this.boot_sel.TabIndex = 142;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label31.Location = new System.Drawing.Point(35, 1909);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(183, 25);
            this.label31.TabIndex = 140;
            this.label31.Text = "客户机第一启动项：";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label30.Location = new System.Drawing.Point(31, 2083);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(110, 62);
            this.label30.TabIndex = 141;
            this.label30.Text = "\r\n附加参数";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label41.Location = new System.Drawing.Point(34, 1281);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(107, 25);
            this.label41.TabIndex = 138;
            this.label41.Text = "网卡型号：";
            // 
            // net_mod
            // 
            this.net_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.net_mod.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.net_mod.FormattingEnabled = true;
            this.net_mod.Items.AddRange(new object[] {
            "dp83816",
            "e100",
            "ne2k_pci",
            "i82551",
            "i82557a",
            "i82557b",
            "i82557c",
            "i82558b",
            "i82559c",
            "i82559er",
            "i82801",
            "rtl8139",
            "e1000",
            "pcnet",
            "tnetw1130",
            "virtio"});
            this.net_mod.Location = new System.Drawing.Point(274, 1277);
            this.net_mod.Margin = new System.Windows.Forms.Padding(4);
            this.net_mod.Name = "net_mod";
            this.net_mod.Size = new System.Drawing.Size(132, 33);
            this.net_mod.TabIndex = 124;
            // 
            // net_host_port
            // 
            this.net_host_port.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.net_host_port.Location = new System.Drawing.Point(274, 1235);
            this.net_host_port.Margin = new System.Windows.Forms.Padding(4);
            this.net_host_port.Name = "net_host_port";
            this.net_host_port.Size = new System.Drawing.Size(132, 32);
            this.net_host_port.TabIndex = 123;
            // 
            // net_vm_port
            // 
            this.net_vm_port.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.net_vm_port.Location = new System.Drawing.Point(274, 1194);
            this.net_vm_port.Margin = new System.Windows.Forms.Padding(4);
            this.net_vm_port.Name = "net_vm_port";
            this.net_vm_port.Size = new System.Drawing.Size(132, 32);
            this.net_vm_port.TabIndex = 122;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label40.Location = new System.Drawing.Point(36, 1239);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(164, 25);
            this.label40.TabIndex = 137;
            this.label40.Text = "对应的主机端口：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label39.Location = new System.Drawing.Point(36, 1197);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(221, 25);
            this.label39.TabIndex = 136;
            this.label39.Text = "需要映射的虚拟机端口：";
            // 
            // vnc_port
            // 
            this.vnc_port.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vnc_port.Location = new System.Drawing.Point(555, 1400);
            this.vnc_port.Margin = new System.Windows.Forms.Padding(4);
            this.vnc_port.Name = "vnc_port";
            this.vnc_port.Size = new System.Drawing.Size(97, 32);
            this.vnc_port.TabIndex = 125;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label38.Location = new System.Drawing.Point(33, 1382);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(494, 50);
            this.label38.TabIndex = 135;
            this.label38.Text = "\r\nVNC端口号（留空则禁用VNC，填写的端口号须>5900）";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(35, 1320);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(114, 62);
            this.label37.TabIndex = 134;
            this.label37.Text = "\r\nVNC连接";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.label36.Location = new System.Drawing.Point(35, 1044);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(183, 50);
            this.label36.TabIndex = 133;
            this.label36.Text = "\r\n分辨率、颜色深度：";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(33, 982);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 62);
            this.label35.TabIndex = 130;
            this.label35.Text = "\r\n显示";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label19.Location = new System.Drawing.Point(35, 920);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 50);
            this.label19.TabIndex = 118;
            this.label19.Text = "\r\n型号：";
            // 
            // aud_mod
            // 
            this.aud_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aud_mod.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.aud_mod.FormattingEnabled = true;
            this.aud_mod.Items.AddRange(new object[] {
            "PC speaker",
            "Intel HD Audio",
            "CS4231A",
            "Gravis Ultrasound GF1",
            "Yamaha YM3812 (OPL2)",
            "Intel 82801AA AC97 Audio",
            "ENSONIQ AudioPCI ES1370",
            "Creative Sound Blaster 16",
            "全部"});
            this.aud_mod.Location = new System.Drawing.Point(113, 940);
            this.aud_mod.Margin = new System.Windows.Forms.Padding(4);
            this.aud_mod.Name = "aud_mod";
            this.aud_mod.Size = new System.Drawing.Size(543, 32);
            this.aud_mod.TabIndex = 120;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label14.Location = new System.Drawing.Point(32, 1648);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 62);
            this.label14.TabIndex = 116;
            this.label14.Text = "\r\n固件设置";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label13.Location = new System.Drawing.Point(36, 1140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(589, 50);
            this.label13.TabIndex = 117;
            this.label13.Text = "\r\n使用-net user模式连接，并将虚拟机的某端口转换到主机的某端口。";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label12.Location = new System.Drawing.Point(34, 1077);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 62);
            this.label12.TabIndex = 112;
            this.label12.Text = "\r\n网络";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label9.Location = new System.Drawing.Point(28, 717);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 62);
            this.label9.TabIndex = 107;
            this.label9.Text = "\r\n显示与声音";
            // 
            // cpu_mode
            // 
            this.cpu_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpu_mode.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cpu_mode.FormattingEnabled = true;
            this.cpu_mode.Items.AddRange(new object[] {
            "ppc",
            "ppc64"});
            this.cpu_mode.Location = new System.Drawing.Point(107, 252);
            this.cpu_mode.Margin = new System.Windows.Forms.Padding(4);
            this.cpu_mode.Name = "cpu_mode";
            this.cpu_mode.Size = new System.Drawing.Size(120, 33);
            this.cpu_mode.TabIndex = 100;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(27, 255);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 25);
            this.label34.TabIndex = 99;
            this.label34.Text = "架构：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(29, 64);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(633, 100);
            this.label33.TabIndex = 98;
            this.label33.Text = "\r\n注意：\r\n1. 不正确的设置会导致QEMU无法启动（可能无提示）。\r\n2. 本程序专为QEMU2.9而设计，部分功能可能不兼容其它版本的QEMU。";
            // 
            // mem_size
            // 
            this.mem_size.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mem_size.Location = new System.Drawing.Point(220, 416);
            this.mem_size.Margin = new System.Windows.Forms.Padding(4);
            this.mem_size.Name = "mem_size";
            this.mem_size.Size = new System.Drawing.Size(119, 32);
            this.mem_size.TabIndex = 102;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button3.Location = new System.Drawing.Point(551, 683);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 106;
            this.button3.Text = "浏览";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button2.Location = new System.Drawing.Point(551, 619);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 104;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cpu_model
            // 
            this.cpu_model.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cpu_model.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cpu_model.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cpu_model.FormattingEnabled = true;
            this.cpu_model.Items.AddRange(new object[] {
            "G2",
            "G3",
            "G4"});
            this.cpu_model.Location = new System.Drawing.Point(107, 294);
            this.cpu_model.Margin = new System.Windows.Forms.Padding(4);
            this.cpu_model.Name = "cpu_model";
            this.cpu_model.Size = new System.Drawing.Size(120, 32);
            this.cpu_model.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label8.Location = new System.Drawing.Point(29, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 90;
            this.label8.Text = "型号：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label18.Location = new System.Drawing.Point(26, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 62);
            this.label18.TabIndex = 96;
            this.label18.Text = "\r\nCPU";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label16.Location = new System.Drawing.Point(29, 655);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 25);
            this.label16.TabIndex = 95;
            this.label16.Text = "光盘镜像位置：";
            // 
            // cdr_img
            // 
            this.cdr_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdr_img.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cdr_img.Location = new System.Drawing.Point(33, 683);
            this.cdr_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cdr_img.Name = "cdr_img";
            this.cdr_img.Size = new System.Drawing.Size(511, 32);
            this.cdr_img.TabIndex = 105;
            // 
            // hdd_img
            // 
            this.hdd_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdd_img.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.hdd_img.Location = new System.Drawing.Point(33, 619);
            this.hdd_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdd_img.Name = "hdd_img";
            this.hdd_img.Size = new System.Drawing.Size(511, 32);
            this.hdd_img.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label6.Location = new System.Drawing.Point(27, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 75);
            this.label6.TabIndex = 94;
            this.label6.Text = "\r\n注意：如某项留空，客户机将不会安装该项硬件。\r\n硬盘镜像位置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label7.Location = new System.Drawing.Point(28, 479);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 62);
            this.label7.TabIndex = 93;
            this.label7.Text = "\r\n储存";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label5.Location = new System.Drawing.Point(29, 454);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(392, 25);
            this.label5.TabIndex = 92;
            this.label5.Text = "警告：若设置值太大，客户机可能无法启动。\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label3.Location = new System.Drawing.Point(29, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 50);
            this.label3.TabIndex = 91;
            this.label3.Text = "\r\n大小（单位MB）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label4.Location = new System.Drawing.Point(26, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 62);
            this.label4.TabIndex = 97;
            this.label4.Text = "\r\n内存（RAM）";
            // 
            // vga_mod
            // 
            this.vga_mod.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.vga_mod.FormattingEnabled = true;
            this.vga_mod.Items.AddRange(new object[] {
            "600x480x16",
            "600x480x32",
            "800x480x16",
            "800x480x32",
            "800x600x16",
            "800x600x32",
            "1024x600x16",
            "1024x600x32",
            "1024x768x16",
            "1024x768x32",
            "1280x720x16",
            "1280x720x32",
            "1280x800x16",
            "1280x800x32",
            "1366x768x16",
            "1366x768x32",
            "1440x900x16",
            "1440x900x32",
            "1600x900x16",
            "1600x900x32",
            "1920x1080x16",
            "1920x1080x32"});
            this.vga_mod.Location = new System.Drawing.Point(226, 1064);
            this.vga_mod.Margin = new System.Windows.Forms.Padding(4);
            this.vga_mod.Name = "vga_mod";
            this.vga_mod.Size = new System.Drawing.Size(184, 32);
            this.vga_mod.TabIndex = 121;
            // 
            // emu_ppc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label27);
            this.Controls.Add(this.add_arg);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.usb_dev);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.boot_sel);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.net_mod);
            this.Controls.Add(this.net_host_port);
            this.Controls.Add(this.net_vm_port);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.vnc_port);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.vga_mod);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.aud_mod);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cpu_mode);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.mem_size);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cpu_model);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cdr_img);
            this.Controls.Add(this.hdd_img);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "emu_ppc";
            this.Size = new System.Drawing.Size(693, 2595);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.TextBox add_arg;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox usb_dev;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox boot_sel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox net_mod;
        private System.Windows.Forms.TextBox net_host_port;
        private System.Windows.Forms.TextBox net_vm_port;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox vnc_port;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox aud_mod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cpu_mode;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox mem_size;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cpu_model;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox cdr_img;
        private System.Windows.Forms.TextBox hdd_img;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox vga_mod;
    }
}
