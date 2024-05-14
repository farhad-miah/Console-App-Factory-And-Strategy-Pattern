using TechTestPartTwo.OrderStatus.Enum;
using TechTestPartTwo.OrderStatus.Interface;

namespace TechTestPartTwo
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IOrderStatusStrategyFactory _factory;

        public OrderProcessor(IOrderStatusStrategyFactory factory)
        {
            _factory = factory;
        }

        public Status DetermineOrderStatus(bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder)
        {
            var strategy = _factory.GetStrategy(orderType);

            return strategy.GetOrderStatus(isRushOrder, isNewCustomer, isLargeOrder);
        }
    }
}
