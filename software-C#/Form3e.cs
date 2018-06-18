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
    public partial class Form3e : Form
    {
        public Form3e()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Form1e().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form8e().Show();
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

        

        private void Form3e_Load(object sender, EventArgs e)
        {

        }
    }
}
