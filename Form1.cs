using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using udp_tool;

namespace udp_tool
{
    public partial class Form1 : Form
    {
        udp_client_server udpServer;
        Socket newsock;
        byte[] udpData = new byte[1024];
        delegate void SetTextCallback(string text);
        public Form1()
        {
            udpServer = new udp_client_server(1111);
            newsock = udpServer.UdpServer();
            Thread udpThread = new Thread(new ThreadStart(this.udpRx));
            udpThread.Start();
            InitializeComponent();
        }

        public void udpRx()
        {
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);
            while (true)
            {
            //byte[] data = new byte[1024];
              int recv = newsock.ReceiveFrom(udpData, ref Remote); // receive packets 
                                                                   //recvBox.AppendText(Encoding.UTF8.GetString(udpData, 0, recv));
              this.SetText(Encoding.UTF8.GetString(udpData, 0, recv));
            // decode to UTF8 format
            //Console.WriteLine(Encoding.UTF8.GetString(data, 0, recv));
            }
        }

        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.recvBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.recvBox.AppendText(text);
            }
        }

        private void sendClick(object sender, EventArgs e)
        {
            
        }

        private void sendBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string address = addressBox.Text;
            int port = Int32.Parse(portBox.Text);
            udpServer.UdpTx(address, port, Encoding.ASCII.GetBytes(msgBox.Text));


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
