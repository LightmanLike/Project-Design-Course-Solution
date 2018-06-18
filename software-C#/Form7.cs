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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void end_back_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new Form1().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Int32 A=Convert.ToInt32(label2.Text);
            if (A > 0)
            {
                A = A - 1;
                label2.Text = Convert.ToString(A);
            }
            else if(A == 0)
            {
                this.Hide();
                new Form1().Show();
                label2.Text = Convert.ToString(A-1);
            }          

            

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

        private void Form7_Load(object sender, EventArgs e)
        {

        }
        


        
    }
}
