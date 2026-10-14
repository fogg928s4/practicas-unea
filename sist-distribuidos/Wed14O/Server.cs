using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello server!");
            listen();
            
        }
        static void listen()
        {
            TcpListener listener = null;
            try {
                int port = 8090; // same as the one the client has
                IPAddress localAddress = IPAddress.Parse("127.0.0.1"); // localhost
                // Instantiate and start
                listener = new TcpListener(localAddress, port);
                listener.Start();

                Byte[] bytes = new Byte[256]; // An array to get the info
                string msg = string.Empty;

                while (true) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Waiting for connection...");
                    
                    // Reuses and accepts the connection with the client
                    // Will keep waiting until it received something
                    TcpClient client = listener.AcceptTcpClient();
                    Console.WriteLine("Connected!");

                    NetworkStream networkStream = client.GetStream();

                    int receivedByteCount = networkStream.Read(bytes, 0, bytes.Length);
                    Console.ForegroundColor = ConsoleColor.White;
                    msg = Encoding.ASCII.GetString(bytes,0,receivedByteCount);
                    Console.WriteLine($"Received {receivedByteCount.ToString()} bytes of info");
                    Console.WriteLine($"Message: {msg}");

                    Console.ForegroundColor = ConsoleColor.Blue;
                    // We respond with the same message but in upper case
                    msg = msg.ToUpper();
                    byte[] response = Encoding.ASCII.GetBytes(msg);
                    networkStream.Write(response, 0, response.Length);
                    Console.WriteLine($"Responded with: {msg}");
                    Console.ForegroundColor = ConsoleColor.White;
                    client.Close();
                    //networkStream.Close();
                }

            } catch(Exception ex) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Shit happened:{ex.Message} ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally { 
                // Exception or not, it will execute
                listener.Stop(); 
            }
        }
    }
}