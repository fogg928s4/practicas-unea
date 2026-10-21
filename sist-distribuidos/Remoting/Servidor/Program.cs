using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting;

namespace Servidor
{
    internal class Program
    {
        public static object TcpChannel { get; private set; }

        static void Main(string[] args)
        {
            // Puerto donde escucha
            TcpChannel canal = new TcpChannel(9998);
            ChannelServices.RegisterChannel(canal, false);
            Type remoteType = typeof(MovieTicket);

            RemotingConfiguration.RegisterWellKnownServiceType(
                remoteType,
                "MovieTicketService",
                WellKnownObjectMode.SingleCall
            );
            Console.WriteLine("Service running");
            Console.ReadLine();
        }
    }
}
