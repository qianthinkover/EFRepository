using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEntityFrameworkService.DBEntities;
using ProjectEntityFrameworkService.Repository;

namespace ProjectEntityFrameworkService.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            
            _userRepository = userRepository;
        }
        public int AddUser(User user)
        {
            _userRepository.Add(user);
            return user.Id;
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
