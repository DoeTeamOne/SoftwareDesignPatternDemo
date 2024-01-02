using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.SubSystems
{
    public  class DayOfTheWeekFactorServices
    {
        public double CalculateDayOfTheWeekFactor()
        {
            //fake Calculation for Demo Purpose
            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                        return 0.8;
                default:
                    return 1.2;
            }
        }
    }
}
