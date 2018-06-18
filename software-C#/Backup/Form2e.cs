using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jieyouzahuodian
{
    public partial class Form2e : Form
    {
        public Form2e()
        {
            InitializeComponent();
        }

        private void denglu_ch_Click(object sender, EventArgs e)
        {
            if ((zhanghao_ch.Text == "Jieyouvip01" && mima_ch.Text == "000032") || (zhanghao_ch.Text == "Jieyouvip02" && mima_ch.Text == "000032"))
            {
                this.Hide(); 
                new Form5().Show();
                
                
            }
            else
            {
                MessageBox.Show("用户名或密码有误");
            }
        }

        private void weihufanhui_ch_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Form1e().Show();
        }

        private void Form2e_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Minimized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                this.notifyIcon1.ShowBalloonTip(100);//100指的是时间，如果时间后面没有参数的话那么那些文本默认都会显示


            }
            else
                this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        
    }
}
