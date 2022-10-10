using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ArduinoCommunication
{
    class cServerClass
    {
        public event MessageEventHandler Message;
        public delegate void MessageEventHandler(cServerClass sender, string Data);
        public event MessageEventHandler senddata;
        // Server control

        public IPAddress ServerIp = IPAddress.Parse("192.168.43.169"); //computer internal ip addresse
        public int ServerPort = 1000;
        public TcpListener myserver;
        public Thread Comthread;
        public bool IsListening = true;
       // private string Ipinput
        // Clients
        private TcpClient client;
        private StreamReader clientdata;
        private StreamWriter clientsend;

        public cServerClass(string Ipinput)
        {
            myserver = new TcpListener(IPAddress.Parse(Ipinput), ServerPort);
            myserver.Start();

            Comthread = new Thread(new ThreadStart(Hearing));
            Comthread.Start();

        }
        private void Hearing()
        {
            while(!IsListening == false)
            {
                if(myserver.Pending() == true)
                {
                    client = myserver.AcceptTcpClient();
                    clientdata = new StreamReader(client.GetStream());
                    clientsend = new StreamWriter(client.GetStream());
                }
                try
                {
                    Message?.Invoke(this, clientdata.ReadLine());
                    
                }
                catch(Exception ex)
                {

                }
                Thread.Sleep(10);
            }
        }
    }
}
