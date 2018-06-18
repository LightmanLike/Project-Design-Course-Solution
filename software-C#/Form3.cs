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
    public partial class Form3 : Form
    {
        public Form3()
        {
            Open();
            InitializeComponent();
        }
        private SerialPort serial = new SerialPort();

        private string receiveData;
        private void Open()
        {
            try
            {
                //配置串口
                //TODO:在这里吧name写死
                serial.PortName = "COM3";
                serial.BaudRate = 115200;
                serial.Parity = (System.IO.Ports.Parity)Enum.Parse(typeof(System.IO.Ports.Parity), "None");
                serial.DataBits = 8;
                serial.StopBits = (System.IO.Ports.StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), "1");
                //设置串口编码为default：获取操作系统的当前 ANSI 代码页的编码。
                serial.Encoding = Encoding.Default;
                //添加串口事件处理
                serial.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(ReceiveData);
                //开启串口
                serial.Open();
            }
            catch { }
        }
        private delegate void UpdateUiTextDelegate(string text);
        private void ReceiveData(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            receiveData = serial.ReadExisting();
            MessageBox.Show(receiveData, "Error");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
  
}
