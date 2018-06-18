namespace jieyouzahuodian
{
    partial class Form2e
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2e));
            this.zhanghao_ch = new System.Windows.Forms.TextBox();
            this.mima_ch = new System.Windows.Forms.TextBox();
            this.label1_ch = new System.Windows.Forms.Label();
            this.label2_ch = new System.Windows.Forms.Label();
            this.denglu_ch = new System.Windows.Forms.Button();
            this.weihufanhui_en = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // zhanghao_ch
            // 
            this.zhanghao_ch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhanghao_ch.Location = new System.Drawing.Point(160, 84);
            this.zhanghao_ch.Name = "zhanghao_ch";
            this.zhanghao_ch.Size = new System.Drawing.Size(312, 30);
            this.zhanghao_ch.TabIndex = 0;
            // 
            // mima_ch
            // 
            this.mima_ch.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mima_ch.Location = new System.Drawing.Point(161, 156);
            this.mima_ch.Name = "mima_ch";
            this.mima_ch.PasswordChar = '*';
            this.mima_ch.Size = new System.Drawing.Size(311, 30);
            this.mima_ch.TabIndex = 1;
            // 
            // label1_ch
            // 
            this.label1_ch.AutoSize = true;
            this.label1_ch.BackColor = System.Drawing.Color.Transparent;
            this.label1_ch.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1_ch.ForeColor = System.Drawing.SystemColors.Control;
            this.label1_ch.Location = new System.Drawing.Point(39, 84);
            this.label1_ch.Name = "label1_ch";
            this.label1_ch.Size = new System.Drawing.Size(94, 24);
            this.label1_ch.TabIndex = 2;
            this.label1_ch.Text = "Account";
            // 
            // label2_ch
            // 
            this.label2_ch.AutoSize = true;
            this.label2_ch.BackColor = System.Drawing.Color.Transparent;
            this.label2_ch.Font = new System.Drawing.Font("幼圆", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2_ch.ForeColor = System.Drawing.SystemColors.Control;
            this.label2_ch.Location = new System.Drawing.Point(41, 164);
            this.label2_ch.Name = "label2_ch";
            this.label2_ch.Size = new System.Drawing.Size(106, 24);
            this.label2_ch.TabIndex = 3;
            this.label2_ch.Text = "Password";
            // 
            // denglu_ch
            // 
            this.denglu_ch.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.denglu_ch.Location = new System.Drawing.Point(502, 109);
            this.denglu_ch.Name = "denglu_ch";
            this.denglu_ch.Size = new System.Drawing.Size(107, 47);
            this.denglu_ch.TabIndex = 4;
            this.denglu_ch.Text = "Login";
            this.denglu_ch.UseVisualStyleBackColor = true;
            this.denglu_ch.Click += new System.EventHandler(this.denglu_ch_Click);
            // 
            // weihufanhui_en
            // 
            this.weihufanhui_en.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weihufanhui_en.Location = new System.Drawing.Point(14, 12);
            this.weihufanhui_en.Name = "weihufanhui_en";
            this.weihufanhui_en.Size = new System.Drawing.Size(86, 33);
            this.weihufanhui_en.TabIndex = 5;
            this.weihufanhui_en.Text = "Menu";
            this.weihufanhui_en.UseVisualStyleBackColor = true;
            this.weihufanhui_en.Click += new System.EventHandler(this.weihufanhui_ch_Click);
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
            // Form2e
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.weihufanhui_en);
            this.Controls.Add(this.denglu_ch);
            this.Controls.Add(this.label2_ch);
            this.Controls.Add(this.label1_ch);
            this.Controls.Add(this.mima_ch);
            this.Controls.Add(this.zhanghao_ch);
            this.Name = "Form2e";
            this.Text = "Maintenance Mode Login";
            this.Load += new System.EventHandler(this.Form2e_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox zhanghao_ch;
        private System.Windows.Forms.TextBox mima_ch;
        private System.Windows.Forms.Label label1_ch;
        private System.Windows.Forms.Label label2_ch;
        private System.Windows.Forms.Button denglu_ch;
        private System.Windows.Forms.Button weihufanhui_en;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}