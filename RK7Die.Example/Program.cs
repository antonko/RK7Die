using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RK7Die.CashServer;
using RK7Die.CashServer.Query;
using Serilog;

namespace RK7Die.Example
{
    public class Program
    {
        static RK7Die.CashServer.Client _client;

        public static void Main(string[] args)
        {
            var host = Host
                .CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddOptions();
                    services.Configure<RK7Die.CashServer.ClientOptions>(hostContext.Configuration.GetSection("RK7Client"));
                    services.AddSingleton<RK7Die.CashServer.Client>();
                })
                .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration
                    .ReadFrom.Configuration(hostingContext.Configuration))
                .UseConsoleLifetime()
                .Build();

            host.RunAsync();

            _client = host.Services.GetService<RK7Die.CashServer.Client>();

            GetOrderList();
            GetOrderList2();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static private void GetOrderList()
        {
            Log.Logger.Warning($"Выполнение запроса GetOrderList");

            GetOrderList getOrderListRequest = new GetOrderList
            {
                OnlyOpened = true
            };

            var getOrderListResult = _client.SendQuery(getOrderListRequest, typeof(RK7Die.CashServer.Result.GetOrderList)) as RK7Die.CashServer.Result.GetOrderList;

            var orderCount = getOrderListResult.Visit.SelectMany(c => c.Orders).Count();

            Log.Logger.Warning($"Открытых заказов: {orderCount}");
        }

        static private void GetOrderList2()
        {
            Log.Logger.Warning($"Выполнение запроса GetOrderList2");

            GetOrderList2 getOrderListRequest2 = new GetOrderList2
            {
                OnlyOpened = true
            };

            var getOrderListResult = _client.SendQuery(getOrderListRequest2, typeof(RK7Die.CashServer.Result.GetOrderList2)) as RK7Die.CashServer.Result.GetOrderList2;

            var orderCount = getOrderListResult.Visit.SelectMany(c => c.Orders).Count();

            Log.Logger.Warning($"Всего заказов: {orderCount}");
        }
    }
}