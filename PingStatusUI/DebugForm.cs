using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingStatusUI
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
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
        private void DebugForm_Load(object sender, EventArgs e)
        {

        }

        private void pingTestButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked");
            PingDevice(device1TextBox.Text);
        }
    }
}
