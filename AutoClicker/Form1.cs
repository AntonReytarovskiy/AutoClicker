using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public partial class Form1 : Form
    {
        private int clicks = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Make_click();
        }

        private void Make_click()
        {
            clicks--;
            DoMouseClick();
            if (clicks == 0)
                Stop_clicker();
        }

        private void Stop_clicker()
        {
            timer.Enabled = false;
            button_start.Enabled = true;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            start_clicker();
        }

        private void start_clicker()
        {
            clicks = (int)numeric_count.Value;
            button_start.Enabled = false;
            timer.Interval = (int)numeric_time.Value;
            timer.Enabled = true;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        public void DoMouseClick()
        {
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }
    }
}
