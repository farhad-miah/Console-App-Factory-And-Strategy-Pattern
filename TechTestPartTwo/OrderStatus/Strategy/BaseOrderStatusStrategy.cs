using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestPartTwo.OrderStatus.Enum;
using TechTestPartTwo.OrderStatus.Interface;

namespace TechTestPartTwo.OrderStatus.Strategy
{
    public abstract class BaseOrderStatusStrategy : IOrderStatusStrategy
    {
        public abstract Status GetOrderStatus(bool isRushOrder, bool isNewCustomer, bool isLargeOrder);

        protected Status GetCommonStatus(bool isRushOrder, bool isNewCustomer, bool isLargeOrder)
        {
            if (isRushOrder && isNewCustomer)
            {
                return Status.AuthorisationRequired;
            }

            return Status.Confirmed;
        }
    }
}
