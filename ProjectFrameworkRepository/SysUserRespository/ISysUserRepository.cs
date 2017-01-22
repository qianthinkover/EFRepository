using ProjectDomainModels.Users;
using ProjectEntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkRepository.UserRespository
{
    public interface ISysUserRepository : IEfRepository<SysUserInfo>
    {
    }
}
