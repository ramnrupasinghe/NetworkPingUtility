using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace pinger_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PingService pingService = new PingService();
            var response = pingService.SendPing();
            Console.WriteLine(response);

            Console.ReadLine();

        }
    }
}
