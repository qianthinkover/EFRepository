using ProjectEntityFramework.Interfaces;
using ProjectEntityFrameworkService.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntityFrameworkService.Repository
{
    public interface IUserRepository : IEfRepository<User>
    {
    }
}
