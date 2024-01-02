using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ObjectADopter.Implementation
{
    public class CityFromExternalSYstem
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public int InHabitants { get; set; }
        public CityFromExternalSYstem(string name, string nickName, int inHabitants)
        {
            Name = name;
            NickName = nickName;
            InHabitants = inHabitants;
        }
    }


    public class ExternalSystem
    {
        public CityFromExternalSYstem GetCity()
        {
            return new CityFromExternalSYstem("Madrid", "MD", 4000000);
        }
    }



    public class City
    {
        public string FullName { get; set; }
        public long Inhubitants { get; set; }
        public City(string fullname, long inhubitants)
        {
            FullName = fullname;

            Inhubitants = inhubitants;
        }
    }




}
