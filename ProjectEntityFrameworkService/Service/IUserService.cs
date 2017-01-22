using ProjectEntityFrameworkService.DBEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntityFrameworkService.Service
{
    public interface IUserService
    {
        int AddUser(User user);
        IEnumerable<User> GetAll();
    }
}
