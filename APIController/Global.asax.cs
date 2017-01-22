using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Autofac;
using Autofac.Integration.WebApi;
using Autofac.Integration.Mvc;
using System.Reflection;
using RepositoryT.Infrastructure;
using ProjectEntityFrameworkDBAccess;
using ProjectEntityFramework;
using ProjectFrameworkRepository.UserRespository;
using ProjectFrameworkService.SysUserService;
using EPCenterAPI.IoC;

namespace EPCenterAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            #region IoC工厂注入及MVC Controller、APIController 2 IoC注册问题解决
            ContainerBuilder builder = new ContainerBuilder();
            new IoCFactory(builder);
            builder.RegisterControllers(Assembly.GetExecutingAssembly());     //Register MVC Controllers
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());  //Register WebApi Controllers

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container)); //Set the MVC DependencyResolver
            GlobalConfiguration.Configuration.DependencyResolver =
                         new AutofacWebApiDependencyResolver((IContainer)container);  //Set the WebApi DependencyResolver
            //由于采用工厂模式注入，对于container 的赋值目前无法在工厂内部Build()赋值
            //声明一个Static变量，对于IoCFactory方法进行赋值方便其它外部非依赖项目调用Resovle方法

            IoCFactory._Container = container;
            #endregion

        }
    }
}
