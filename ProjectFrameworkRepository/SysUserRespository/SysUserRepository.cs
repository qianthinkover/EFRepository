using ProjectDomainModels.Users;
using ProjectEntityFramework;
using ProjectEntityFrameworkDBAccess;
using RepositoryT.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkRepository.UserRespository
{
    public class SysUserRepository : EntityRepository<SysUserInfo, ProjectDataContext>
        , ISysUserRepository
    {
        public SysUserRepository(IServiceLocator serviceLocator)
            : base(serviceLocator)
        {

        }
    }
}
