﻿namespace QEMU_Panel
{
    partial class Form1
    {

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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_bt = new System.Windows.Forms.Panel();
            this.btn_ppc = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_arm = new System.Windows.Forms.Button();
            this.btn_x86 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.panel_bt);
            this.panel1.Controls.Add(this.btn_ppc);
            this.panel1.Controls.Add(this.btn_set);
            this.panel1.Controls.Add(this.btn_arm);
            this.panel1.Controls.Add(this.btn_x86);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 716);
            this.panel1.TabIndex = 13;
            // 
            // panel_bt
            // 
            this.panel_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.panel_bt.Location = new System.Drawing.Point(0, 88);
            this.panel_bt.Margin = new System.Windows.Forms.Padding(4);
            this.panel_bt.Name = "panel_bt";
            this.panel_bt.Size = new System.Drawing.Size(7, 50);
            this.panel_bt.TabIndex = 0;
            this.panel_bt.Visible = false;
            // 
            // btn_ppc
            // 
            this.btn_ppc.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_ppc.FlatAppearance.BorderSize = 0;
            this.btn_ppc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ppc.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_ppc.ForeColor = System.Drawing.Color.Black;
            this.btn_ppc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ppc.Location = new System.Drawing.Point(0, 196);
            this.btn_ppc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ppc.Name = "btn_ppc";
            this.btn_ppc.Size = new System.Drawing.Size(328, 50);
            this.btn_ppc.TabIndex = 4;
            this.btn_ppc.Text = "  运行QEMU PowerPC";
            this.btn_ppc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ppc.UseVisualStyleBackColor = false;
            this.btn_ppc.Click += new System.EventHandler(this.btn_ppc_Click);
            // 
            // btn_set
            // 
            this.btn_set.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_set.FlatAppearance.BorderSize = 0;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_set.ForeColor = System.Drawing.Color.Black;
            this.btn_set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_set.Location = new System.Drawing.Point(0, 658);
            this.btn_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(322, 50);
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = "  设置";
            this.btn_set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_arm
            // 
            this.btn_arm.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_arm.FlatAppearance.BorderSize = 0;
            this.btn_arm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_arm.ForeColor = System.Drawing.Color.Black;
            this.btn_arm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arm.Location = new System.Drawing.Point(0, 142);
            this.btn_arm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_arm.Name = "btn_arm";
            this.btn_arm.Size = new System.Drawing.Size(328, 50);
            this.btn_arm.TabIndex = 2;
            this.btn_arm.Text = "  运行QEMU arm";
            this.btn_arm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arm.UseVisualStyleBackColor = false;
            this.btn_arm.Click += new System.EventHandler(this.btn_arm_Click);
            // 
            // btn_x86
            // 
            this.btn_x86.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_x86.FlatAppearance.BorderSize = 0;
            this.btn_x86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x86.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_x86.ForeColor = System.Drawing.Color.Black;
            this.btn_x86.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_x86.Location = new System.Drawing.Point(0, 88);
            this.btn_x86.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_x86.Name = "btn_x86";
            this.btn_x86.Size = new System.Drawing.Size(328, 50);
            this.btn_x86.TabIndex = 1;
            this.btn_x86.Text = "  运行QEMU x86";
            this.btn_x86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_x86.UseVisualStyleBackColor = false;
            this.btn_x86.Click += new System.EventHandler(this.btn_x86_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(315, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MinimumSize = new System.Drawing.Size(707, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 705);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.button5);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(731, 705);
            this.panel4.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.ForeColor = System.Drawing.SystemColors.Menu;
            this.button5.Location = new System.Drawing.Point(515, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 125);
            this.button5.TabIndex = 6;
            this.button5.Text = "设置";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.Menu;
            this.button3.Location = new System.Drawing.Point(384, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 125);
            this.button3.TabIndex = 4;
            this.button3.Text = "QEMU PPC";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.Menu;
            this.button2.Location = new System.Drawing.Point(253, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 125);
            this.button2.TabIndex = 3;
            this.button2.Text = "QEMU arm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.button1.BackgroundImage = global::QEMU_Panel.Properties.Resources.icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.Menu;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(122, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 125);
            this.button1.TabIndex = 2;
            this.button1.Text = "QEMU x86";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(243, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎使用QEMU Panel!";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label2.Location = new System.Drawing.Point(206, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "若要开始，请从左侧菜单栏选择一项任务。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1045, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1061, 363);
            this.Name = "Form1";
            this.Text = "QEMU Panel Pre-Beta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_x86;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel panel_bt;
        private System.Windows.Forms.Button btn_arm;
        private System.Windows.Forms.Button btn_ppc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

