using Microsoft.Extensions.DependencyInjection;
using TechTestPartTwo.OrderStatus.Enum;
using TechTestPartTwo.OrderStatus.Factory;
using TechTestPartTwo.OrderStatus.Interface;

namespace TechTestPartTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IOrderStatusStrategyFactory, OrderStatusStrategyFactory>()
                .AddScoped<IOrderProcessor, OrderProcessor>()
                .BuildServiceProvider();

            var orderProcessor = serviceProvider.GetService<IOrderProcessor>();

            var orderStatus = orderProcessor?.DetermineOrderStatus(true, OrderType.Hire, true, false);

            Console.WriteLine($"Order status: {orderStatus}");
        }
    }
}
