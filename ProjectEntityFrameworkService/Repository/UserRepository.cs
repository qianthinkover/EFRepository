using ProjectEntityFramework;
using ProjectEntityFrameworkService.DBEntities;
using RepositoryT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntityFrameworkService.Repository
{
    public class UserRepository : EntityRepository<User, EtntityDbContext>, IUserRepository
    {
        public UserRepository(IServiceLocator serviceLocator)
            : base(serviceLocator)
        {

        }
    }
}
