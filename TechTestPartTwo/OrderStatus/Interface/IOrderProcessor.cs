using TechTestPartTwo.OrderStatus.Enum;

namespace TechTestPartTwo.OrderStatus.Interface
{
    public interface IOrderProcessor
    {
        Status DetermineOrderStatus(bool isRushOrder, OrderType orderType, bool isNewCustomer, bool isLargeOrder);
    }
}