using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Servidor
{
    internal class MovieTicket : MarshalByRefObject, IMovieTicket
    {
        public static int instances = 0;

        public MovieTicket() { 
            instances++;
        }
        public string GetTicketStatus(string strToPrint)
        {
            string returnStatus = "Ticket Confirmed";
            // to confirm that the server got a message
            Console.WriteLine(strToPrint);
            Console.WriteLine($"Instance count: {instances}");
            return returnStatus;
        }
    }
}
