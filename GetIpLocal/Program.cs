using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GetIpLocal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var ip = GetLocalIPAddress();
                Console.WriteLine(ip);
            }
            catch(Exception e)
            {
                Console.WriteLine("Ocurrio un error:"+e.Message);
            }
            Console.ReadKey();
        }

        public static string GetLocalIPAddress()
        {
            var isConneted = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            Console.WriteLine(isConneted);
            var host = Dns.GetHostEntry(Dns.GetHostName());
            var ipList = host.AddressList;
            var ipEquipo = ipList.Last<IPAddress>();
            return ipEquipo.ToString();
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}
