using DenganID.Networking.RemotePing;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = "8.8.8.8";
            var ping = new Ping();
            var isAlive = ping.IsAlive(host);
            Console.WriteLine(host+ " alive: " + isAlive);
        }
    }
}
