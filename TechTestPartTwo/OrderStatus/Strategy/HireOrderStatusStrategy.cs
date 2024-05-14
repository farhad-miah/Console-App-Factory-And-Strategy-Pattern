using TechTestPartTwo.OrderStatus.Enum;

namespace TechTestPartTwo.OrderStatus.Strategy
{
    public class HireOrderStatusStrategy : BaseOrderStatusStrategy
    {
        public override Status GetOrderStatus(bool isRushOrder, bool isNewCustomer, bool isLargeOrder)
        {
            if (isLargeOrder && isRushOrder)
            {
                return Status.Closed;
            }

            return GetCommonStatus(isRushOrder, isNewCustomer, isLargeOrder);
        }
    }
}
