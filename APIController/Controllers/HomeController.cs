using EPCenterAPI.IoC;
using ProjectDomainModels.Orders;
using ProjectDomainModels.Users;
using ProjectFrameworkService.OrderService;
using ProjectFrameworkService.SysUserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPCenterAPI.Controllers
{
    public class HomeController : Controller
    {
        private ISysUserService _ISysUserService;

        private IPersperationOrderService _PersperationOrderService;


        public HomeController(ISysUserService ISysUserService,
            IPersperationOrderService PersperationOrderService)
        {
            //_ISysUserService = ISysUserService;
            _PersperationOrderService = PersperationOrderService;
        }

        public ActionResult Index()
        {

            //PersperationOrder order = new PersperationOrder();

            //order.OrderNo = "demo";
            //order.PatientId = "133";

            //_PersperationOrderService.AddOrder(order);

            //var myOrders = _PersperationOrderService.GetAllOrder();

            //var myPatientOrders = _PersperationOrderService.GetOrderByPersonID("133");

            ////如果某个Controller方法中的Service不在当前Controller注册方法中
            ////可采用Resolve方法来处理获取对应Service在Contrainer中的对应实例
            //_ISysUserService = IoCFactory.Resolve<ISysUserService>();

            //ViewBag.Title = "Home Page";

            //SysUserInfo user = new SysUserInfo() {
            //    Name = "dddd2",
            //    CreateDate = DateTime.Now,
            //     CreateUser = 1
            //};
            //_ISysUserService.AddUser(user);

            //var resultUsers = _ISysUserService.GetAll();

            return View();
        }



    }
}
