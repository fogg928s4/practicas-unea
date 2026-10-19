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
            try
            {
                int port = 8090; // same as the one the client has
                IPAddress localAddress = IPAddress.Parse("127.0.0.1"); // localhost
                // Instantiate and start
                listener = new TcpListener(localAddress, port);
                listener.Start();


                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Waiting for connection...");

                    // Reuses and accepts the connection with the client
                    // Will keep waiting until it received something
                    // Ver 1.0
                    TcpClient client = listener.AcceptTcpClient();
                    RequestProcessor reqProc = new RequestProcessor(client);
                    reqProc.ProcessRequest();

                    // Ver2.0
                    // Uses thread to process them separately
                    // calls for a process NAME to start the new thread
                    ThreadStart threadStart = new ThreadStart(reqProc.ProcessRequest);
                    Thread thread = new Thread(threadStart);
                    thread.Start();
                    //networkStream.Close();

                    // ver2.5 
                    // Uses the parametrized threads class to work it out
                    // Methods called by this must have an objecto parameter
                    ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(RequestProcessor.ProcessRequest);
                    Thread thread1 = new Thread(parameterizedThreadStart);
                    thread1.Start(client);
                }

            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Shit happened:{ex.Message} ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            finally
            {
                // Exception or not, it will execute
                listener.Stop();
            }
        }
    }
}