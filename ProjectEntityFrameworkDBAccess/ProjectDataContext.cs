using ProjectDomainModels.Orders;
using ProjectDomainModels.Users;
using ProjectEntityFramework.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEntityFrameworkDBAccess
{
    public class ProjectDataContext : DbContext, IDbContext
    {
        public ProjectDataContext() : base("ProjectDataContext")
        {

        }
        /// <summary>
        /// 系统用户类
        /// </summary>
        public DbSet<SysUserInfo> SysUserInfo { get; set; }
        /// <summary>
        /// 系统用户类
        /// </summary>
        public DbSet<PersperationOrder> PersperationOrder { get; set; }
    }
}
