using FacadePattern.SubSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Facade
{
    /// <summary>
    /// the facade actually make a call to sub system services and makes it easy for the client to use the facade to comunicate with sub system
    /// </summary>
    public  class DiscountFacade
    {
        private readonly OrderServices _orderServices = new OrderServices();
        private readonly CustomerDiscountBaseService _customerDiscountBaseService = new CustomerDiscountBaseService();
        private readonly DayOfTheWeekFactorServices _dayOfTheWeekFactorServices = new DayOfTheWeekFactorServices();
        public double CalculateDiscountPercentage(int CustomerID)
        {
            if (!_orderServices.HasEnoughOrders(CustomerID))
            {
                return 0;
            }
            return _customerDiscountBaseService.CalculateDiscountBase(CustomerID) * _dayOfTheWeekFactorServices.CalculateDayOfTheWeekFactor();
        }
    }
}
