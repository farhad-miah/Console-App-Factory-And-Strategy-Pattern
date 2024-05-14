using TechTestPartTwo.OrderStatus.Enum;

namespace TechTestPartTwo.OrderStatus.Interface
{
    public interface IOrderStatusStrategyFactory
    {
        IOrderStatusStrategy GetStrategy(OrderType orderType);
    }
}