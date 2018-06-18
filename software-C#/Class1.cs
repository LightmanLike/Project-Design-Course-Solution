using System;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Threading;

namespace jieyouzahuodian
{


    public class Class1
    {
        /// <summary>
        /// 调取token https://openapi.baidu.com/oauth/2.0/token?grant_type=client_credentials&client_id=7HPFhnxLt6CnzbYLCEPF9ZUP&client_secret=24ff3d8e24c70ff78c81ed370366e4f7
        /// </summary>
        /// 


        public static string guomingyuan = "0000";
        private const string lan = "zh";
        private const string per = "0";
        private const string ctp = "1";
        private const string spd = "3";
        private const string pit = "6";
        private const string vol = "9";
        private const string cuid = "E4-02-9B-F7-38-CA";
        public string tex = "";
        private string token = "24.0c7dc07257976940b3d581828571085c.2592000.1531366223.282335-11349503";
        private const string rest = "tex={0}&lan={1}&per={2}&ctp={3}&cuid={4}&tok={5}&spd={6}&pit={7}&vol={8}";
        private const int NULL = 0, ERROR_SUCCESS = NULL;
        [DllImport("WinMm.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int mciSendString(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        public static int n = 1;
        public void msg(string tex_1)
        {
            this.tex = tex_1;
            play();
        }
        private void write()
        {
            if (!File.Exists("C:\\mp3\\" + Convert.ToString(n) + ".mp3"))
            {

                FileStream fs1 = new FileStream("C:\\mp3\\" + Convert.ToString(n) + ".mp3", FileMode.Create, FileAccess.Write);//创建写入文件 
                fs1.Close();
            }

        }

        private void play()
        {
            string strUpdateData = string.Format(rest, tex, lan, per, ctp, cuid, token, spd, pit, vol);
            HttpWebRequest req = WebRequest.Create("http://tsn.baidu.com/text2audio") as HttpWebRequest;
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = Encoding.UTF8.GetByteCount(strUpdateData);
            using (StreamWriter sw = new StreamWriter(req.GetRequestStream()))
                sw.Write(strUpdateData);
            HttpWebResponse res = req.GetResponse() as HttpWebResponse;
            using (Stream stream = res.GetResponseStream())
            {
                write();
                string strFullFileName = "C:\\mp3\\" + Convert.ToString(n) + ".mp3";
                using (FileStream fs = new FileStream(strFullFileName, FileMode.Truncate | FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
                    stream.CopyTo(fs);
                if (mciSendString(string.Format("open \"{0}\" alias " + Convert.ToString(n), strFullFileName), null, NULL, NULL) == ERROR_SUCCESS)
                    mciSendString("play " + Convert.ToString(n), null, NULL, NULL);
                n++;



            }
        }

        public string num2word(int n)
        {
            if (n < 20)
            {
                switch (n)
                {
                    case 1:
                        return "one";
                    case 2:
                        return "two";
                    case 3:
                        return "three";
                    case 4:
                        return "four";
                    case 5:
                        return "five";
                    case 6:
                        return "sex";
                    case 7:
                        return "seven";
                    case 8:
                        return "eight";
                    case 9:
                        return "nine";
                    case 10:
                        return "ten";
                    case 11:
                        return "eleven";
                    case 12:
                        return "twelve";
                    case 13:
                        return "thirteen";
                    case 14:
                        return "fourteen";
                    case 15:
                        return "fifteen";
                    case 16:
                        return "sixteen";
                    case 17:
                        return "seventeen";
                    case 18:
                        return "eighteen";
                    case 19:
                        return "nineteen";
                    default:
                        return "";

                }
            }
            else return "";

        }
    }
}

