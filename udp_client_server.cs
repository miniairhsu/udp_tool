using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace udp_tool
{
    public class udp_client_server
    {
        int nPort;
        public udp_client_server(int nPort)
        {
            this.nPort = nPort;
        }

        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
               // Console.WriteLine("Thread1 {0}", this.nPort);
            }
            Console.ReadLine();
        }

        public void Thread2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread2 {0}", i);
            }
            Console.ReadLine();
        }

        byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public Socket UdpServer()
        {
            // accept 1001 port from client
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, this.nPort); //local device port
                                                                         // establish socket
            Socket newsock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            newsock.Bind(ipep);
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);

            //while (true)
            //{
            //byte[] data = new byte[1024];
            //int recv = newsock.ReceiveFrom(data, ref Remote); // receive packets 
            // decode to UTF8 format
            //Console.WriteLine(Encoding.UTF8.GetString(data, 0, recv));
            //}
            return newsock;
        }

        public void UdpTx(string strIPAddr, int nPort, byte[] bData)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(strIPAddr), nPort); //local device port
                                                                                           // Dgram UDP port
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            server.SendTo(bData, ipep);
            server.Close();
        }
    }
}
