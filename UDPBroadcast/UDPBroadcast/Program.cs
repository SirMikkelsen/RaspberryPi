using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace UDPBroadcast
{
    class Program
    {
        static void Main(string[] args)

        {
            var a = new ServiceReference1.Service1Client();


            // lytter på alle egne ip adresser på port 7000
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 7000);


            UdpClient udpclient = new UdpClient(ip);

            udpclient.EnableBroadcast = true;

            // modtage fra enhver ip adresse samt enhver port
            var senderEndPoint = new IPEndPoint(IPAddress.Any, 0);


            while (true)
            {
                // Læser bytes som tekst
                byte[] receiver = udpclient.Receive(ref senderEndPoint);
                Console.WriteLine();
                Thread.Sleep(1000);
                Lys lys = JsonConvert.DeserializeObject<Lys>(Encoding.ASCII.GetString(receiver));
                a.GetLysData(lys.lys);
                Console.WriteLine($"Sent lys={lys.lys}");
            }
            Console.ReadKey();
        }
    }

    class Lys
    {
        public int lys { get; set; }
    }
}