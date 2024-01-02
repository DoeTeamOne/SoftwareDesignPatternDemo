using ProtoTypePattern.Abstruction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProtoTypePattern.Impelementation
{
    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }

        public Employee(string name , Manager manager)
        {
            Name = name;
            Manager = manager;
        }
        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var onjectAsJson = JsonSerializer.Serialize(this);
                return JsonSerializer.Deserialize<Employee>(onjectAsJson); // this Create Deep Copy of existing object
            }
            return (Person)MemberwiseClone();// it creates a shallow copy of the existing objects
        }
    }
}
