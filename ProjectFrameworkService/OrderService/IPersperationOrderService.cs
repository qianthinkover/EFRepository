
using ProjectDomainModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkService.OrderService
{
    public interface IPersperationOrderService
    {
        /// <summary>
        /// 订单新增
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        int AddOrder(PersperationOrder order);

        IEnumerable<PersperationOrder> GetAllOrder();
        /// <summary>
        /// 获取我的订单
        /// </summary>
        /// <returns></returns>
        IEnumerable<PersperationOrder> GetOrderByPersonID(string PatientId);

    }
}
