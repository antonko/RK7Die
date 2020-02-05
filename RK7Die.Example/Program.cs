using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RK7Die;
using RK7Die.Query;
using RK7Die.Result;
using Serilog;

namespace RK7Die.Example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args).ConfigureServices((hostContext, services) =>
                {
                    services.AddOptions();
                    services.Configure<RK7Die.ClientOptions>(hostContext.Configuration.GetSection("RK7Client"));
                    services.AddSingleton<RK7Die.Client>();
                    services.AddHostedService<Demo>();
                })
                .UseSerilog((hostingContext, loggerConfiguration) => loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration))
                .UseConsoleLifetime()
                .Build();

            host.Run();
        }

        public class Demo : BackgroundService
        {
            protected override async Task ExecuteAsync(CancellationToken stoppingToken)
            {
                await GetOrderList();
                await GetOrderList2();
                await GetOrder();
            }

            /// <summary>
            /// Пример выполнения запроса GetOrderList
            /// </summary>
            public async Task GetOrderList()
            {
                Log.Logger.Warning($"Выполнение запроса GetOrderList");

                QueryGetOrderList queryGetOrderList = new QueryGetOrderList
                {
                    OnlyOpened = true
                };

                var getOrderListResult = await _rk7Client.SendQuery(queryGetOrderList, typeof(ResultGetOrderList)) as ResultGetOrderList;
                var orderCount = getOrderListResult.Visit.SelectMany(c => c.Orders).Count();
                Log.Logger.Warning($"Открытых заказов: {orderCount}");
            }

            /// <summary>
            /// Пример выполнения запроса GetOrderList2
            /// </summary>
            public async Task GetOrderList2()
            {
                Log.Logger.Warning($"Выполнение запроса GetOrderList2");

                QueryGetOrderList2 queryGetOrderList2 = new QueryGetOrderList2
                {
                    OnlyOpened = false
                };

                var getOrderListResult = await _rk7Client.SendQuery(queryGetOrderList2, typeof(ResultGetOrderList2)) as ResultGetOrderList2;
                var orderCount = getOrderListResult.Visit.SelectMany(c => c.Orders).Count();
                Log.Logger.Warning($"Всего заказов: {orderCount}");
            }

            /// <summary>
            /// Пример выполнения запроса GetOrder
            /// </summary>
            public async Task GetOrder()
            {
                Log.Logger.Warning($"Выполнение запроса GetOrder");

                QueryGetOrderList queryGetOrderList = new QueryGetOrderList();

                Log.Logger.Warning($"Берем первый попавшийся заказ");
                var getOrderListResult = await _rk7Client.SendQuery(queryGetOrderList, typeof(ResultGetOrderList)) as ResultGetOrderList;

                QueryGetOrder getOrder = new QueryGetOrder
                {
                    Order = new Common.OrderElement
                    {
                        Guid = getOrderListResult.Visit.SelectMany(v => v.Orders).FirstOrDefault().Guid
                    }
                };

                var result = await _rk7Client.SendQuery(getOrder, typeof(ResultGetOrder)) as ResultGetOrder;
                Log.Logger.Warning($"Создатель заказа: {result.Order.Creator.Name}");
            }

            public Demo(RK7Die.Client rk7Client)
            {
                _rk7Client = rk7Client;
            }

            private RK7Die.Client _rk7Client;
        }
    }
}