using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ContestManagementSystem
{
    public class NetworkManager
    {
        NetworkStream stream;

        public NetworkManager()
        {
            StartListening();
        }

        private void StartListening()
        {
            // Set the TcpListener on port 4500.
            Int32 port = 4500;
            IPAddress localAddr = IPAddress.Parse("127.0.0.1");

            TcpListener server = new TcpListener(localAddr, port);
            server.Start();
        }

        private void SendData(Object data, IPAddress ip)
        {
            //byte[] byteArrray = Encoding.Unicode.GetBytes();
        }

        private void RecieveData()
        {

        }
    }
}
