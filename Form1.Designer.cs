namespace QEMU_Panel
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_arm = new System.Windows.Forms.Button();
            this.btn_x86 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.panel_bt);
            this.panel1.Controls.Add(this.btn_ppc);
            this.panel1.Controls.Add(this.panel2);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 80);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 54);
            this.label6.TabIndex = 0;
            this.label6.Text = "欢迎使用QEMU Panel Pre-Beta！\r\n要开始，请选择一项任务：";
            // 
            // btn_set
            // 
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
            this.btn_x86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(81)))), ((int)(((byte)(184)))));
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
            this.panel3.Location = new System.Drawing.Point(315, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MinimumSize = new System.Drawing.Size(707, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(731, 705);
            this.panel3.TabIndex = 6;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_x86;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel panel_bt;
        private System.Windows.Forms.Button btn_arm;
        private System.Windows.Forms.Button btn_ppc;
    }
}

