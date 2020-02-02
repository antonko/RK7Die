using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using RK7Die.CashServer;
using RK7Die.CashServer.Query;
using Serilog;
using System;
using System.IO;

namespace RK7Die.Example
{
    class Program
    {
        public static IConfiguration Configuration { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello RK7Die.Example!");

            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true);
            var config = configBuilder.Build();


            var serviceProvider = new ServiceCollection()
                .AddSingleton<Client>()
                .Configure<ClientOptions>(Configuration)
                .BuildServiceProvider();

            //do the actual work here
            var client = serviceProvider.GetService<Client>();

            //var config = new ConfigurationBuilder()
            //    .AddCommandLine(args)
            //    .Build();

            //ClientOptions clientOptions = new ClientOptions
            //{
            //    Host = config["host"],
            //    Username = config["username"],
            //    Password = config["password"]
            //};

            //Log.Logger = new LoggerConfiguration()
            //    .MinimumLevel.Verbose()
            //    .WriteTo.File("log.txt")
            //    .CreateLogger();

            //client = new Client(clientOptions, Log.Logger);

            //GetOrderList(client);

            //Console.ReadKey();
        }

        static private void GetOrderList(Client client)
        {
            GetOrderList getOrderList = new GetOrderList
            {
                OnlyOpened = true
            };

            string result = client.SendQuery(getOrderList);

            Console.WriteLine(result);
        }
    }
}
