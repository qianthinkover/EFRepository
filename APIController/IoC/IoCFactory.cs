using Autofac;
using ProjectEntityFramework;
using ProjectEntityFrameworkDBAccess;
using ProjectFrameworkRepository.OrderRespository;
using ProjectFrameworkRepository.UserRespository;
using ProjectFrameworkService.OrderService;
using ProjectFrameworkService.SysUserService;
using RepositoryT.Infrastructure;


namespace EPCenterAPI.IoC
{
    public  class IoCFactory
    {
        public static IContainer _Container;

        public IoCFactory(ContainerBuilder builder)
        {
//            _builder = builder;
            builder.RegisterType<AutofacServiceLocator>().As<IServiceLocator>().SingleInstance();
            #region DbContext
            builder.RegisterType<DefaultDataContextFactory<ProjectDataContext>>()
                   .As<IDataContextFactory<ProjectDataContext>>()
                   .InstancePerLifetimeScope();
            builder.RegisterType<EfUnitOfWork<ProjectDataContext>>().As<IUnitOfWork>().SingleInstance();
            #endregion
          
            /******************************业务区域Repository及Service**********************************/
            #region 注册服务Repository
            builder.RegisterType<SysUserRepository>().As<ISysUserRepository>().SingleInstance();
            builder.RegisterType<PersperationOrderRespository>().As<IPersperationOrderRespository>().SingleInstance();
            #endregion

            #region 注册服务接口
            builder.RegisterType<SysUserService>().As<ISysUserService>().SingleInstance();
            builder.RegisterType<PersperationOrderService>().
                    As<IPersperationOrderService>().InstancePerRequest();
            #endregion
        }
        
        public static T Resolve<T>()
        {
            return _Container.Resolve<T>();
        }

    }
}
