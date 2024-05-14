using TechTestPartTwo.OrderStatus.Enum;
using TechTestPartTwo.OrderStatus.Interface;
using TechTestPartTwo.OrderStatus.Strategy;

namespace TechTestPartTwo.OrderStatus.Factory
{
    public class OrderStatusStrategyFactory : IOrderStatusStrategyFactory
    {
        public IOrderStatusStrategy GetStrategy(OrderType orderType)
        {
            return orderType switch
            {
                OrderType.Hire => new HireOrderStatusStrategy(),
                OrderType.Repair => new RepairOrderStatusStrategy(),
                _ => throw new NotSupportedException($"Order type '{orderType}' is not supported."),
            };
        }
    }
}
