using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace jieyouzahuodian
{
    public partial class Form1 : Form
    {
        Class1 one = new Class1();
        
        public Form1()
        {
            one.msg("welcome to 华兴");
        
            InitializeComponent();
            
        }

        private void weihu_ch_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Form2().Show();
        }

      

        private void help_ch_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void goumai_ch_Click(object sender, EventArgs e)
        {
            this.Hide();
            one.msg("开始购买，请刷卡");
         
            new Form3().Show();
            
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void English_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1e().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IEXPLORE.EXE", "http://47.104.156.14:8090/");
        }

        
    }
}

// System.Diagnostics.Process.Start("IEXPLORE.EXE", "http://www.baidu.com");
