using ProtoTypePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProtoTypePattern.Impelementation
{
    public class Manager : Person
    {
        public override string Name { get; set; }

        public Manager(string name ) 
        {
            Name = name;
        }

        public override Person Clone(bool deepClone =false)
        {
            if( deepClone )
            {
                var onjectAsJson = JsonSerializer.Serialize( this );
                return JsonSerializer.Deserialize<Manager>(onjectAsJson); // this Create Deep Copy of existing object
            }

           return  (Person)MemberwiseClone(); // it creates a shallow copy of the existing objects
        }
    }
}
