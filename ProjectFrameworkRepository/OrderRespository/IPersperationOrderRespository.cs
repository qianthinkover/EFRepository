using ProjectDomainModels.Orders;
using ProjectEntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkRepository.OrderRespository
{
    public interface IPersperationOrderRespository 
        : IEfRepository<PersperationOrder>
    {
    }
}
