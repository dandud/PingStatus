using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PingStatusUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pingTestButton_Click(object sender, EventArgs e)
        {
            PingDevice(device1TextBox.Text);
        }

        public void PingDevice(string device)
        {
            using (Ping ping = new Ping())
            {
                try
                {
                    PingReply reply = ping.Send(device, 100);
                    device1ReplyLabel.Text = reply.Status.ToString();
                    if (reply.Status == IPStatus.Success)
                    {
                        device1StatusLabel.Text = "Good";
                    }
                    else
                    {
                        device1StatusLabel.Text = "Bad";
                    }

                }
                catch (Exception ex)
                {
                    device1StatusLabel.Text = "Bad";
                    Console.WriteLine("Error ({0})", ex.InnerException.Message);
                }
            }
        }

        // notification icon 
        // based on:  https://www.aspsnippets.com/Articles/Windows-Forms-WinForms-Application-with-System-Tray-Icon-using-C-and-VBNet.aspx
        private void MainForm_Load(object sender, EventArgs e)
        {
            appNotifyIcon.BalloonTipText = "Application Minimized.";
            appNotifyIcon.BalloonTipTitle = "Ping Status";
            appNotifyIcon.Text = "Ping Status";
            //appNotifyIcon
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                appNotifyIcon.Visible = true;
                appNotifyIcon.ShowBalloonTip(1000);
            }
        }

        private void appNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            appNotifyIcon.Visible = false;
            WindowState = FormWindowState.Normal;
        }
    }
}
