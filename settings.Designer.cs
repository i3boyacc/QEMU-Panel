namespace QEMU_Panel
{
    partial class settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.theme_light = new System.Windows.Forms.RadioButton();
            this.theme_dark = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.color1 = new System.Windows.Forms.Button();
            this.color2 = new System.Windows.Forms.Button();
            this.color3 = new System.Windows.Forms.Button();
            this.color4 = new System.Windows.Forms.Button();
            this.color5 = new System.Windows.Forms.Button();
            this.color6 = new System.Windows.Forms.Button();
            this.color7 = new System.Windows.Forms.Button();
            this.color8 = new System.Windows.Forms.Button();
            this.color9 = new System.Windows.Forms.Button();
            this.color10 = new System.Windows.Forms.Button();
            this.color14 = new System.Windows.Forms.Button();
            this.color13 = new System.Windows.Forms.Button();
            this.color12 = new System.Windows.Forms.Button();
            this.color11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label2.Location = new System.Drawing.Point(23, 443);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 250);
            this.label2.TabIndex = 1;
            this.label2.Text = "\r\nQEMU Panel Beta 2\r\n版本2.0.220\r\nCopyright 2017 追求i3的孩纸(i3boyacc)\r\n\r\n如何提供反馈？\r\n1.在G" +
    "ithub项目中评论\r\n2.通过邮箱反馈(i3boyacc@outlook.com)\r\n\r\n项目地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 62);
            this.label3.TabIndex = 2;
            this.label3.Text = "\r\n颜色设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "\r\n选择颜色主题";
            // 
            // theme_light
            // 
            this.theme_light.AutoSize = true;
            this.theme_light.Checked = true;
            this.theme_light.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.theme_light.Location = new System.Drawing.Point(28, 177);
            this.theme_light.Name = "theme_light";
            this.theme_light.Size = new System.Drawing.Size(71, 29);
            this.theme_light.TabIndex = 4;
            this.theme_light.TabStop = true;
            this.theme_light.Text = "浅色";
            this.theme_light.UseVisualStyleBackColor = true;
            // 
            // theme_dark
            // 
            this.theme_dark.AutoSize = true;
            this.theme_dark.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.theme_dark.Location = new System.Drawing.Point(27, 212);
            this.theme_dark.Name = "theme_dark";
            this.theme_dark.Size = new System.Drawing.Size(71, 29);
            this.theme_dark.TabIndex = 5;
            this.theme_dark.Text = "深色";
            this.theme_dark.UseVisualStyleBackColor = true;
            this.theme_dark.CheckedChanged += new System.EventHandler(this.theme_dark_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(23, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "选择一种配色（暂不可用）";
            // 
            // color1
            // 
            this.color1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(81)))), ((int)(((byte)(184)))));
            this.color1.Enabled = false;
            this.color1.FlatAppearance.BorderSize = 2;
            this.color1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color1.Location = new System.Drawing.Point(28, 273);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(50, 50);
            this.color1.TabIndex = 7;
            this.color1.UseVisualStyleBackColor = false;
            this.color1.Click += new System.EventHandler(this.color1_Click);
            // 
            // color2
            // 
            this.color2.BackColor = System.Drawing.Color.Maroon;
            this.color2.Enabled = false;
            this.color2.FlatAppearance.BorderSize = 2;
            this.color2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color2.Location = new System.Drawing.Point(84, 272);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(50, 50);
            this.color2.TabIndex = 8;
            this.color2.UseVisualStyleBackColor = false;
            this.color2.Click += new System.EventHandler(this.color2_Click);
            // 
            // color3
            // 
            this.color3.BackColor = System.Drawing.Color.SeaGreen;
            this.color3.Enabled = false;
            this.color3.FlatAppearance.BorderSize = 2;
            this.color3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color3.Location = new System.Drawing.Point(140, 273);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(50, 50);
            this.color3.TabIndex = 9;
            this.color3.UseVisualStyleBackColor = false;
            this.color3.Click += new System.EventHandler(this.color3_Click);
            // 
            // color4
            // 
            this.color4.BackColor = System.Drawing.Color.DarkCyan;
            this.color4.Enabled = false;
            this.color4.FlatAppearance.BorderSize = 2;
            this.color4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color4.Location = new System.Drawing.Point(196, 273);
            this.color4.Name = "color4";
            this.color4.Size = new System.Drawing.Size(50, 50);
            this.color4.TabIndex = 10;
            this.color4.UseVisualStyleBackColor = false;
            this.color4.Click += new System.EventHandler(this.color4_Click);
            // 
            // color5
            // 
            this.color5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.color5.Enabled = false;
            this.color5.FlatAppearance.BorderSize = 2;
            this.color5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color5.Location = new System.Drawing.Point(252, 273);
            this.color5.Name = "color5";
            this.color5.Size = new System.Drawing.Size(50, 50);
            this.color5.TabIndex = 11;
            this.color5.UseVisualStyleBackColor = false;
            this.color5.Click += new System.EventHandler(this.color5_Click);
            // 
            // color6
            // 
            this.color6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.color6.Enabled = false;
            this.color6.FlatAppearance.BorderSize = 2;
            this.color6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color6.Location = new System.Drawing.Point(308, 273);
            this.color6.Name = "color6";
            this.color6.Size = new System.Drawing.Size(50, 50);
            this.color6.TabIndex = 12;
            this.color6.UseVisualStyleBackColor = false;
            this.color6.Click += new System.EventHandler(this.color6_Click);
            // 
            // color7
            // 
            this.color7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(183)))));
            this.color7.Enabled = false;
            this.color7.FlatAppearance.BorderSize = 2;
            this.color7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color7.Location = new System.Drawing.Point(364, 273);
            this.color7.Name = "color7";
            this.color7.Size = new System.Drawing.Size(50, 50);
            this.color7.TabIndex = 13;
            this.color7.UseVisualStyleBackColor = false;
            this.color7.Click += new System.EventHandler(this.color7_Click);
            // 
            // color8
            // 
            this.color8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(16)))));
            this.color8.Enabled = false;
            this.color8.FlatAppearance.BorderSize = 2;
            this.color8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color8.Location = new System.Drawing.Point(420, 273);
            this.color8.Name = "color8";
            this.color8.Size = new System.Drawing.Size(50, 50);
            this.color8.TabIndex = 14;
            this.color8.UseVisualStyleBackColor = false;
            this.color8.Click += new System.EventHandler(this.color8_Click);
            // 
            // color9
            // 
            this.color9.BackColor = System.Drawing.Color.Gold;
            this.color9.Enabled = false;
            this.color9.FlatAppearance.BorderSize = 2;
            this.color9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color9.Location = new System.Drawing.Point(476, 273);
            this.color9.Name = "color9";
            this.color9.Size = new System.Drawing.Size(50, 50);
            this.color9.TabIndex = 15;
            this.color9.UseVisualStyleBackColor = false;
            this.color9.Click += new System.EventHandler(this.color9_Click);
            // 
            // color10
            // 
            this.color10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(68)))), ((int)(((byte)(36)))));
            this.color10.Enabled = false;
            this.color10.FlatAppearance.BorderSize = 2;
            this.color10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color10.Location = new System.Drawing.Point(532, 273);
            this.color10.Name = "color10";
            this.color10.Size = new System.Drawing.Size(50, 50);
            this.color10.TabIndex = 16;
            this.color10.UseVisualStyleBackColor = false;
            this.color10.Click += new System.EventHandler(this.color10_Click);
            // 
            // color14
            // 
            this.color14.BackColor = System.Drawing.Color.Gray;
            this.color14.Enabled = false;
            this.color14.FlatAppearance.BorderSize = 2;
            this.color14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color14.Location = new System.Drawing.Point(196, 329);
            this.color14.Name = "color14";
            this.color14.Size = new System.Drawing.Size(50, 50);
            this.color14.TabIndex = 20;
            this.color14.UseVisualStyleBackColor = false;
            this.color14.Click += new System.EventHandler(this.color14_Click);
            // 
            // color13
            // 
            this.color13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.color13.Enabled = false;
            this.color13.FlatAppearance.BorderSize = 2;
            this.color13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color13.Location = new System.Drawing.Point(140, 328);
            this.color13.Name = "color13";
            this.color13.Size = new System.Drawing.Size(50, 50);
            this.color13.TabIndex = 19;
            this.color13.UseVisualStyleBackColor = false;
            this.color13.Click += new System.EventHandler(this.color13_Click);
            // 
            // color12
            // 
            this.color12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.color12.Enabled = false;
            this.color12.FlatAppearance.BorderSize = 2;
            this.color12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color12.Location = new System.Drawing.Point(84, 328);
            this.color12.Name = "color12";
            this.color12.Size = new System.Drawing.Size(50, 50);
            this.color12.TabIndex = 18;
            this.color12.UseVisualStyleBackColor = false;
            this.color12.Click += new System.EventHandler(this.color12_Click);
            // 
            // color11
            // 
            this.color11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(212)))), ((int)(((byte)(192)))));
            this.color11.Enabled = false;
            this.color11.FlatAppearance.BorderSize = 2;
            this.color11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color11.Location = new System.Drawing.Point(28, 328);
            this.color11.Name = "color11";
            this.color11.Size = new System.Drawing.Size(50, 50);
            this.color11.TabIndex = 17;
            this.color11.UseVisualStyleBackColor = false;
            this.color11.Click += new System.EventHandler(this.color11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(22, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 62);
            this.label6.TabIndex = 21;
            this.label6.Text = "\r\n关于\"QEMU Panel\"";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.Location = new System.Drawing.Point(23, 706);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(399, 25);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/i3boyacc/QEMU-Panel";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.color14);
            this.Controls.Add(this.color13);
            this.Controls.Add(this.color12);
            this.Controls.Add(this.color11);
            this.Controls.Add(this.color10);
            this.Controls.Add(this.color9);
            this.Controls.Add(this.color8);
            this.Controls.Add(this.color7);
            this.Controls.Add(this.color6);
            this.Controls.Add(this.color5);
            this.Controls.Add(this.color4);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.theme_dark);
            this.Controls.Add(this.theme_light);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "settings";
            this.Size = new System.Drawing.Size(693, 812);
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton theme_light;
        private System.Windows.Forms.RadioButton theme_dark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button color1;
        private System.Windows.Forms.Button color2;
        private System.Windows.Forms.Button color3;
        private System.Windows.Forms.Button color4;
        private System.Windows.Forms.Button color5;
        private System.Windows.Forms.Button color6;
        private System.Windows.Forms.Button color7;
        private System.Windows.Forms.Button color8;
        private System.Windows.Forms.Button color9;
        private System.Windows.Forms.Button color10;
        private System.Windows.Forms.Button color14;
        private System.Windows.Forms.Button color13;
        private System.Windows.Forms.Button color12;
        private System.Windows.Forms.Button color11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
