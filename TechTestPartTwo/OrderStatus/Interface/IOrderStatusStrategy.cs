using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTestPartTwo.OrderStatus.Enum;

namespace TechTestPartTwo.OrderStatus.Interface
{
    public interface IOrderStatusStrategy
    {
        Status GetOrderStatus(bool isRushOrder, bool isNewCustomer, bool isLargeOrder);
    }
}
