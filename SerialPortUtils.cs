using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.IO
namespace UpperComputer
{
    internal class SerialPortUtils
    {
        public static string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }


        public static SerialPort SerialPort = null;
        public static SerialPort OpenClosePort(string comName, int baud)
        {
            //串口未打开
            if (SerialPort == null || !SerialPort.IsOpen)
            {
                SerialPort = new SerialPort();
                //串口名称
                SerialPort.PortName = comName;
                //波特率
                SerialPort.BaudRate = baud;
                //数据位
                SerialPort.DataBits = 8;
                //停止位
                SerialPort.StopBits = StopBits.One;
                //校验位
                SerialPort.Parity = Parity.None;
                //打开串口
                SerialPort.Open();
                //串口数据接收事件实现
                SerialPort.DataReceived += new SerialDataReceivedEventHandler(ReceiveData);

                return SerialPort;
            }
            //串口已经打开
            else
            {
                SerialPort.Close();
                return SerialPort;
            }
        }

        public static void ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort _SerialPort = (SerialPort)sender;

            int _bytesToRead = _SerialPort.BytesToRead;
            byte[] recvData = new byte[_bytesToRead];

            _SerialPort.Read(recvData, 0, _bytesToRead);

            /*接受后操作*/
            if (MainForm.enTrans)
            {
                MainForm.isTraning = true;
                transBuffer[count++] = recvData[0];
                _SerialPort.DiscardInBuffer();
                if (count == 6)
                {
                    count = 0;
                    MainForm.CurrentValue = (double)((short)Program.ByteToUshort(transBuffer[1], transBuffer[2]))/10;
                    File.AppendAllText("temperature.txt", String.Format("{0} ", MainForm.CurrentValue));
                    if (transBuffer[0]==0x01)
                    {
                        MainForm.CurrentValue *= -1;
                    }
                    MainForm.SetValue= (double)((short)Program.ByteToUshort(transBuffer[4], transBuffer[5])) / 10;
                    if (transBuffer[3] == 0x01)
                    {
                        MainForm.SetValue *= -1;
                    }
                    MainForm.enTrans = false;
                    MainForm.isTraning= false;
                }
            }
        }

        public static bool SendData(byte[] data)
        {
            if (SerialPort != null && SerialPort.IsOpen)
            {
                SerialPort.Write(data, 0, data.Length);
                return true;
            }
            else
            {
                return false;
            }
        }
        private static byte[] transBuffer = new byte[6];
        private static int count = 0;
    }
}
