using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

namespace Wed14O
{
    internal class Client
    {
        static void Main()
        {
            Console.WriteLine("Hola mamá");
            Console.Write("Write what you want to send:");
            string toSend = Console.ReadLine();
            connectServer("127.0.0.1", toSend);
            Console.ReadKey();
        }

        static void connectServer(string server, string msg)
        {
            int port = 8090;
            // Uses the public TcpClient(string hostname, int port) : this(AddressFamily.Unknown) constructor
            TcpClient tcpClient = new TcpClient(server, port);

            // Stream works with bytes moving
            // So we turn it into an aarray of bytes
            Byte[] dataMsg = Encoding.ASCII.GetBytes(msg);

            NetworkStream networkStream = tcpClient.GetStream();

            // SImilar to fwrite() in C
            // Offset: how it moved, and the length (how many byteS)
            networkStream.Write(dataMsg,0, dataMsg.Length);
            Console.WriteLine($"Sending message:{msg}");

            // The opposite, we turn a stream of bytes into a string
            Byte[] receivedData = new Byte[256];

            string receivedMsg = string.Empty;

            int numBytes = networkStream.Read(receivedData, 0, receivedData.Length);
            
            receivedMsg = Encoding.ASCII.GetString(receivedData,0, receivedData.Length);

            Console.WriteLine($"Received message: {receivedMsg}");

            // Do this to avoid leaking the connection
            networkStream.Close();
            tcpClient.Close();
        }

    }
}