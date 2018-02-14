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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ppc = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.btn_arm = new System.Windows.Forms.Button();
            this.btn_x86 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(202, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.MinimumSize = new System.Drawing.Size(707, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(844, 705);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btn_ppc);
            this.panel1.Controls.Add(this.btn_set);
            this.panel1.Controls.Add(this.btn_arm);
            this.panel1.Controls.Add(this.btn_x86);
            this.panel1.Location = new System.Drawing.Point(0, -8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 716);
            this.panel1.TabIndex = 13;
            // 
            // btn_ppc
            // 
            this.btn_ppc.BackColor = System.Drawing.Color.Transparent;
            this.btn_ppc.FlatAppearance.BorderSize = 0;
            this.btn_ppc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ppc.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_ppc.ForeColor = System.Drawing.Color.Black;
            this.btn_ppc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ppc.Location = new System.Drawing.Point(0, 148);
            this.btn_ppc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ppc.Name = "btn_ppc";
            this.btn_ppc.Size = new System.Drawing.Size(201, 50);
            this.btn_ppc.TabIndex = 4;
            this.btn_ppc.Text = " QEMU PPC";
            this.btn_ppc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ppc.UseVisualStyleBackColor = false;
            this.btn_ppc.Click += new System.EventHandler(this.btn_ppc_Click);
            // 
            // btn_set
            // 
            this.btn_set.BackColor = System.Drawing.Color.Transparent;
            this.btn_set.FlatAppearance.BorderSize = 0;
            this.btn_set.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_set.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_set.ForeColor = System.Drawing.Color.Black;
            this.btn_set.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_set.Location = new System.Drawing.Point(0, 202);
            this.btn_set.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(201, 50);
            this.btn_set.TabIndex = 3;
            this.btn_set.Text = " 设置";
            this.btn_set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_set.UseVisualStyleBackColor = false;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // btn_arm
            // 
            this.btn_arm.BackColor = System.Drawing.Color.Transparent;
            this.btn_arm.Enabled = false;
            this.btn_arm.FlatAppearance.BorderSize = 0;
            this.btn_arm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_arm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_arm.ForeColor = System.Drawing.Color.Black;
            this.btn_arm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arm.Location = new System.Drawing.Point(0, 94);
            this.btn_arm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_arm.Name = "btn_arm";
            this.btn_arm.Size = new System.Drawing.Size(201, 50);
            this.btn_arm.TabIndex = 2;
            this.btn_arm.Text = " QEMU arm";
            this.btn_arm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_arm.UseVisualStyleBackColor = false;
            this.btn_arm.Click += new System.EventHandler(this.btn_arm_Click);
            // 
            // btn_x86
            // 
            this.btn_x86.BackColor = System.Drawing.Color.Transparent;
            this.btn_x86.FlatAppearance.BorderSize = 0;
            this.btn_x86.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x86.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_x86.ForeColor = System.Drawing.Color.Black;
            this.btn_x86.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_x86.Location = new System.Drawing.Point(0, 40);
            this.btn_x86.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_x86.Name = "btn_x86";
            this.btn_x86.Size = new System.Drawing.Size(201, 50);
            this.btn_x86.TabIndex = 1;
            this.btn_x86.Text = " QEMU x86";
            this.btn_x86.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_x86.UseVisualStyleBackColor = false;
            this.btn_x86.Click += new System.EventHandler(this.btn_x86_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::QEMU_Panel.Properties.Resources.img1_blue;
            this.ClientSize = new System.Drawing.Size(1045, 701);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1061, 363);
            this.Name = "Form1";
            this.Text = "QEMU Panel (Beta)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Button btn_x86;
        private System.Windows.Forms.Panel panel3;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Button btn_arm;
        private System.Windows.Forms.Button btn_ppc;
    }
}

