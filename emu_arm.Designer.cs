namespace QEMU_Panel
{
    partial class emu_arm
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
            this.label41 = new System.Windows.Forms.Label();
            this.net_mod = new System.Windows.Forms.ComboBox();
            this.net_host_port = new System.Windows.Forms.TextBox();
            this.net_vm_port = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.vnc_port = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.vga_mod = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.time_sec = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.time_min = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.time_hour = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.time_d = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.time_m = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.time_y = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.aud_mod = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.usb_dev = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.bios_file = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.boot_sel = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.add_arg = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.usb_img = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "运行QEMU arm";
            // 
            // cpu_mode
            // 
            this.cpu_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpu_mode.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cpu_mode.FormattingEnabled = true;
            this.cpu_mode.Items.AddRange(new object[] {
            "arm32",
            "arm64"});
            this.cpu_mode.Location = new System.Drawing.Point(107, 277);
            this.cpu_mode.Margin = new System.Windows.Forms.Padding(4);
            this.cpu_mode.Name = "cpu_mode";
            this.cpu_mode.Size = new System.Drawing.Size(120, 33);
            this.cpu_mode.TabIndex = 27;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label34.Location = new System.Drawing.Point(27, 280);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(69, 25);
            this.label34.TabIndex = 23;
            this.label34.Text = "架构：";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label33.Location = new System.Drawing.Point(29, 64);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(613, 125);
            this.label33.TabIndex = 22;
            this.label33.Text = "\r\n注意：\r\n1. 不正确的设置会导致模拟器无法启动，且可能无任何提示。\r\n2. 本设置内容是为QEMU2.9版本设置的。如果您运行的不是最新版本的\r\nQEMU，" +
    "某些设置项可能不可用，此时请不要设置不支持的选项。";
            // 
            // mem_size
            // 
            this.mem_size.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mem_size.Location = new System.Drawing.Point(220, 446);
            this.mem_size.Margin = new System.Windows.Forms.Padding(4);
            this.mem_size.Name = "mem_size";
            this.mem_size.Size = new System.Drawing.Size(119, 32);
            this.mem_size.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button3.Location = new System.Drawing.Point(550, 738);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 34);
            this.button3.TabIndex = 33;
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
            this.button2.Location = new System.Drawing.Point(550, 674);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 34);
            this.button2.TabIndex = 31;
            this.button2.Text = "浏览";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // cpu_model
            // 
            this.cpu_model.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cpu_model.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpu_model.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cpu_model.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cpu_model.FormattingEnabled = true;
            this.cpu_model.Items.AddRange(new object[] {
            "arm1026",
            "arm1136",
            "arm1136-r2",
            "arm1176",
            "arm11mpcore",
            "arm920t",
            "arm926",
            "arm946",
            "cortex-a15",
            "cortex-a53",
            "cortex-a57",
            "cortex-a7",
            "cortex-a8",
            "cortex-a9",
            "cortex-m3",
            "cortex-m4",
            "cortex-r5",
            "pxa250",
            "pxa255",
            "pxa260",
            "pxa261",
            "pxa262",
            "pxa270-a0",
            "pxa270-a1",
            "pxa270",
            "pxa270-b0",
            "pxa270-b1",
            "pxa270-c0",
            "pxa270-c5",
            "sa1100",
            "sa1110",
            "ti925t"});
            this.cpu_model.Location = new System.Drawing.Point(107, 319);
            this.cpu_model.Margin = new System.Windows.Forms.Padding(4);
            this.cpu_model.Name = "cpu_model";
            this.cpu_model.Size = new System.Drawing.Size(543, 32);
            this.cpu_model.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label8.Location = new System.Drawing.Point(29, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "型号：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label18.Location = new System.Drawing.Point(26, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 62);
            this.label18.TabIndex = 17;
            this.label18.Text = "\r\nCPU";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label16.Location = new System.Drawing.Point(28, 710);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(145, 25);
            this.label16.TabIndex = 16;
            this.label16.Text = "光盘镜像位置：";
            // 
            // cdr_img
            // 
            this.cdr_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cdr_img.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cdr_img.Location = new System.Drawing.Point(32, 738);
            this.cdr_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cdr_img.Name = "cdr_img";
            this.cdr_img.Size = new System.Drawing.Size(511, 32);
            this.cdr_img.TabIndex = 32;
            // 
            // hdd_img
            // 
            this.hdd_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hdd_img.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.hdd_img.Location = new System.Drawing.Point(32, 674);
            this.hdd_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hdd_img.Name = "hdd_img";
            this.hdd_img.Size = new System.Drawing.Size(511, 32);
            this.hdd_img.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label6.Location = new System.Drawing.Point(26, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(430, 75);
            this.label6.TabIndex = 15;
            this.label6.Text = "\r\n注意：如某项留空，客户机将不会安装该项硬件。\r\n硬盘镜像位置：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label7.Location = new System.Drawing.Point(26, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 62);
            this.label7.TabIndex = 14;
            this.label7.Text = "\r\n储存";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label5.Location = new System.Drawing.Point(29, 484);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(606, 50);
            this.label5.TabIndex = 13;
            this.label5.Text = "警告：若内存设置得太大，QEMU可能会无法启动（对于32位QEMU）\r\n或机器卡死（对于小内存的客户机）。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label3.Location = new System.Drawing.Point(29, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "\r\n大小（单位MB）：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label4.Location = new System.Drawing.Point(26, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 62);
            this.label4.TabIndex = 18;
            this.label4.Text = "\r\n内存（RAM）";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label41.Location = new System.Drawing.Point(34, 1281);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(107, 25);
            this.label41.TabIndex = 66;
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
            this.net_mod.TabIndex = 52;
            // 
            // net_host_port
            // 
            this.net_host_port.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.net_host_port.Location = new System.Drawing.Point(274, 1235);
            this.net_host_port.Margin = new System.Windows.Forms.Padding(4);
            this.net_host_port.Name = "net_host_port";
            this.net_host_port.Size = new System.Drawing.Size(132, 32);
            this.net_host_port.TabIndex = 51;
            // 
            // net_vm_port
            // 
            this.net_vm_port.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.net_vm_port.Location = new System.Drawing.Point(274, 1194);
            this.net_vm_port.Margin = new System.Windows.Forms.Padding(4);
            this.net_vm_port.Name = "net_vm_port";
            this.net_vm_port.Size = new System.Drawing.Size(132, 32);
            this.net_vm_port.TabIndex = 50;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label40.Location = new System.Drawing.Point(36, 1239);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(164, 25);
            this.label40.TabIndex = 65;
            this.label40.Text = "对应的主机端口：";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label39.Location = new System.Drawing.Point(36, 1197);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(221, 25);
            this.label39.TabIndex = 64;
            this.label39.Text = "需要映射的虚拟机端口：";
            // 
            // vnc_port
            // 
            this.vnc_port.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vnc_port.Location = new System.Drawing.Point(555, 1400);
            this.vnc_port.Margin = new System.Windows.Forms.Padding(4);
            this.vnc_port.Name = "vnc_port";
            this.vnc_port.Size = new System.Drawing.Size(97, 32);
            this.vnc_port.TabIndex = 53;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label38.Location = new System.Drawing.Point(33, 1382);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(494, 50);
            this.label38.TabIndex = 63;
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
            this.label37.TabIndex = 62;
            this.label37.Text = "\r\nVNC连接";
            // 
            // vga_mod
            // 
            this.vga_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vga_mod.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.vga_mod.FormattingEnabled = true;
            this.vga_mod.Items.AddRange(new object[] {
            "Cirrus Logic GD5446 Video card",
            "Standard VGA card with Bochs VBE extensions(默认)",
            "VMWare SVGA-II compatible adapter",
            "QXL paravirtual graphic card",
            "Sun TCX framebuffer",
            "Sun cgthree framebuffer",
            "Virtio VGA card",
            "(禁用VGA显示卡)"});
            this.vga_mod.Location = new System.Drawing.Point(115, 1064);
            this.vga_mod.Margin = new System.Windows.Forms.Padding(4);
            this.vga_mod.Name = "vga_mod";
            this.vga_mod.Size = new System.Drawing.Size(541, 32);
            this.vga_mod.TabIndex = 49;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("微软雅黑", 11.25F);
            this.label36.Location = new System.Drawing.Point(35, 1044);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(69, 50);
            this.label36.TabIndex = 61;
            this.label36.Text = "\r\n型号：";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label35.Location = new System.Drawing.Point(33, 982);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(62, 62);
            this.label35.TabIndex = 58;
            this.label35.Text = "\r\n显卡";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label26.Location = new System.Drawing.Point(30, 1801);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(601, 100);
            this.label26.TabIndex = 43;
            this.label26.Text = "说明：\r\n1.如不填，则使用宿主机时间(-localhost)\r\n2.若填满前三空（年、月、日）才会启动自定义日期（此时设定的时间\r\n为0:00），若继续填满后三" +
    "个空（时、分、秒）才会启用自定义时间。";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label25.Location = new System.Drawing.Point(29, 1710);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(189, 50);
            this.label25.TabIndex = 42;
            this.label25.Text = "\r\n手动设置BIOS时间：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label22.Location = new System.Drawing.Point(628, 1767);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 25);
            this.label22.TabIndex = 41;
            this.label22.Text = "秒";
            // 
            // time_sec
            // 
            this.time_sec.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.time_sec.Location = new System.Drawing.Point(561, 1763);
            this.time_sec.Margin = new System.Windows.Forms.Padding(4);
            this.time_sec.Name = "time_sec";
            this.time_sec.Size = new System.Drawing.Size(59, 32);
            this.time_sec.TabIndex = 60;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label23.Location = new System.Drawing.Point(523, 1767);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(31, 25);
            this.label23.TabIndex = 39;
            this.label23.Text = "分";
            // 
            // time_min
            // 
            this.time_min.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.time_min.Location = new System.Drawing.Point(456, 1763);
            this.time_min.Margin = new System.Windows.Forms.Padding(4);
            this.time_min.Name = "time_min";
            this.time_min.Size = new System.Drawing.Size(59, 32);
            this.time_min.TabIndex = 59;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label24.Location = new System.Drawing.Point(417, 1767);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(31, 25);
            this.label24.TabIndex = 38;
            this.label24.Text = "时";
            // 
            // time_hour
            // 
            this.time_hour.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.time_hour.Location = new System.Drawing.Point(351, 1763);
            this.time_hour.Margin = new System.Windows.Forms.Padding(4);
            this.time_hour.Name = "time_hour";
            this.time_hour.Size = new System.Drawing.Size(59, 32);
            this.time_hour.TabIndex = 57;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label21.Location = new System.Drawing.Point(312, 1767);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 25);
            this.label21.TabIndex = 37;
            this.label21.Text = "日";
            // 
            // time_d
            // 
            this.time_d.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.time_d.Location = new System.Drawing.Point(245, 1763);
            this.time_d.Margin = new System.Windows.Forms.Padding(4);
            this.time_d.Name = "time_d";
            this.time_d.Size = new System.Drawing.Size(59, 32);
            this.time_d.TabIndex = 56;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label20.Location = new System.Drawing.Point(207, 1767);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 25);
            this.label20.TabIndex = 36;
            this.label20.Text = "月";
            // 
            // time_m
            // 
            this.time_m.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.time_m.Location = new System.Drawing.Point(140, 1763);
            this.time_m.Margin = new System.Windows.Forms.Padding(4);
            this.time_m.Name = "time_m";
            this.time_m.Size = new System.Drawing.Size(59, 32);
            this.time_m.TabIndex = 55;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label15.Location = new System.Drawing.Point(101, 1767);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 25);
            this.label15.TabIndex = 47;
            this.label15.Text = "年";
            // 
            // time_y
            // 
            this.time_y.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.time_y.Location = new System.Drawing.Point(35, 1763);
            this.time_y.Margin = new System.Windows.Forms.Padding(4);
            this.time_y.Name = "time_y";
            this.time_y.Size = new System.Drawing.Size(59, 32);
            this.time_y.TabIndex = 54;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label19.Location = new System.Drawing.Point(35, 920);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 50);
            this.label19.TabIndex = 46;
            this.label19.Text = "\r\n型号：";
            // 
            // aud_mod
            // 
            this.aud_mod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aud_mod.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.aud_mod.FormattingEnabled = true;
            this.aud_mod.Items.AddRange(new object[] {
            "Intel HD Audio",
            "Intel 82801AA AC97 Audio",
            "ENSONIQ AudioPCI ES1370",
            "全部"});
            this.aud_mod.Location = new System.Drawing.Point(113, 940);
            this.aud_mod.Margin = new System.Windows.Forms.Padding(4);
            this.aud_mod.Name = "aud_mod";
            this.aud_mod.Size = new System.Drawing.Size(543, 32);
            this.aud_mod.TabIndex = 48;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label14.Location = new System.Drawing.Point(32, 1648);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 62);
            this.label14.TabIndex = 44;
            this.label14.Text = "\r\n固件设置";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label13.Location = new System.Drawing.Point(36, 1140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(589, 50);
            this.label13.TabIndex = 45;
            this.label13.Text = "\r\n使用-net user模式连接，并将虚拟机的某端口转换到主机的某端口。";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label12.Location = new System.Drawing.Point(34, 1077);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 62);
            this.label12.TabIndex = 40;
            this.label12.Text = "\r\n网络";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label9.Location = new System.Drawing.Point(30, 845);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 62);
            this.label9.TabIndex = 35;
            this.label9.Text = "\r\n声卡";
            // 
            // usb_dev
            // 
            this.usb_dev.AutoSize = true;
            this.usb_dev.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.usb_dev.Location = new System.Drawing.Point(34, 2177);
            this.usb_dev.Margin = new System.Windows.Forms.Padding(4);
            this.usb_dev.Name = "usb_dev";
            this.usb_dev.Size = new System.Drawing.Size(596, 54);
            this.usb_dev.TabIndex = 73;
            this.usb_dev.Text = "启用USB设备及USB键鼠、触控板支持（PS/2键鼠支持将被禁用）\r\n(-usb -device usb-kbd -device usb-mouse -devic" +
    "e usb-tablet)";
            this.usb_dev.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button5.Location = new System.Drawing.Point(567, 2047);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 34);
            this.button5.TabIndex = 72;
            this.button5.Text = "浏览";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // bios_file
            // 
            this.bios_file.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bios_file.Location = new System.Drawing.Point(39, 2047);
            this.bios_file.Margin = new System.Windows.Forms.Padding(4);
            this.bios_file.Name = "bios_file";
            this.bios_file.Size = new System.Drawing.Size(519, 32);
            this.bios_file.TabIndex = 71;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label10.Location = new System.Drawing.Point(35, 2019);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(341, 25);
            this.label10.TabIndex = 74;
            this.label10.Text = "第三方BIOS文件（如没有，则不填）：";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label32.Location = new System.Drawing.Point(35, 1943);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(582, 75);
            this.label32.TabIndex = 67;
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
            this.boot_sel.TabIndex = 70;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label31.Location = new System.Drawing.Point(35, 1909);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(183, 25);
            this.label31.TabIndex = 68;
            this.label31.Text = "客户机第一启动项：";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label30.Location = new System.Drawing.Point(31, 2083);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(110, 62);
            this.label30.TabIndex = 69;
            this.label30.Text = "\r\n附加参数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14F);
            this.label2.Location = new System.Drawing.Point(35, 1432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 62);
            this.label2.TabIndex = 75;
            this.label2.Text = "\r\n内核(Linux)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label11.Location = new System.Drawing.Point(31, 1494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 50);
            this.label11.TabIndex = 76;
            this.label11.Text = "\r\n内核文件：";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label17.Location = new System.Drawing.Point(34, 1580);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 25);
            this.label17.TabIndex = 77;
            this.label17.Text = "initrd文件：";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button1.Location = new System.Drawing.Point(552, 1544);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 79;
            this.button1.Text = "浏览";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textBox1.Location = new System.Drawing.Point(36, 1546);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(511, 32);
            this.textBox1.TabIndex = 78;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button4.Location = new System.Drawing.Point(555, 1601);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 34);
            this.button4.TabIndex = 81;
            this.button4.Text = "浏览";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textBox2.Location = new System.Drawing.Point(39, 1603);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(511, 32);
            this.textBox2.TabIndex = 80;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微软雅黑", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(28, 2236);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(164, 25);
            this.label27.TabIndex = 84;
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
            this.add_arg.TabIndex = 82;
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
            this.button6.TabIndex = 83;
            this.button6.Text = "确认并启动虚拟机";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(31, 358);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(636, 25);
            this.label28.TabIndex = 85;
            this.label28.Text = "注意：“cortex-a53“和\"cortex-a57”型号的CPU仅限arm64架构使用。";
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.Silver;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.button7.Location = new System.Drawing.Point(548, 800);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(100, 34);
            this.button7.TabIndex = 88;
            this.button7.Text = "浏览";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label29.Location = new System.Drawing.Point(26, 772);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(182, 25);
            this.label29.TabIndex = 86;
            this.label29.Text = "USB储存镜像位置：";
            // 
            // usb_img
            // 
            this.usb_img.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usb_img.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.usb_img.Location = new System.Drawing.Point(30, 800);
            this.usb_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usb_img.Name = "usb_img";
            this.usb_img.Size = new System.Drawing.Size(511, 32);
            this.usb_img.TabIndex = 87;
            // 
            // emu_arm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.usb_img);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.add_arg);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usb_dev);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bios_file);
            this.Controls.Add(this.label10);
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
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.time_sec);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.time_min);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.time_hour);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.time_d);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.time_m);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.time_y);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "emu_arm";
            this.Size = new System.Drawing.Size(693, 2481);
            this.Load += new System.EventHandler(this.emu_arm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox net_mod;
        private System.Windows.Forms.TextBox net_host_port;
        private System.Windows.Forms.TextBox net_vm_port;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox vnc_port;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox vga_mod;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox time_sec;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox time_min;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox time_hour;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox time_d;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox time_m;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox time_y;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox aud_mod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox usb_dev;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox bios_file;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox boot_sel;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label27;
        public System.Windows.Forms.TextBox add_arg;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox usb_img;
    }
}
