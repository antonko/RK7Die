using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RK7Die.CashServer;
using RK7Die.CashServer.Query;
using RK7Die.CashServer.Result;
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
            GetOrder();

            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }

        static private void GetOrderList()
        {
            Log.Logger.Warning($"Выполнение запроса GetOrderList");

            QueryGetOrderList queryGetOrderList = new QueryGetOrderList
            {
                OnlyOpened = true
            };

            var getOrderListResult = _client.SendQuery(queryGetOrderList, typeof(ResultGetOrderList)) as ResultGetOrderList;

            var orderCount = getOrderListResult.Visit.SelectMany(c => c.Orders).Count();

            Log.Logger.Warning($"Открытых заказов: {orderCount}");
        }

        static private void GetOrderList2()
        {
            Log.Logger.Warning($"Выполнение запроса GetOrderList2");

            QueryGetOrderList2 queryGetOrderList2 = new QueryGetOrderList2
            {
                OnlyOpened = false
            };

            var getOrderListResult = _client.SendQuery(queryGetOrderList2, typeof(ResultGetOrderList2)) as ResultGetOrderList2;

            var orderCount = getOrderListResult.Visit.SelectMany(c => c.Orders).Count();

            Log.Logger.Warning($"Всего заказов: {orderCount}");
        }

        static private void GetOrder()
        {
            Log.Logger.Warning($"Выполнение запроса GetOrder");

            QueryGetOrderList queryGetOrderList = new QueryGetOrderList();

            Log.Logger.Warning($"Берем первый попавшийся заказ");
            var getOrderListResult = _client.SendQuery(queryGetOrderList, typeof(ResultGetOrderList)) as ResultGetOrderList;

            QueryGetOrder getOrder = new QueryGetOrder
            {
                Order = new CashServer.Common.OrderElement
                {
                    Guid = getOrderListResult.Visit.SelectMany(v => v.Orders).FirstOrDefault().Guid
                }
            };

            var result = _client.SendQuery(getOrder, typeof(ResultGetOrder)) as ResultGetOrder;

            Log.Logger.Warning($"Создатель заказа: {result.Order.Creator.Name}");
        }
    }
}