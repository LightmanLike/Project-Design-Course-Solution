﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace jieyouzahuodian
{
    public partial class Form5 : Form
    {
       






        public Form5()
        {
            InitializeComponent();
        }


        private void run_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form10().Show();


        }

        private void data_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form9().Show();
        }

        private void information_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
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

    

        private void button2_Click(object sender, EventArgs e)
        {
           
            

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


    }
}

