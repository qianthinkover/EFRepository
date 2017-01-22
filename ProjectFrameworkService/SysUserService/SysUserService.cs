using System;
using System.Collections.Generic;
using ProjectDomainModels.Users;
using ProjectFrameworkRepository.UserRespository;
using RepositoryT.Infrastructure;

namespace ProjectFrameworkService.SysUserService
{
    public class SysUserService : ISysUserService
    {
        private readonly ISysUserRepository _sysUserRepository;
        private readonly IUnitOfWork _unitOfWork;
        public SysUserService(IUnitOfWork unitOfWork,ISysUserRepository sysUserRepository)
        {
            _unitOfWork = unitOfWork;
            _sysUserRepository = sysUserRepository;
        }

        public int AddUser(SysUserInfo user)
        {
            _sysUserRepository.Add(user);
            _unitOfWork.Commit();
            return user.Id;
        }

        public IEnumerable<SysUserInfo> GetAll()
        {
            return _sysUserRepository.GetAll();
        }
    }
}
