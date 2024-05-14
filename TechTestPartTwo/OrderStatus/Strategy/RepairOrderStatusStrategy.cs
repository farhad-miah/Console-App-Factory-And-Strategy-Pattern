using TechTestPartTwo.OrderStatus.Enum;

namespace TechTestPartTwo.OrderStatus.Strategy
{
    public class RepairOrderStatusStrategy : BaseOrderStatusStrategy
    {
        public override Status GetOrderStatus(bool isRushOrder, bool isNewCustomer, bool isLargeOrder)
        {
            if (isLargeOrder && isNewCustomer)
            {
                return Status.Closed;
            }

            if (isLargeOrder)
            {
                return Status.AuthorisationRequired;
            }

            return GetCommonStatus(isRushOrder, isNewCustomer, isLargeOrder);
        }
    }
}
