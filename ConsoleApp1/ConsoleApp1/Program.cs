using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string hostName = Dns.GetHostName();
            IPHostEntry ipEntry = Dns.GetHostEntry(hostName);
            IPAddress[] ipAddresses = ipEntry.AddressList;

            int startPort = 70;
            int endPort = 90;


            foreach (IPAddress ipAddress in ipAddresses)
            {
                for (int port = startPort; port <= endPort; port++)
                {
                    IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, port);
                    Socket socket = new Socket(ipEndPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

                    try
                    {
                        socket.Connect(ipEndPoint);
                        Console.WriteLine($"Port {port} is open on {ipAddress}");
                    }
                    catch (SocketException)
                    {
                        // Port is closed or filtered
                        Console.WriteLine("Port {0} is closed", ipEndPoint.Port);
                    }
                    finally
                    {
                        socket.Close();
                    }
                }
            }
        }
    }
}
