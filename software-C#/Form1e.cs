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
    public partial class Form1e : Form
    {
        public Form1e()
        {
            InitializeComponent();
        }

        private void weihu_ch_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Form2e().Show();
        }

      

        private void help_ch_Click(object sender, EventArgs e)
        {
            new Form4e().Show();
        }

        private void goumai_ch_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Form3e().Show();
            
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

        private void Form1e_Load(object sender, EventArgs e)
        {

        }

        private void chinese_Click(object sender, EventArgs e)
        {

        }

        private void chinese_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("IEXPLORE.EXE", "http://47.104.156.14:8090/");
        }

        
    }
}
