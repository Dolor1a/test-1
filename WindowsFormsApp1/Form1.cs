using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class PortTest : Form

    {
        public PortTest()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
            this.MaximizeBox = false;
            this.FormBorderStyle =FormBorderStyle.FixedSingle;
            
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            scan();

        }

        bool isOpened = false;//串口状态标志
        private void OpenProdbtn_Click(object sender, EventArgs e)
        {
            if (!isOpened)
            {
               
                if (ProtNO.Text =="")
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("请选择串口号","提示");
                }
                else if (Baud.Text =="")
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("请选择波特率","提示");
                }
                else { 
                serialPort1.PortName = ProtNO.Text;
                serialPort1.BaudRate = Convert.ToInt32(Baud.Text, 10);
                    try
                    {
                        Openprot();
                    }
                    catch
                    {
                        SystemSounds.Beep.Play();
                        MessageBoxButtons messButton = MessageBoxButtons.RetryCancel;
                        DialogResult dr = MessageBox.Show("串口打开失败或串口被占用！", "错误", messButton);

                        if (dr == DialogResult.Retry)//如果点击“确定”按钮
                        {
                            OpenProdbtn_Click(0, e);
                        }
                        else//如果点击“取消”按钮

                        {
                        }
                    }
                }
            }
            else
            {
                Closeprot();
            }

        }
        private void Post_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadExisting();//字符串方式读
            //Reception.Text = "";//先清除上一次的数据
            Reception.Text +="\r\n"+ str;
        }

        private void Sendbtn_Click(object sender, EventArgs e)
        {
            //发送数据
            if (serialPort1.IsOpen)
            {//如果串口开启
                if (Send.Text.Trim() != "")//如果框内不为空则
                {
                    serialPort1.Write(Send.Text.Trim());//写数据
                    Console.WriteLine(Send.Text.Trim());

                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("发送框没有数据");
                }
            }
            else
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("串口未打开");
            }
        }
        //扫描串口按钮
        
        private void Scanbtn_Click(object sender, EventArgs e)
        {
            scan();
            MessageBox.Show("扫描串口完成", "提示");
        }

        private void empty_Click(object sender, EventArgs e)
        {
            Reception.Text = "";
        }
   // 扫描串口方法scan()
        public void scan()
            {
            Baud.Text = "115200";
            int j = 1;
            bool comExistence = false;
            ProtNO.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                //循环验证串口是否存在且未被占用
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    ProtNO.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;
                    //添加默认端口号
                    if (j == 1)
                    {
                        j++;
                        ProtNO.Text = "COM" + (i + 1).ToString();
                    }
                }
                //被占用则跳出本次循环
                catch (Exception)
                {
                    continue;
                }
            }
            //未找到串口提示
            if (!comExistence)
            {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("没有找到串口！", "错误提示");
                //没有找到串口则打开串口按钮禁用
                OpenProdbtn.Enabled = false;
                // 没有串口清空串口号
                ProtNO.Text = "";
            }

            else
            {
               //找到串口则打开串口按钮启用
                OpenProdbtn.Enabled = true;
             
            }
        }
        //打开串口方法Openprot()
        public void Openprot()
        {
            serialPort1.Open();     //打开串口
            OpenProdbtn.Text = "关闭串口";
            ProtNO.Enabled = false;//禁止更改串口号与波特率
            Baud.Enabled = false;
            isOpened = true;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(Post_DataReceived);//串口接收处理函数
        }
        //关闭串口方法Closeprot()
        public void Closeprot() { 
            try
                {
                    serialPort1.Close();     //关闭串口
                    OpenProdbtn.Text = "打开串口";
                    ProtNO.Enabled = true;//允许更改串口号与波特率
                    Baud.Enabled = true;
                    isOpened = false;
                }
                catch
                {
                SystemSounds.Asterisk.Play();
                MessageBox.Show("串口关闭失败！");
                }
        }


        private void Reception_TextChanged_1(object sender, EventArgs e)
        {
            //文本框选中的起始点在最后
            Reception.SelectionStart = Reception.TextLength;
            //将控件内容滚动到当前插入符号位置
            Reception.ScrollToCaret();
        }
    }
}
