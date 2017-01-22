using ProjectDomainModels.Orders;
using ProjectEntityFramework;
using ProjectEntityFrameworkDBAccess;
using RepositoryT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkRepository.OrderRespository
{
    public class PersperationOrderRespository
         : EntityRepository<PersperationOrder, ProjectDataContext>
        , IPersperationOrderRespository
    {
        public PersperationOrderRespository(IServiceLocator serviceLocator)
            : base(serviceLocator)
        {

        }
    }
}
