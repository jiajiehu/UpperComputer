using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO
namespace UpperComputer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            SerialPortUtils.OpenClosePort("COM7", 38400);
            SetValue = 0;
            enTrans = false;
            isTraning = false;
            CurrentValue = 0;
        }

        public static double SetValue;
        public static double CurrentValue;
        public static bool enTrans;
        public static bool isTraning;
        public void correponse() {
            byte[] data = { 0x00 };
            SerialPortUtils.SendData(data);
            enTrans = true;
            while (isTraning) ;
            LabelSetT.Text = SetValue.ToString("F1") + " ℃";
            LabelCurrentT.Text = CurrentValue.ToString("F1") + " ℃";
        }
        private void ButtonUpT_Click(object sender, EventArgs e)
        {
            if (SetValue <= 20)
            {
                byte[] data = { 0x01 };
                SerialPortUtils.SendData(data);
                correponse();
            }
        }

        private void ButtonLowT_Click(object sender, EventArgs e)
        {
            if (SetValue >= -20)
            {
                byte[] data = { 0x02 };
                SerialPortUtils.SendData(data);
                correponse();
            }
        }

        private void TimerGetT_Tick(object sender, EventArgs e)
        {
            if(!isTraning)
                correponse();
        }

        private void ButtonStartTrans_Click(object sender, EventArgs e)
        {
            ButtonStartTrans.Enabled = false;
            ButtonEndTrans.Enabled = true;
            ButtonUpT.Enabled = true;
            ButtonLowT.Enabled = true;
            correponse();
            TimerGetT.Start();
        }

        private void ButtonEndTrans_Click(object sender, EventArgs e)
        {
            ButtonStartTrans.Enabled = true;
            ButtonEndTrans.Enabled = false;
            ButtonUpT.Enabled = false;
            ButtonLowT.Enabled = false;
            TimerGetT.Stop();
            LabelCurrentT.Text = "未通信";
            LabelSetT.Text = "未通信";
        }
    }
}
