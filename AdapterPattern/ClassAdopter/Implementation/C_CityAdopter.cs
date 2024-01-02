using AdapterPattern.ObjectADopter.Abstruction;
using AdapterPattern.ObjectADopter.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ClassAdopter.Implementation
{
    public class C_CityAdopter :ExternalSystem, IcityAdopter
    {
        public City GetCity()
        {
            
            var cityFromExternalSystem = base.GetCity();
            return new City(cityFromExternalSystem.Name + '-' + cityFromExternalSystem.NickName, cityFromExternalSystem.InHabitants);
        }
    }
}
