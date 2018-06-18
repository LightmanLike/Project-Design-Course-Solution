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
    public partial class Form8e : Form
    {
        public Form8e()
        {
            InitializeComponent();
            Int32 RA = 5;
            Int32 RB = 5;
            Int32 RC = 5;
            Int32 RD = 5;
            Int32 RE = 5;
            Int32 RF = 5;

            Int32 rA = RA;
            Int32 rB = RB;
            Int32 rC = RC;
            Int32 rD = RD;
            Int32 rE = RE;
            Int32 rF = RF;

            restA.Text = Convert.ToString(rA);
            restB.Text = Convert.ToString(rB);
            restC.Text = Convert.ToString(rC);
            restD.Text = Convert.ToString(rD);
            restE.Text = Convert.ToString(rE);
            restF.Text = Convert.ToString(rF);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult strmsg = MessageBox.Show("Are you sure you want to buy the selected goods?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (strmsg.ToString().Trim() == "OK")
            {
                this.Hide();
                new Form6e().Show();
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult strmsg = MessageBox.Show("Are you sure to back to menu?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (strmsg.ToString().Trim() == "OK")
            {
                this.Hide();
                new Form1e().Show();
            } 
        }

        private void AM_Click(object sender, EventArgs e)
        {
            Int32 RA = 5;
            Int32 A = Convert.ToInt32(numA.Text);
            Int32 rA = Convert.ToInt32(restA.Text);
            if (A > 0)
            {
                A = A - 1;
                numA.Text = Convert.ToString(A);
                rA = RA - A;
                restA.Text = Convert.ToString(rA);
            }
            
                

        }

        private void AP_Click(object sender, EventArgs e)
        {
            Int32 RA = 5;
            Int32 A = Convert.ToInt32(numA.Text);
            Int32 rA = Convert.ToInt32(restA.Text);
            if (rA > 0)
            {
                A = A + 1;
                numA.Text = Convert.ToString(A);
                rA = RA - A;
                restA.Text = Convert.ToString(rA);

            }

        }

        private void BM_Click(object sender, EventArgs e)
        {
            Int32 RB = 5;
            Int32 B = Convert.ToInt32(numB.Text);
            Int32 rB = Convert.ToInt32(restB.Text);
            if (B > 0)
            {
                B = B - 1;
                numB.Text = Convert.ToString(B);
                rB = RB - B;
                restB.Text = Convert.ToString(rB);
            }

        }

        private void BP_Click(object sender, EventArgs e)
        {
            Int32 RB = 5;
            Int32 B = Convert.ToInt32(numB.Text);
            Int32 rB = Convert.ToInt32(restB.Text);
            if (rB > 0)
            {
                B = B + 1;
                numB.Text = Convert.ToString(B);
                rB = RB - B;
                restB.Text = Convert.ToString(rB);

            }
        }

        private void CM_Click(object sender, EventArgs e)
        {
            Int32 RC = 5;
            Int32 C = Convert.ToInt32(numC.Text);
            Int32 rC = Convert.ToInt32(restC.Text);
            if (C > 0)
            {
                C = C - 1;
                numC.Text = Convert.ToString(C);
                rC = RC - C;
                restC.Text = Convert.ToString(rC);
            }

        }

        private void CP_Click(object sender, EventArgs e)
        {
            Int32 RC = 5;
            Int32 C = Convert.ToInt32(numC.Text);
            Int32 rC = Convert.ToInt32(restC.Text);
            if (rC > 0)
            {
                C = C + 1;
                numC.Text = Convert.ToString(C);
                rC = RC - C;
                restC.Text = Convert.ToString(rC);

            }
        }

        private void DM_Click(object sender, EventArgs e)
        {
            Int32 RD = 5;
            Int32 D = Convert.ToInt32(numD.Text);
            Int32 rD = Convert.ToInt32(restD.Text);
            if (D > 0)
            {
                D = D - 1;
                numD.Text = Convert.ToString(D);
                rD = RD - D;
                restD.Text = Convert.ToString(rD);
            }
        }

        private void DP_Click(object sender, EventArgs e)
        {
            Int32 RD = 5;
            Int32 D = Convert.ToInt32(numD.Text);
            Int32 rD = Convert.ToInt32(restD.Text);
            if (rD > 0)
            {
                D = D + 1;
                numD.Text = Convert.ToString(D);
                rD = RD - D;
                restD.Text = Convert.ToString(rD);

            }
        }

        private void EM_Click(object sender, EventArgs e)
        {
            Int32 RE = 5;
            Int32 E = Convert.ToInt32(numE.Text);
            Int32 rE = Convert.ToInt32(restE.Text);
            if (E > 0)
            {
                E = E - 1;
                numE.Text = Convert.ToString(E);
                rE = RE - E;
                restE.Text = Convert.ToString(rE);
            }

        }

        private void EP_Click(object sender, EventArgs e)
        {
            Int32 RE = 5;
            Int32 E = Convert.ToInt32(numE.Text);
            Int32 rE = Convert.ToInt32(restE.Text);
            if (rE > 0)
            {
                E = E + 1;
                numE.Text = Convert.ToString(E);
                rE = RE - E;
                restE.Text = Convert.ToString(rE);

            }
        }

        private void FM_Click(object sender, EventArgs e)
        {
            Int32 RF = 5;
            Int32 F = Convert.ToInt32(numF.Text);
            Int32 rF = Convert.ToInt32(restF.Text);
            if (F > 0)
            {
                F = F - 1;
                numF.Text = Convert.ToString(F);
                rF = RF - F;
                restF.Text = Convert.ToString(rF);
            }
        }

        private void FP_Click(object sender, EventArgs e)
        {
            Int32 RF = 5;
            Int32 F = Convert.ToInt32(numF.Text);
            Int32 rF = Convert.ToInt32(restF.Text);
            if (rF > 0)
            {
                F = F + 1;
                numF.Text = Convert.ToString(F);
                rF = RF - F;
                restF.Text = Convert.ToString(rF);

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

        private void Form8e_Load(object sender, EventArgs e)
        {

        }

      



      
    }
}
