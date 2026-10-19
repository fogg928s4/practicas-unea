using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class RequestProcessor
    {
        private TcpClient theClient;
        public RequestProcessor(TcpClient theClient) {
            this.theClient = theClient;
        }
        public void ProcessRequest() {
            string msg = string.Empty;
            Byte[] bytes = new Byte[256]; // An array to get the info


            Console.WriteLine("Connected!");

            NetworkStream networkStream = theClient.GetStream();

            int receivedByteCount = networkStream.Read(bytes, 0, bytes.Length);
            Console.ForegroundColor = ConsoleColor.White;
            msg = Encoding.ASCII.GetString(bytes, 0, receivedByteCount);
            Console.WriteLine($"Received {receivedByteCount.ToString()} bytes of info");
            Console.WriteLine($"Message received: {msg}");

            Thread.Sleep(10000);

            Console.ForegroundColor = ConsoleColor.Blue;
            // We respond with the same message but in upper case
            msg = msg.ToUpper();
            byte[] response = Encoding.ASCII.GetBytes(msg);
            networkStream.Write(response, 0, response.Length);
            Console.WriteLine($"Responded with: {msg}");
            Console.ForegroundColor = ConsoleColor.White;
            theClient.Close();

        }
        public static void ProcessRequest(object client)
        {
            string msg = string.Empty;
            Byte[] bytes = new Byte[256]; // An array to get the info
            Console.WriteLine("Connected!");


            // Errores bc object can be anythingso we need to cast it
            // be sure it is that class of object
            TcpClient theClient = (TcpClient)client;
            NetworkStream networkStream = theClient.GetStream();

            int receivedByteCount = networkStream.Read(bytes, 0, bytes.Length);
            Console.ForegroundColor = ConsoleColor.White;
            msg = Encoding.ASCII.GetString(bytes, 0, receivedByteCount);
            Console.WriteLine($"Received {receivedByteCount.ToString()} bytes of info");
            Console.WriteLine($"Message received: {msg}");

            Thread.Sleep(10000);

            Console.ForegroundColor = ConsoleColor.Blue;
            // We respond with the same message but in upper case
            msg = msg.ToUpper();
            byte[] response = Encoding.ASCII.GetBytes(msg);
            networkStream.Write(response, 0, response.Length);
            Console.WriteLine($"Responded with: {msg}");
            Console.ForegroundColor = ConsoleColor.White;
            theClient.Close();

        }
    }
}
