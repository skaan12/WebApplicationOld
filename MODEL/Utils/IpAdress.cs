using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Utils
{
    public class IpAdress
    {
        public static string GetIpAdress()
        {
            var ipAdress = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in ipAdress.AddressList) 
            {
                if(ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new NotImplementedException();
        }
    }
}
