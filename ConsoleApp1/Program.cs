using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => { return true; };

            var signalRHelper = new SignalRHelper();
            signalRHelper.Start();

            Console.Read();
        }
    }
}