using Microsoft.Extensions.Configuration;
using RK7Die.CashServer;
using RK7Die.CashServer.Query;
using System;
using System.IO;

namespace RK7Die.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            GetOrderList getOrderList = new GetOrderList();

            Client client = new Client(new Uri(config["host"]), config["username"], config["password"]);

            string result = client.SendQuery(getOrderList);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
