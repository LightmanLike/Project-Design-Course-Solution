namespace jieyouzahuodian
{
    partial class Form1e
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1e));
            this.weihu_ch = new System.Windows.Forms.Button();
            this.goumai_ch = new System.Windows.Forms.Button();
            this.help_ch = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.chinese = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weihu_ch
            // 
            this.weihu_ch.BackColor = System.Drawing.SystemColors.Control;
            this.weihu_ch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("weihu_ch.BackgroundImage")));
            this.weihu_ch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weihu_ch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weihu_ch.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weihu_ch.Location = new System.Drawing.Point(430, 271);
            this.weihu_ch.Name = "weihu_ch";
            this.weihu_ch.Size = new System.Drawing.Size(261, 72);
            this.weihu_ch.TabIndex = 0;
            this.weihu_ch.UseVisualStyleBackColor = false;
            this.weihu_ch.Click += new System.EventHandler(this.weihu_ch_Click);
            // 
            // goumai_ch
            // 
            this.goumai_ch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("goumai_ch.BackgroundImage")));
            this.goumai_ch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.goumai_ch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goumai_ch.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.goumai_ch.Location = new System.Drawing.Point(430, 199);
            this.goumai_ch.Name = "goumai_ch";
            this.goumai_ch.Size = new System.Drawing.Size(260, 66);
            this.goumai_ch.TabIndex = 1;
            this.goumai_ch.UseVisualStyleBackColor = true;
            this.goumai_ch.Click += new System.EventHandler(this.goumai_ch_Click);
            // 
            // help_ch
            // 
            this.help_ch.Cursor = System.Windows.Forms.Cursors.Help;
            this.help_ch.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.help_ch.Image = ((System.Drawing.Image)(resources.GetObject("help_ch.Image")));
            this.help_ch.Location = new System.Drawing.Point(9, 316);
            this.help_ch.Name = "help_ch";
            this.help_ch.Size = new System.Drawing.Size(60, 24);
            this.help_ch.TabIndex = 2;
            this.help_ch.Text = "Help";
            this.help_ch.UseVisualStyleBackColor = true;
            this.help_ch.Click += new System.EventHandler(this.help_ch_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "程序运行中";
            this.notifyIcon1.BalloonTipTitle = "解忧杂货店";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "解忧杂货店";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // chinese
            // 
            this.chinese.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chinese.Font = new System.Drawing.Font("幼圆", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chinese.Image = ((System.Drawing.Image)(resources.GetObject("chinese.Image")));
            this.chinese.Location = new System.Drawing.Point(12, 12);
            this.chinese.Name = "chinese";
            this.chinese.Size = new System.Drawing.Size(99, 37);
            this.chinese.TabIndex = 3;
            this.chinese.Text = "中文（简体）";
            this.chinese.UseVisualStyleBackColor = true;
            this.chinese.Click += new System.EventHandler(this.chinese_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("幼圆", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "English";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("华文琥珀", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(548, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "About  us ！";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 355);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chinese);
            this.Controls.Add(this.help_ch);
            this.Controls.Add(this.goumai_ch);
            this.Controls.Add(this.weihu_ch);
            this.Name = "Form1e";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1e_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button weihu_ch;
        private System.Windows.Forms.Button goumai_ch;
        private System.Windows.Forms.Button help_ch;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button chinese;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

