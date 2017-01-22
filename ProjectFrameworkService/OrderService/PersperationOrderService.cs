using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDomainModels.Orders;
using ProjectFrameworkRepository.OrderRespository;
using RepositoryT.Infrastructure;

namespace ProjectFrameworkService.OrderService
{
    public class PersperationOrderService : IPersperationOrderService
    {
        private IPersperationOrderRespository _IPersperationOrderRespository;
        private readonly IUnitOfWork _unitOfWork;

        public PersperationOrderService(IUnitOfWork unitOfWork,
                                        IPersperationOrderRespository IPersperationOrderRespository)
        {
            _IPersperationOrderRespository = IPersperationOrderRespository;
            _unitOfWork = unitOfWork;
        }


        public int AddOrder(PersperationOrder order)
        {
            _IPersperationOrderRespository.Add(order);
            _unitOfWork.Commit();
            return order.Id;
        }

        public string UpdateOrder(PersperationOrder order)
        {
            try
            {
                _IPersperationOrderRespository.Update(order);
                return "success";
            }
            catch (Exception)
            {

                return "error";
            }
        }

        public IEnumerable<PersperationOrder> GetAllOrder()
        {
            return _IPersperationOrderRespository.GetAll();
        }

        public IEnumerable<PersperationOrder> GetOrderByPersonID(string PatientId)
        {
           return _IPersperationOrderRespository.GetAll()
                                                .Where(x=>x.PatientId == PatientId);
        }
    }
}
