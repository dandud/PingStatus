using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PingStatusLibrary.Models;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace PingStatusUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DeviceModel device1 = new DeviceModel();
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

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugForm debugForm = new DebugForm();
            debugForm.Show();
        }
    }
}
