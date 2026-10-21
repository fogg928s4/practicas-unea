using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Common;

namespace Cliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");
            TcpChannel channel = new TcpChannel();

            ChannelServices.RegisterChannel(channel,false);
            Type remoteType = typeof(IMovieTicket);

            // Implements the class type
            IMovieTicket remoteObject = 
                (IMovieTicket) Activator.GetObject(
                    remoteType,
                    "tcp://localhost:9998/MovieTicketService"
                );
            // sends, and knows the interface but not the class
            string result = remoteObject.GetTicketStatus("Ticket Nº 666");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
