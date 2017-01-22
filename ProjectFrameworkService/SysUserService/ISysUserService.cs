using ProjectDomainModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFrameworkService.SysUserService
{
    public interface ISysUserService
    {
        int AddUser(SysUserInfo user);
        IEnumerable<SysUserInfo> GetAll();


    }
}
