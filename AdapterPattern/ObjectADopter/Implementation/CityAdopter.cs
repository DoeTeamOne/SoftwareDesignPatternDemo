using AdapterPattern.ObjectADopter.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ObjectADopter.Implementation
{
    public class CityAdopter : IcityAdopter
    {
        public ExternalSystem ExternalSystem { get; set; } = new ExternalSystem();
        public City GetCity()
        {
            //Call External system to get the city
            var CityFromExternalsystem = ExternalSystem.GetCity();

            //Adopt theresult to our  city

            return new City(CityFromExternalsystem.Name + '-' + CityFromExternalsystem.NickName, CityFromExternalsystem.InHabitants);


        }
    }
}
