using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace jieyouzahuodian
{
    public partial class Form9 : Form
    {


        public Form9()
        {
            InitializeComponent();
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                serialPort1.PortName = "COM3";//设置串口号
                serialPort1.BaudRate = 115200;// Conv5ert.ToInt32(comboBox2.Text, 10);//十进制数据转换，设置波特率
                serialPort1.Open();//打开串口
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);//添加事件处理程序

                button1.Enabled = false;//打开串口按钮不可用
                button2.Enabled = true;//关闭串口按钮可用
            
           /* catch
            {
                MessageBox.Show("开启失败，请检查端口连接", "错误");
            }*/
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*if (!radioButton3.Checked)//如果接收模式为字符模式
            {
                string str = serialPort1.ReadExisting();//字符串方式读
                textBox1.AppendText(str);//添加内容textBox文本框中依次向后显示

            }
            else //如果接收模式为数值接收*/
            //{
            //易出现异常：由于线程退出或应用程序请求，已中止 I/O 操作
            //加入异常处理
            try
            {
                //int data;
                //data = serialPort1.ReadByte();
                //string str = Convert.ToString(data, 16).ToUpper();//转换为大写十六进制字符串*/

                //string data = "";
                int count = serialPort1.BytesToRead;
                byte[] byteBar = new byte[count];
                serialPort1.Read(byteBar, 0, count);
                string str = "";
                for (int i = 0; i < byteBar.Length; i++)
                {
                    str += byteBar[i].ToString("X2");
                }
                if (str == "01")
                {
                    textBox1.AppendText("黄色\n");
                }
                if (str == "03")
                {
                    textBox1.AppendText("绿色\n");
                }
                if (str == "05")
                {
                    textBox1.AppendText("红色\n");
                }
                if (str == "02")
                {
                    textBox1.AppendText("粉色\n");
                }
                if (str == "04")
                {
                    textBox1.AppendText("蓝色\n");
                }
                if (str == "06")
                {
                    textBox1.AppendText("紫色\n");
                }
                /*if(str == "15180B")
                {
                    textBox1.AppendText("绿色\n");
                }        
                */

                /*if(str.Length == 2)
                {
                    textBox1.AppendText("距离为" + str + '\n');
                }*/
                //textBox1.AppendText(str + '\n');

                /*for (int i = 0; i < byteBar.Length; i++)
                {
                    data += byteBar[i];
                 }*/
                //textBox1.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");//空位补“0”   
            }
            catch
            {
                this.Close();//关闭当前窗体
            }

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();//关闭串口
                button1.Enabled = true;//打开串口按钮可用
                button2.Enabled = false;//关闭串口按钮不可用
            }
            catch
            {
                MessageBox.Show("串口关闭错误", "错误");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form5().Show();
        }

    }
}
